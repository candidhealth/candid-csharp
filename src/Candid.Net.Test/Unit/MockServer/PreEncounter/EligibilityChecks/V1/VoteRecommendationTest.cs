using Candid.Net.PreEncounter.EligibilityChecks.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
public class VoteRecommendationTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "user_id": "user_id",
              "value": "UPVOTE"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "eligibility_check_id": "eligibility_check_id",
              "recommendation": {
                "type": "MEDICARE_ADVANTAGE",
                "payload": {
                  "ma_benefit": {
                    "key": "value"
                  },
                  "payer_id": "payer_id",
                  "payer_name": "payer_name",
                  "member_id": "member_id"
                }
              },
              "coverage_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "patient": {
                "id": "id",
                "mrn": "mrn",
                "organization_id": "organization_id",
                "last_name": "last_name",
                "first_name": "first_name",
                "date_of_birth": "2023-01-15",
                "member_id": "member_id"
              },
              "votes": [
                {
                  "user_id": "user_id",
                  "value": "UPVOTE"
                },
                {
                  "user_id": "user_id",
                  "value": "UPVOTE"
                }
              ],
              "organization_id": "organization_id",
              "deactivated": true,
              "version": 1,
              "updated_at": "2024-01-15T09:30:00.000Z",
              "updating_user_id": "updating_user_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/eligibility-checks/v1/recommendation/recommendation_id/version/vote"
                    )
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.VoteRecommendationAsync(
            "recommendation_id",
            "version",
            new Vote { UserId = "user_id", Value = VoteValue.Upvote }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
