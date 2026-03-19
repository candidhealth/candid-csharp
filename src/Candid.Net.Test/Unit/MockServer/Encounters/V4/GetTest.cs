using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Encounters.V4;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "accident_state_or_province_code": "AA",
              "claim_creation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "patient_control_number": "patient_control_number",
              "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "claims": [
                {
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "status": "biller_received",
                  "clearinghouse": "clearinghouse",
                  "clearinghouse_claim_id": "clearinghouse_claim_id",
                  "payer_claim_id": "payer_claim_id",
                  "clia_number": "clia_number",
                  "service_lines": [
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                    },
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                  ],
                  "eras": [
                    {
                      "era_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "check_number": "check_number",
                      "check_date": "check_date"
                    },
                    {
                      "era_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "check_number": "check_number",
                      "check_date": "check_date"
                    }
                  ]
                },
                {
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "status": "biller_received",
                  "clearinghouse": "clearinghouse",
                  "clearinghouse_claim_id": "clearinghouse_claim_id",
                  "payer_claim_id": "payer_claim_id",
                  "clia_number": "clia_number",
                  "service_lines": [
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                    },
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                              "source_customer_id": "source_customer_id"
                            },
                            "patient_external_id": "patient_external_id",
                            "note": "note",
                            "due_date": "2023-01-15",
                            "status": "DRAFT",
                            "url": "url",
                            "customer_invoice_url": "customer_invoice_url",
                            "items": {
                              "claim_invoice_items": {},
                              "unattributed_items": []
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
                  ],
                  "eras": [
                    {
                      "era_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "check_number": "check_number",
                      "check_date": "check_date"
                    },
                    {
                      "era_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "check_number": "check_number",
                      "check_date": "check_date"
                    }
                  ]
                }
              ],
              "patient": {
                "individual_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "phone_numbers": [
                  {
                    "number": "number",
                    "type": "Home"
                  },
                  {
                    "number": "number",
                    "type": "Home"
                  }
                ],
                "phone_consent": true,
                "email": "email",
                "email_consent": true,
                "auto_charge_consent": true,
                "non_insurance_payers": [
                  {
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
                  {
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
                  }
                ],
                "non_insurance_payers_info": [
                  {
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
                    "member_id": "member_id",
                    "clinical_trial_info": [
                      {
                        "clinical_trial_arm": "clinical_trial_arm",
                        "clinical_trial": {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "is_active": true,
                          "name": "name",
                          "clinical_trial_number": "clinical_trial_number",
                          "clinical_trial_phase": "Phase 1"
                        }
                      },
                      {
                        "clinical_trial_arm": "clinical_trial_arm",
                        "clinical_trial": {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "is_active": true,
                          "name": "name",
                          "clinical_trial_number": "clinical_trial_number",
                          "clinical_trial_phase": "Phase 1"
                        }
                      }
                    ]
                  },
                  {
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
                    "member_id": "member_id",
                    "clinical_trial_info": [
                      {
                        "clinical_trial_arm": "clinical_trial_arm",
                        "clinical_trial": {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "is_active": true,
                          "name": "name",
                          "clinical_trial_number": "clinical_trial_number",
                          "clinical_trial_phase": "Phase 1"
                        }
                      },
                      {
                        "clinical_trial_arm": "clinical_trial_arm",
                        "clinical_trial": {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                          "is_active": true,
                          "name": "name",
                          "clinical_trial_number": "clinical_trial_number",
                          "clinical_trial_phase": "Phase 1"
                        }
                      }
                    ]
                  }
                ],
                "external_id": "external_id",
                "date_of_birth": "2023-01-15",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "first_name": "first_name",
                "last_name": "last_name",
                "gender": "male"
              },
              "guarantor": {
                "guarantor_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "phone_numbers": [
                  {
                    "number": "number",
                    "type": "Home"
                  },
                  {
                    "number": "number",
                    "type": "Home"
                  }
                ],
                "phone_consent": true,
                "email": "email",
                "email_consent": true,
                "auto_charge_consent": true,
                "first_name": "first_name",
                "last_name": "last_name",
                "external_id": "external_id",
                "date_of_birth": "2023-01-15",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                }
              },
              "billing_provider": {
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
              "rendering_provider": {
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
              "attending_provider": {
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
              "admission_hour": 1,
              "admission_type_code": "1",
              "admission_source_code": "1",
              "discharge_hour": 1,
              "discharge_status": "01",
              "operating_provider": {
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
              "other_operating_provider": {
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
              "related_causes_information": {
                "related_causes_code_1": "AA",
                "related_causes_code_2": "AA",
                "state_or_province_code": "state_or_province_code"
              },
              "property_casualty_claim_number": "property_casualty_claim_number",
              "accident_date": "2023-01-15",
              "property_casualty_patient_identifier": {
                "property_casualty_patient_identifier_qualifier": "1W",
                "property_casualty_patient_identifier": "property_casualty_patient_identifier"
              },
              "submission_expectation": "TARGET_PROFESSIONAL",
              "type_of_bill": {
                "code": "code",
                "type_of_facility": "1",
                "type_of_care": "1",
                "frequency_code": "0"
              },
              "referring_provider": {
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
              "initial_referring_provider": {
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
              "supervising_provider": {
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
              "service_facility": {
                "service_facility_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "organization_name": "organization_name",
                "npi": "npi",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "secondary_identification": "secondary_identification",
                "mammography_certification_number": "mammography_certification_number"
              },
              "subscriber_primary": {
                "individual_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "insurance_card": {
                  "insurance_card_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "member_id": "member_id",
                  "payer_name": "payer_name",
                  "payer_id": "payer_id",
                  "rx_bin": "rx_bin",
                  "rx_pcn": "rx_pcn",
                  "image_url_front": "image_url_front",
                  "image_url_back": "image_url_back",
                  "group_number": "group_number",
                  "plan_name": "plan_name",
                  "plan_type": "09",
                  "insurance_type": "01",
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payer_address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  }
                },
                "patient_relationship_to_subscriber_code": "01",
                "date_of_birth": "2023-01-15",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "first_name": "first_name",
                "last_name": "last_name",
                "gender": "male"
              },
              "subscriber_secondary": {
                "individual_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "insurance_card": {
                  "insurance_card_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "member_id": "member_id",
                  "payer_name": "payer_name",
                  "payer_id": "payer_id",
                  "rx_bin": "rx_bin",
                  "rx_pcn": "rx_pcn",
                  "image_url_front": "image_url_front",
                  "image_url_back": "image_url_back",
                  "group_number": "group_number",
                  "plan_name": "plan_name",
                  "plan_type": "09",
                  "insurance_type": "01",
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payer_address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  }
                },
                "patient_relationship_to_subscriber_code": "01",
                "date_of_birth": "2023-01-15",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "first_name": "first_name",
                "last_name": "last_name",
                "gender": "male"
              },
              "subscriber_tertiary": {
                "individual_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "insurance_card": {
                  "insurance_card_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "member_id": "member_id",
                  "payer_name": "payer_name",
                  "payer_id": "payer_id",
                  "rx_bin": "rx_bin",
                  "rx_pcn": "rx_pcn",
                  "image_url_front": "image_url_front",
                  "image_url_back": "image_url_back",
                  "group_number": "group_number",
                  "plan_name": "plan_name",
                  "plan_type": "09",
                  "insurance_type": "01",
                  "payer_plan_group_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "payer_address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  }
                },
                "patient_relationship_to_subscriber_code": "01",
                "date_of_birth": "2023-01-15",
                "address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
                },
                "first_name": "first_name",
                "last_name": "last_name",
                "gender": "male"
              },
              "prior_authorization_number": "prior_authorization_number",
              "responsible_party": "INSURANCE_PAY",
              "url": "url",
              "diagnoses": [
                {
                  "diagnosis_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "name": "name",
                  "code_type": "ABF",
                  "code": "code",
                  "present_on_admission_indicator": "YES"
                },
                {
                  "diagnosis_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "updated_at": "2024-01-15T09:30:00.000Z",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "name": "name",
                  "code_type": "ABF",
                  "code": "code",
                  "present_on_admission_indicator": "YES"
                }
              ],
              "clinical_notes": [
                {
                  "category": "clinical",
                  "notes": [
                    "notes",
                    "notes"
                  ],
                  "notes_structured": [
                    {
                      "text": "text",
                      "author_name": "author_name",
                      "author_npi": "author_npi",
                      "timestamp": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "text": "text",
                      "author_name": "author_name",
                      "author_npi": "author_npi",
                      "timestamp": "2024-01-15T09:30:00.000Z"
                    }
                  ]
                },
                {
                  "category": "clinical",
                  "notes": [
                    "notes",
                    "notes"
                  ],
                  "notes_structured": [
                    {
                      "text": "text",
                      "author_name": "author_name",
                      "author_npi": "author_npi",
                      "timestamp": "2024-01-15T09:30:00.000Z"
                    },
                    {
                      "text": "text",
                      "author_name": "author_name",
                      "author_npi": "author_npi",
                      "timestamp": "2024-01-15T09:30:00.000Z"
                    }
                  ]
                }
              ],
              "billing_notes": [
                {
                  "billing_note_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "author_auth0_id": "author_auth0_id",
                  "author_name": "author_name",
                  "text": "text"
                },
                {
                  "billing_note_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "created_at": "2024-01-15T09:30:00.000Z",
                  "author_auth0_id": "author_auth0_id",
                  "author_name": "author_name",
                  "text": "text"
                }
              ],
              "place_of_service_code": "01",
              "place_of_service_code_as_submitted": "01",
              "patient_histories": [
                {
                  "category": "present_illness",
                  "questions": [
                    {
                      "id": "id",
                      "text": "text",
                      "responses": [
                        {
                          "response": "response",
                          "follow_ups": []
                        },
                        {
                          "response": "response",
                          "follow_ups": []
                        }
                      ]
                    },
                    {
                      "id": "id",
                      "text": "text",
                      "responses": [
                        {
                          "response": "response",
                          "follow_ups": []
                        },
                        {
                          "response": "response",
                          "follow_ups": []
                        }
                      ]
                    }
                  ]
                },
                {
                  "category": "present_illness",
                  "questions": [
                    {
                      "id": "id",
                      "text": "text",
                      "responses": [
                        {
                          "response": "response",
                          "follow_ups": []
                        },
                        {
                          "response": "response",
                          "follow_ups": []
                        }
                      ]
                    },
                    {
                      "id": "id",
                      "text": "text",
                      "responses": [
                        {
                          "response": "response",
                          "follow_ups": []
                        },
                        {
                          "response": "response",
                          "follow_ups": []
                        }
                      ]
                    }
                  ]
                }
              ],
              "patient_payments": [
                {
                  "patient_payment_id": "patient_payment_id",
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_internal_id": "source_internal_id",
                  "source": "MANUAL_ENTRY",
                  "amount_cents": 1,
                  "payment_timestamp": "2024-01-15T09:30:00.000Z",
                  "status": "PENDING",
                  "payment_name": "payment_name",
                  "payment_note": "payment_note",
                  "patient_external_id": "patient_external_id",
                  "encounter_external_id": "encounter_external_id",
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "patient_payment_id": "patient_payment_id",
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "source_internal_id": "source_internal_id",
                  "source": "MANUAL_ENTRY",
                  "amount_cents": 1,
                  "payment_timestamp": "2024-01-15T09:30:00.000Z",
                  "status": "PENDING",
                  "payment_name": "payment_name",
                  "payment_note": "payment_note",
                  "patient_external_id": "patient_external_id",
                  "encounter_external_id": "encounter_external_id",
                  "service_line_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "tags": [
                {
                  "creator_id": "creator_id",
                  "tag_id": "tag_id",
                  "description": "description",
                  "color": "black"
                },
                {
                  "creator_id": "creator_id",
                  "tag_id": "tag_id",
                  "description": "description",
                  "color": "black"
                }
              ],
              "coding_attribution": "CANDID",
              "work_queue_id": "work_queue_id",
              "work_queue_membership_activated_at": "2024-01-15T09:30:00.000Z",
              "owner_of_next_action": "CANDID",
              "submission_origin": "CANDID",
              "schema_instances": [
                {
                  "schema_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "content": {
                    "content": {
                      "key": "value"
                    }
                  }
                },
                {
                  "schema_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "content": {
                    "content": {
                      "key": "value"
                    }
                  }
                }
              ],
              "referral_number": "referral_number",
              "epsdt_referral": {
                "condition_indicator1": "AV",
                "condition_indicator2": "AV",
                "condition_indicator3": "AV"
              },
              "claim_supplemental_information": [
                {
                  "attachment_report_type_code": "03",
                  "attachment_transmission_code": "BM",
                  "attachment_control_number": "attachment_control_number"
                },
                {
                  "attachment_report_type_code": "03",
                  "attachment_transmission_code": "BM",
                  "attachment_control_number": "attachment_control_number"
                }
              ],
              "secondary_payer_carrier_code": "secondary_payer_carrier_code",
              "last_submitted_at": "2024-01-15T09:30:00.000Z",
              "created_at": "2024-01-15T09:30:00.000Z",
              "next_responsible_party": "primary",
              "external_id": "external_id",
              "date_of_service": "2023-01-15",
              "end_date_of_service": "2023-01-15",
              "patient_authorized_release": true,
              "benefits_assigned_to_provider": true,
              "provider_accepts_assignment": true,
              "appointment_type": "appointment_type",
              "existing_medications": [
                {
                  "name": "name",
                  "rx_cui": "rx_cui",
                  "dosage": "dosage",
                  "dosage_form": "dosage_form",
                  "frequency": "frequency",
                  "as_needed": true
                },
                {
                  "name": "name",
                  "rx_cui": "rx_cui",
                  "dosage": "dosage",
                  "dosage_form": "dosage_form",
                  "frequency": "frequency",
                  "as_needed": true
                }
              ],
              "interventions": [
                {
                  "name": "name",
                  "category": "allopathic",
                  "description": "description",
                  "medication": {
                    "name": "name",
                    "rx_cui": "rx_cui",
                    "dosage": "dosage",
                    "dosage_form": "dosage_form",
                    "frequency": "frequency",
                    "as_needed": true
                  },
                  "labs": [
                    {
                      "name": "name",
                      "code": "code",
                      "code_type": "quest"
                    },
                    {
                      "name": "name",
                      "code": "code",
                      "code_type": "quest"
                    }
                  ]
                },
                {
                  "name": "name",
                  "category": "allopathic",
                  "description": "description",
                  "medication": {
                    "name": "name",
                    "rx_cui": "rx_cui",
                    "dosage": "dosage",
                    "dosage_form": "dosage_form",
                    "frequency": "frequency",
                    "as_needed": true
                  },
                  "labs": [
                    {
                      "name": "name",
                      "code": "code",
                      "code_type": "quest"
                    },
                    {
                      "name": "name",
                      "code": "code",
                      "code_type": "quest"
                    }
                  ]
                }
              ],
              "pay_to_address": {
                "zip_plus_four_code": "zip_plus_four_code",
                "address1": "address1",
                "address2": "address2",
                "city": "city",
                "state": "AA",
                "zip_code": "zip_code"
              },
              "synchronicity": "Synchronous",
              "vitals": {
                "height_in": 1,
                "weight_lbs": 1,
                "blood_pressure_systolic_mmhg": 1,
                "blood_pressure_diastolic_mmhg": 1,
                "body_temperature_f": 1.1,
                "hemoglobin_gdl": 1.1,
                "hematocrit_pct": 1.1
              },
              "billable_status": "BILLABLE",
              "additional_information": "additional_information",
              "service_authorization_exception_code": "1",
              "admission_date": "2023-01-15",
              "discharge_date": "2023-01-15",
              "onset_of_current_illness_or_symptom_date": "2023-01-15",
              "last_menstrual_period_date": "2023-01-15",
              "delay_reason_code": "1"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/encounters/v4/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Encounters.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
