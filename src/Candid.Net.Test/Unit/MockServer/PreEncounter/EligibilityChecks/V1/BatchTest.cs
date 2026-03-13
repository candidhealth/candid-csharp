using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.PreEncounter.EligibilityChecks.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
public class BatchTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            [
              {
                "payer_id": "payer_id",
                "provider": {
                  "npi": "npi"
                },
                "subscriber": {
                  "first_name": "first_name",
                  "last_name": "last_name"
                }
              },
              {
                "payer_id": "payer_id",
                "provider": {
                  "npi": "npi"
                },
                "subscriber": {
                  "first_name": "first_name",
                  "last_name": "last_name"
                }
              }
            ]
            """;

        const string mockResponse = """
            {
              "batch_id": "batch_id",
              "submitted_at": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/batch")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.BatchAsync(
            new List<EligibilityRequest>()
            {
                new EligibilityRequest
                {
                    PayerId = "payer_id",
                    Provider = new IndividualProvider { Npi = "npi" },
                    Subscriber = new MemberInfo
                    {
                        FirstName = "first_name",
                        LastName = "last_name",
                    },
                },
                new EligibilityRequest
                {
                    PayerId = "payer_id",
                    Provider = new IndividualProvider { Npi = "npi" },
                    Subscriber = new MemberInfo
                    {
                        FirstName = "first_name",
                        LastName = "last_name",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
