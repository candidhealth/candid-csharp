using global::Candid.Net.ExternalConsolidatedRemit.V1;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ExternalConsolidatedRemit.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTransactionsTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "type": "insurance_payment",
                  "provider_adjustment_reason_code": "provider_adjustment_reason_code",
                  "voids_transaction_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "remit_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "consolidated_remit_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "era_payer_name": "era_payer_name",
                  "target_type": "ORGANIZATION",
                  "target_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_service_facility_external_id": "organization_service_facility_external_id",
                  "amount_cents": 1,
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "is_void": true,
                  "posted_at": "2024-01-15T09:30:00.000Z",
                  "posted_by": "posted_by",
                  "voided_at": "2024-01-15T09:30:00.000Z",
                  "voided_by": "voided_by",
                  "source": {
                    "type": "era_service_payment",
                    "era_service_payment": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "era_claim_payment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "adjudicated_procedure_code": "adjudicated_procedure_code",
                      "adjudicated_modifiers": [
                        "adjudicated_modifiers",
                        "adjudicated_modifiers"
                      ],
                      "original_procedure_code": "original_procedure_code",
                      "original_modifiers": [
                        "original_modifiers",
                        "original_modifiers"
                      ],
                      "allowed_amount_cents": 1,
                      "line_item_charge_amount_cents": 1,
                      "line_item_provider_payment_amount_cents": 1,
                      "unit_of_service_paid_count": 1,
                      "rarcs": [
                        {
                          "reason_code": "M1"
                        },
                        {
                          "reason_code": "M1"
                        }
                      ],
                      "adjustments": [
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        },
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        }
                      ]
                    },
                    "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "era_claim_payment": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "patient_control_number": "patient_control_number",
                      "payer_claim_control_number": "payer_claim_control_number",
                      "claim_status_code": "1",
                      "total_claim_charge_amount_cents": 1,
                      "claim_payment_amount_cents": 1,
                      "patient_responsibility_amount_cents": 1,
                      "adjustments": [
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        },
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        }
                      ]
                    }
                  }
                },
                {
                  "type": "insurance_payment",
                  "provider_adjustment_reason_code": "provider_adjustment_reason_code",
                  "voids_transaction_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "remit_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "consolidated_remit_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "era_payer_name": "era_payer_name",
                  "target_type": "ORGANIZATION",
                  "target_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "organization_service_facility_external_id": "organization_service_facility_external_id",
                  "amount_cents": 1,
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "is_void": true,
                  "posted_at": "2024-01-15T09:30:00.000Z",
                  "posted_by": "posted_by",
                  "voided_at": "2024-01-15T09:30:00.000Z",
                  "voided_by": "voided_by",
                  "source": {
                    "type": "era_service_payment",
                    "era_service_payment": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "era_claim_payment_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "adjudicated_procedure_code": "adjudicated_procedure_code",
                      "adjudicated_modifiers": [
                        "adjudicated_modifiers",
                        "adjudicated_modifiers"
                      ],
                      "original_procedure_code": "original_procedure_code",
                      "original_modifiers": [
                        "original_modifiers",
                        "original_modifiers"
                      ],
                      "allowed_amount_cents": 1,
                      "line_item_charge_amount_cents": 1,
                      "line_item_provider_payment_amount_cents": 1,
                      "unit_of_service_paid_count": 1,
                      "rarcs": [
                        {
                          "reason_code": "M1"
                        },
                        {
                          "reason_code": "M1"
                        }
                      ],
                      "adjustments": [
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        },
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        }
                      ]
                    },
                    "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "era_claim_payment": {
                      "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "patient_control_number": "patient_control_number",
                      "payer_claim_control_number": "payer_claim_control_number",
                      "claim_status_code": "1",
                      "total_claim_charge_amount_cents": 1,
                      "claim_payment_amount_cents": 1,
                      "patient_responsibility_amount_cents": 1,
                      "adjustments": [
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        },
                        {
                          "adjustment_group_code": "CO",
                          "adjustment_reason_code": "1",
                          "adjustment_amount_cents": 1,
                          "adjustment_quantity": 1
                        }
                      ]
                    }
                  }
                }
              ],
              "prev_page_token": "prev_page_token",
              "next_page_token": "next_page_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/external-consolidated-remit/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/transactions"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ExternalConsolidatedRemit.V1.GetTransactionsAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new GetExternalConsolidatedRemitTransactionsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
