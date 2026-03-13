using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.NonInsurancePayerRefunds.V1;

[TestFixture]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "non_insurance_payer_refund_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "non_insurance_payer": {
                "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "name": "name",
                "description": "description",
                "category": "category",
                "enabled": true,
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "clinical_trials": [
                  {
                    "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "is_active": true,
                    "name": "name",
                    "clinical_trial_number": "clinical_trial_number",
                    "clinical_trial_phase": "Phase 1"
                  },
                  {
                    "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "is_active": true,
                    "name": "name",
                    "clinical_trial_number": "clinical_trial_number",
                    "clinical_trial_phase": "Phase 1"
                  }
                ]
              },
              "amount_cents": 1,
              "refund_timestamp": "2024-01-15T09:30:00.000Z",
              "refund_note": "refund_note",
              "check_number": "check_number",
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
              "refund_reason": "OVERCHARGED",
              "invoice_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/non-insurance-payer-refunds/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.NonInsurancePayerRefunds.V1.GetAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
