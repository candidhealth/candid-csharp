using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InsuranceDiscoveryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "provider": {
                "npi": "npi"
              },
              "subscriber": {
                "first_name": "first_name",
                "last_name": "last_name"
              }
            }
            """;

        const string mockResponse = """
            {
              "discovery_id": "discovery_id",
              "status": "PENDING",
              "items": [
                {
                  "key": "value"
                },
                {
                  "key": "value"
                }
              ],
              "coverages_found": 1,
              "errors": [
                {
                  "field?": "field?",
                  "description?": "description?",
                  "location?": "location?",
                  "possibleResolutions?": "possibleResolutions?",
                  "code?": "code?",
                  "followupAction?": "followupAction?"
                },
                {
                  "field?": "field?",
                  "description?": "description?",
                  "location?": "location?",
                  "possibleResolutions?": "possibleResolutions?",
                  "code?": "code?",
                  "followupAction?": "followupAction?"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/insurance-discovery")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.EligibilityChecks.V1.InsuranceDiscoveryAsync(
            new InsuranceDiscoveryRequest
            {
                Provider = new InsuranceDiscoveryProvider { Npi = "npi" },
                Subscriber = new InsuranceDiscoverySubscriber
                {
                    FirstName = "first_name",
                    LastName = "last_name",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
