using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.EligibilityChecks.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateEncounterEligibilityTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "encounter_id": "encounter_id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "source": "STEDI",
              "dateOfService": "2024-01-15T09:30:00.000Z",
              "payerId": "payerId",
              "providerNPI": "providerNPI",
              "dependent": {
                "name": "name"
              },
              "status": "ACTIVE",
              "errors": [
                {
                  "source": "CANDID",
                  "errorDetails": {
                    "field?": "field?",
                    "description?": "description?",
                    "location?": "location?",
                    "possibleResolutions?": "possibleResolutions?",
                    "code?": "code?",
                    "followupAction?": "followupAction?"
                  }
                },
                {
                  "source": "CANDID",
                  "errorDetails": {
                    "field?": "field?",
                    "description?": "description?",
                    "location?": "location?",
                    "possibleResolutions?": "possibleResolutions?",
                    "code?": "code?",
                    "followupAction?": "followupAction?"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/eligibility-checks/v1/eligibility")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response =
            await Client.PreEncounter.EligibilityChecks.V1.CreateEncounterEligibilityAsync(
                new EncounterEligibilityRequest { EncounterId = "encounter_id" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
