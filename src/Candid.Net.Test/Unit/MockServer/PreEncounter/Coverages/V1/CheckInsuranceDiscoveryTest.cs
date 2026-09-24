using global::Candid.Net.PreEncounter.Coverages.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CheckInsuranceDiscoveryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "patient_id": "patient_id",
              "date_of_service": "2023-01-15",
              "npi": "npi"
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
                    .WithPath("/coverages/v1/insurance-discovery")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreEncounter.Coverages.V1.CheckInsuranceDiscoveryAsync(
            new CheckInsuranceDiscoveryRequest
            {
                PatientId = "patient_id",
                DateOfService = new DateOnly(2023, 1, 15),
                Npi = "npi",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
