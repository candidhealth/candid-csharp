using global::Candid.Net.PatientRefunds.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.PatientRefunds.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "patient_refund_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "source_internal_id": "source_internal_id",
              "refund_source": "MANUAL_ENTRY",
              "amount_cents": 1,
              "patient_external_id": "patient_external_id",
              "refund_timestamp": "2024-01-15T09:30:00.000Z",
              "refund_note": "refund_note",
              "allocations": [
                {
                  "amount_cents": 1,
                  "target": {
                    "type": "service_line",
                    "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "earmark": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "target": {
                      "type": "date_of_service",
                      "value": "target"
                    },
                    "amount_earmarked_cents": 1,
                    "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "allocated_on": "2024-01-15T09:30:00.000Z"
                },
                {
                  "amount_cents": 1,
                  "target": {
                    "type": "service_line",
                    "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "earmark": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "target": {
                      "type": "date_of_service",
                      "value": "target"
                    },
                    "amount_earmarked_cents": 1,
                    "created_by_allocation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  },
                  "allocated_on": "2024-01-15T09:30:00.000Z"
                }
              ],
              "invoice": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "refund_reason": "OVERCHARGED"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/patient-refunds/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PatientRefunds.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new PatientRefundUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
