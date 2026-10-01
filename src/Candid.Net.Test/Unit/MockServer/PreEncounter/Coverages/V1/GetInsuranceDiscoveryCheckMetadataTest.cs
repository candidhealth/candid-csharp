using global::Candid.Net.PreEncounter.Coverages.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PreEncounter.Coverages.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetInsuranceDiscoveryCheckMetadataTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "check_id": "check_id",
                "status": "PENDING",
                "initiated_by": "initiated_by",
                "initiated_at": "2024-01-15T09:30:00.000Z"
              },
              {
                "check_id": "check_id",
                "status": "PENDING",
                "initiated_by": "initiated_by",
                "initiated_at": "2024-01-15T09:30:00.000Z"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/coverages/v1/insurance-discovery/check-metadata")
                    .WithParam("patient_id", "patient_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response =
            await Client.PreEncounter.Coverages.V1.GetInsuranceDiscoveryCheckMetadataAsync(
                new GetInsuranceDiscoveryCheckMetadataRequest { PatientId = "patient_id" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
