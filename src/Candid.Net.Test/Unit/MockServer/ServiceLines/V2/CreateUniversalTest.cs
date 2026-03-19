using global::Candid.Net.Commons;
using global::Candid.Net.ServiceLines.V2;
using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ServiceLines.V2;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateUniversalTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "quantity": "quantity",
              "units": "MJ",
              "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        const string mockResponse = """
            {
              "created_at": "2024-01-15T09:30:00.000Z",
              "modifiers": [
                "AV",
                "AV"
              ],
              "charge_amount_cents": 1,
              "allowed_amount_cents": 1,
              "insurance_balance_cents": 1,
              "patient_balance_cents": 1,
              "paid_amount_cents": 1,
              "primary_paid_amount_cents": 1,
              "secondary_paid_amount_cents": 1,
              "tertiary_paid_amount_cents": 1,
              "patient_responsibility_cents": 1,
              "copay_cents": 1,
              "coinsurance_cents": 1,
              "deductible_cents": 1,
              "diagnosis_id_zero": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "diagnosis_id_one": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "diagnosis_id_two": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "diagnosis_id_three": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "drug_identification": {
                "service_id_qualifier": "EN",
                "national_drug_code": "national_drug_code",
                "national_drug_unit_count": "national_drug_unit_count",
                "measurement_unit_code": "ML",
                "link_sequence_number": "link_sequence_number",
                "pharmacy_prescription_number": "pharmacy_prescription_number",
                "conversion_formula": "conversion_formula",
                "drug_description": "drug_description"
              },
              "service_line_era_data": {
                "service_line_adjustments": [
                  {
                    "created_at": "2024-01-15T09:30:00.000Z",
                    "adjustment_group_code": "adjustment_group_code",
                    "adjustment_reason_code": "adjustment_reason_code",
                    "adjustment_amount_cents": 1,
                    "adjustment_note": "adjustment_note"
                  },
                  {
                    "created_at": "2024-01-15T09:30:00.000Z",
                    "adjustment_group_code": "adjustment_group_code",
                    "adjustment_reason_code": "adjustment_reason_code",
                    "adjustment_amount_cents": 1,
                    "adjustment_note": "adjustment_note"
                  }
                ],
                "remittance_advice_remark_codes": [
                  "remittance_advice_remark_codes",
                  "remittance_advice_remark_codes"
                ]
              },
              "service_line_manual_adjustments": [
                {
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "adjustment_group_code": "adjustment_group_code",
                  "adjustment_reason_code": "adjustment_reason_code",
                  "adjustment_amount_cents": 1,
                  "adjustment_note": "adjustment_note"
                },
                {
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "adjustment_group_code": "adjustment_group_code",
                  "adjustment_reason_code": "adjustment_reason_code",
                  "adjustment_amount_cents": 1,
                  "adjustment_note": "adjustment_note"
                }
              ],
              "related_invoices": [
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "organzation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_id": "source_id",
                  "source_customer_id": "source_customer_id",
                  "patient_external_id": "patient_external_id",
                  "note": "note",
                  "due_date": "due_date",
                  "status": "draft",
                  "url": "url",
                  "customer_invoice_url": "customer_invoice_url",
                  "items": [
                    {
                      "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "amount_cents": 1
                    },
                    {
                      "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "amount_cents": 1
                    }
                  ]
                },
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "organzation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_id": "source_id",
                  "source_customer_id": "source_customer_id",
                  "patient_external_id": "patient_external_id",
                  "note": "note",
                  "due_date": "due_date",
                  "status": "draft",
                  "url": "url",
                  "customer_invoice_url": "customer_invoice_url",
                  "items": [
                    {
                      "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "amount_cents": 1
                    },
                    {
                      "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "amount_cents": 1
                    }
                  ]
                }
              ],
              "related_invoice_info": [
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "invoice": {
                    "amount_cents": 1,
                    "created_at": "2024-01-15T09:30:00.000Z",
                    "updated_at": "2024-01-15T09:30:00.000Z",
                    "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "invoice_destination_metadata": {
                      "invoice_destination": "STRIPE",
                      "source_id": "source_id",
                      "source_customer_id": "source_customer_id",
                      "destination_status": "destination_status"
                    },
                    "patient_external_id": "patient_external_id",
                    "note": "note",
                    "due_date": "2023-01-15",
                    "status": "DRAFT",
                    "url": "url",
                    "customer_invoice_url": "customer_invoice_url",
                    "items": {
                      "claim_invoice_items": {
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                          "claim_invoice_item": {
                            "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            "amount_cents": 1
                          },
                          "service_line_invoice_items": {
                            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                              "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                              "amount_cents": 1
                            }
                          }
                        }
                      },
                      "unattributed_items": [
                        {
                          "amount_cents": 1
                        },
                        {
                          "amount_cents": 1
                        }
                      ]
                    }
                  },
                  "invoice_type": "STRIPE"
                },
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "invoice": {
                    "amount_cents": 1,
                    "created_at": "2024-01-15T09:30:00.000Z",
                    "updated_at": "2024-01-15T09:30:00.000Z",
                    "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "invoice_destination_metadata": {
                      "invoice_destination": "STRIPE",
                      "source_id": "source_id",
                      "source_customer_id": "source_customer_id",
                      "destination_status": "destination_status"
                    },
                    "patient_external_id": "patient_external_id",
                    "note": "note",
                    "due_date": "2023-01-15",
                    "status": "DRAFT",
                    "url": "url",
                    "customer_invoice_url": "customer_invoice_url",
                    "items": {
                      "claim_invoice_items": {
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                          "claim_invoice_item": {
                            "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            "amount_cents": 1
                          },
                          "service_line_invoice_items": {
                            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32": {
                              "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                              "amount_cents": 1
                            }
                          }
                        }
                      },
                      "unattributed_items": [
                        {
                          "amount_cents": 1
                        },
                        {
                          "amount_cents": 1
                        }
                      ]
                    }
                  },
                  "invoice_type": "STRIPE"
                }
              ],
              "denial_reason": {
                "reason": "Authorization Required"
              },
              "place_of_service_code": "01",
              "place_of_service_code_as_submitted": "01",
              "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "procedure_code": "procedure_code",
              "ordering_provider": {
                "provider_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "tax_id": "tax_id",
                "npi": "npi",
                "taxonomy_code": "taxonomy_code",
                "qualifier": "DQ",
                "provider_commercial_license_type": "0",
                "secondary_identification": {
                  "reference_identification": "reference_identification",
                  "reference_identification_qualifier": "0B"
                },
                "first_name": "first_name",
                "last_name": "last_name",
                "organization_name": "organization_name"
              },
              "revenue_code": "revenue_code",
              "quantity": "quantity",
              "units": "MJ",
              "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "date_of_service_range": {
                "start_date": "start_date",
                "end_date": "end_date"
              },
              "description": "description",
              "date_of_service": "2023-01-15",
              "end_date_of_service": "2023-01-15",
              "test_results": [
                {
                  "value": 1.1,
                  "result_type": "HEMATOCRIT"
                },
                {
                  "value": 1.1,
                  "result_type": "HEMATOCRIT"
                }
              ],
              "has_epsdt_indicator": true,
              "has_family_planning_indicator": true,
              "note": "note",
              "prior_authorization_number": "prior_authorization_number",
              "external_id": "external_id"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/service-lines/v2/universal")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ServiceLines.V2.CreateUniversalAsync(
            new UniversalServiceLineCreateStandalone
            {
                Quantity = "quantity",
                Units = ServiceLineUnits.Mj,
                ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
