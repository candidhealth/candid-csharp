using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetInsuranceDiscoveryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "metadata": {
                "check_id": "check_id",
                "status": "PENDING",
                "initiated_by": "initiated_by",
                "initiated_at": "2024-01-15T09:30:00.000Z"
              },
              "response": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/insurance-discovery/check_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.GetInsuranceDiscoveryAsync(
            "check_id"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
