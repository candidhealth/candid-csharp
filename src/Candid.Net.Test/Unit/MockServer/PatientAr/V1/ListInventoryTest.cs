using global::Candid.Net.PatientAr.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PatientAr.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListInventoryTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "records": [
                {
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "patient_external_id": "patient_external_id",
                  "patient_ar_status": "invoiceable"
                },
                {
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "timestamp": "2024-01-15T09:30:00.000Z",
                  "patient_external_id": "patient_external_id",
                  "patient_ar_status": "invoiceable"
                }
              ],
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/patient-ar/v1/inventory")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PatientAr.V1.ListInventoryAsync(
            new GetInventoryRecordsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
