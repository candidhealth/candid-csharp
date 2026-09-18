using global::Candid.Net.Eligibility.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::System.Globalization;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Eligibility.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FindAvailityEligibilityResultsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "member_id": "member_id",
              "payer_id": "payer_id",
              "date_of_service": "2024-01-15T09:30:00.000Z",
              "provider_npi": "provider_npi"
            }
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "id": "id",
                  "dateOfService": "2024-01-15T09:30:00.000Z",
                  "payerId": "payerId",
                  "providerNPI": "providerNPI",
                  "dependent": "dependent",
                  "status": "ACTIVE"
                },
                {
                  "id": "id",
                  "dateOfService": "2024-01-15T09:30:00.000Z",
                  "payerId": "payerId",
                  "providerNPI": "providerNPI",
                  "dependent": "dependent",
                  "status": "ACTIVE"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/eligibility/v2/existing-checks")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Eligibility.V2.FindAvailityEligibilityResultsAsync(
            new FindAvailityEligibilityResultsRequest
            {
                MemberId = "member_id",
                PayerId = "payer_id",
                DateOfService = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                ProviderNpi = "provider_npi",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
