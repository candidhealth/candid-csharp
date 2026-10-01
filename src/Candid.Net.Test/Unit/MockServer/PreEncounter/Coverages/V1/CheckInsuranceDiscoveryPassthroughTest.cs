using global::Candid.Net.PreEncounter.EligibilityChecks.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CheckInsuranceDiscoveryPassthroughTest : BaseMockServerTest
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
              "check_id": "check_id",
              "status": "PENDING",
              "initiated_by": "initiated_by",
              "initiated_at": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/insurance-discovery-passthrough")
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
            await Client.PreEncounter.Coverages.V1.CheckInsuranceDiscoveryPassthroughAsync(
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
