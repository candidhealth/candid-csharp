using Candid.Net.ChargeCapture.V1;
using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.ChargeCapture.V1;

[TestFixture]
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
              "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
              "status": "planned",
              "charge_capture_data": {
                "vitals": {
                  "height_in": 1,
                  "weight_lbs": 1,
                  "blood_pressure_systolic_mmhg": 1,
                  "blood_pressure_diastolic_mmhg": 1,
                  "body_temperature_f": 1.1,
                  "hemoglobin_gdl": 1.1,
                  "hematocrit_pct": 1.1
                },
                "diagnoses": [
                  {
                    "name": "name",
                    "code_type": "ABF",
                    "code": "code",
                    "present_on_admission_indicator": "YES"
                  },
                  {
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
                "epsdt_referral": {
                  "condition_indicator1": "AV",
                  "condition_indicator2": "AV",
                  "condition_indicator3": "AV"
                },
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
                "guarantor": {
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
                  },
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
                  "auto_charge_consent": true
                },
                "subscriber_primary": {
                  "insurance_card": {
                    "member_id": "member_id",
                    "payer_name": "payer_name",
                    "payer_id": "payer_id",
                    "rx_bin": "rx_bin",
                    "rx_pcn": "rx_pcn",
                    "image_url_front": "image_url_front",
                    "image_url_back": "image_url_back",
                    "emr_payer_crosswalk": "HEALTHIE",
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
                  "insurance_card": {
                    "member_id": "member_id",
                    "payer_name": "payer_name",
                    "payer_id": "payer_id",
                    "rx_bin": "rx_bin",
                    "rx_pcn": "rx_pcn",
                    "image_url_front": "image_url_front",
                    "image_url_back": "image_url_back",
                    "emr_payer_crosswalk": "HEALTHIE",
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
                  "insurance_card": {
                    "member_id": "member_id",
                    "payer_name": "payer_name",
                    "payer_id": "payer_id",
                    "rx_bin": "rx_bin",
                    "rx_pcn": "rx_pcn",
                    "image_url_front": "image_url_front",
                    "image_url_back": "image_url_back",
                    "emr_payer_crosswalk": "HEALTHIE",
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
                "external_claim_submission": {
                  "claim_created_at": "2024-01-15T09:30:00.000Z",
                  "patient_control_number": "patient_control_number",
                  "submission_records": [
                    {
                      "submitted_at": "2024-01-15T09:30:00.000Z",
                      "claim_frequency_code": "0",
                      "payer_responsibility": "primary",
                      "intended_submission_medium": "paper"
                    },
                    {
                      "submitted_at": "2024-01-15T09:30:00.000Z",
                      "claim_frequency_code": "0",
                      "payer_responsibility": "primary",
                      "intended_submission_medium": "paper"
                    }
                  ]
                },
                "service_lines": [
                  {
                    "modifiers": [
                      "AV",
                      "AV"
                    ],
                    "has_epsdt_indicator": true,
                    "has_family_planning_indicator": true,
                    "procedure_code": "procedure_code",
                    "quantity": "quantity",
                    "units": "MJ",
                    "charge_amount_cents": 1,
                    "diagnosis_pointers": [
                      1,
                      1
                    ],
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
                    "place_of_service_code": "01",
                    "description": "description",
                    "date_of_service": "2023-01-15",
                    "end_date_of_service": "2023-01-15",
                    "ordering_provider": {
                      "npi": "npi",
                      "taxonomy_code": "taxonomy_code",
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
                      "organization_name": "organization_name"
                    },
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
                    "note": "note",
                    "revenue_code": "revenue_code",
                    "prior_authorization_number": "prior_authorization_number",
                    "external_id": "external_id"
                  },
                  {
                    "modifiers": [
                      "AV",
                      "AV"
                    ],
                    "has_epsdt_indicator": true,
                    "has_family_planning_indicator": true,
                    "procedure_code": "procedure_code",
                    "quantity": "quantity",
                    "units": "MJ",
                    "charge_amount_cents": 1,
                    "diagnosis_pointers": [
                      1,
                      1
                    ],
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
                    "place_of_service_code": "01",
                    "description": "description",
                    "date_of_service": "2023-01-15",
                    "end_date_of_service": "2023-01-15",
                    "ordering_provider": {
                      "npi": "npi",
                      "taxonomy_code": "taxonomy_code",
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
                      "organization_name": "organization_name"
                    },
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
                    "note": "note",
                    "revenue_code": "revenue_code",
                    "prior_authorization_number": "prior_authorization_number",
                    "external_id": "external_id"
                  }
                ],
                "patient_histories": [
                  {
                    "category": "present_illness",
                    "questions": [
                      {
                        "id": "id",
                        "text": "text",
                        "responses": [
                          {},
                          {}
                        ]
                      },
                      {
                        "id": "id",
                        "text": "text",
                        "responses": [
                          {},
                          {}
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
                          {},
                          {}
                        ]
                      },
                      {
                        "id": "id",
                        "text": "text",
                        "responses": [
                          {},
                          {}
                        ]
                      }
                    ]
                  }
                ],
                "billing_notes": [
                  {
                    "text": "text"
                  },
                  {
                    "text": "text"
                  }
                ],
                "patient": {
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "gender": "male",
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
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "non_insurance_payers_info": [
                    {
                      "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "member_id": "member_id",
                      "clinical_trial_info": [
                        {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                        },
                        {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                        }
                      ]
                    },
                    {
                      "non_insurance_payer_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                      "member_id": "member_id",
                      "clinical_trial_info": [
                        {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                        },
                        {
                          "clinical_trial_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                        }
                      ]
                    }
                  ]
                },
                "service_facility": {
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
                "rendering_provider": {
                  "npi": "npi",
                  "taxonomy_code": "taxonomy_code",
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "secondary_identification": {
                    "reference_identification": "reference_identification",
                    "reference_identification_qualifier": "0B"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "organization_name": "organization_name"
                },
                "initial_referring_provider": {
                  "npi": "npi",
                  "taxonomy_code": "taxonomy_code",
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "qualifier": "DQ",
                  "secondary_identification": {
                    "reference_identification": "reference_identification",
                    "reference_identification_qualifier": "0B"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "organization_name": "organization_name"
                },
                "referring_provider": {
                  "npi": "npi",
                  "taxonomy_code": "taxonomy_code",
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "secondary_identification": {
                    "reference_identification": "reference_identification",
                    "reference_identification_qualifier": "0B"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "organization_name": "organization_name"
                },
                "supervising_provider": {
                  "npi": "npi",
                  "taxonomy_code": "taxonomy_code",
                  "address": {
                    "zip_plus_four_code": "zip_plus_four_code",
                    "address1": "address1",
                    "address2": "address2",
                    "city": "city",
                    "state": "AA",
                    "zip_code": "zip_code"
                  },
                  "secondary_identification": {
                    "reference_identification": "reference_identification",
                    "reference_identification_qualifier": "0B"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "organization_name": "organization_name"
                },
                "billing_provider": {
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
                  "provider_commercial_license_type": "0",
                  "secondary_identification": {
                    "reference_identification": "reference_identification",
                    "reference_identification_qualifier": "G2"
                  },
                  "first_name": "first_name",
                  "last_name": "last_name",
                  "organization_name": "organization_name"
                },
                "pay_to_address": {
                  "zip_plus_four_code": "zip_plus_four_code",
                  "address1": "address1",
                  "address2": "address2",
                  "city": "city",
                  "state": "AA",
                  "zip_code": "zip_code"
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
                "benefits_assigned_to_provider": true,
                "prior_authorization_number": "prior_authorization_number",
                "external_id": "external_id",
                "date_of_service": "2023-01-15",
                "tag_ids": [
                  "tag_ids",
                  "tag_ids"
                ],
                "billable_status": "BILLABLE",
                "responsible_party": "INSURANCE_PAY",
                "provider_accepts_assignment": true,
                "synchronicity": "Synchronous",
                "place_of_service_code": "01",
                "appointment_type": "appointment_type",
                "end_date_of_service": "2023-01-15",
                "additional_information": "additional_information",
                "service_authorization_exception_code": "1",
                "admission_date": "2023-01-15",
                "discharge_date": "2023-01-15",
                "onset_of_current_illness_or_symptom_date": "2023-01-15",
                "last_menstrual_period_date": "2023-01-15",
                "delay_reason_code": "1",
                "patient_authorized_release": true,
                "referral_number": "referral_number",
                "secondary_payer_carrier_code": "secondary_payer_carrier_code"
              },
              "date_of_service": "2023-01-15",
              "patient_external_id": "patient_external_id",
              "charge_external_id": "charge_external_id",
              "ehr_source_url": "ehr_source_url",
              "originating_system": "originating_system",
              "claim_creation_category": "claim_creation_category",
              "error": {
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "charge_capture_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "message": "message",
                "resolved": true,
                "resolved_by": "resolved_by",
                "resolution_reason": "resolution_reason",
                "field_in_error": "field_in_error",
                "claim_creation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              },
              "updates": [
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "message": "message",
                  "resolved": true
                },
                {
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "message": "message",
                  "resolved": true
                }
              ],
              "claim_creation_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/api/charge_captures/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ChargeCapture.V1.UpdateAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ChargeCaptureUpdate()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
