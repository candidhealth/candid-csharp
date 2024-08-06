using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.Encounters.V4;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class EncounterTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""encounter_id"": ""B2506E84-4470-4CBA-8A68-6883367739E1"",
  ""claims"": [
    {
      ""claim_id"": ""DD9D7F82-37B5-449D-AA63-26925398335B"",
      ""status"": ""biller_received"",
      ""clearinghouse"": ""Change Healthcare"",
      ""clearinghouse_claim_id"": ""5BA7C3AB-2BC2-496C-8B10-6CAC73D0729D"",
      ""payer_claim_id"": ""9BB9F259-9756-4F16-8F53-9DBB9F7EB1BB"",
      ""service_lines"": [
        {
          ""modifiers"": [
            ""22""
          ],
          ""charge_amount_cents"": 10000,
          ""allowed_amount_cents"": 8000,
          ""insurance_balance_cents"": 0,
          ""patient_balance_cents"": 2000,
          ""paid_amount_cents"": 8000,
          ""patient_responsibility_cents"": 2000,
          ""diagnosis_id_zero"": ""4AC84BCD-12F5-4F86-A57B-E06749127C98"",
          ""diagnosis_id_one"": ""EEA5CA5A-8B43-45FD-8CBD-C6CC1103E759"",
          ""diagnosis_id_two"": ""5C4AA029-2DB9-4202-916E-E93C708F65FF"",
          ""diagnosis_id_three"": ""81795126-A3AC-443C-B47E-7259A16AB4A2"",
          ""service_line_era_data"": {
            ""service_line_adjustments"": [
              {
                ""created_at"": ""2023-01-01T00:00:00Z"",
                ""adjustment_group_code"": ""CO"",
                ""adjustment_reason_code"": ""CO"",
                ""adjustment_amount_cents"": 1000,
                ""adjustment_note"": ""test_note""
              }
            ],
            ""remittance_advice_remark_codes"": [
              ""N362""
            ]
          },
          ""service_line_manual_adjustments"": [
            {
              ""created_at"": ""2023-01-01T00:00:00Z"",
              ""adjustment_group_code"": ""CO"",
              ""adjustment_reason_code"": ""CO"",
              ""adjustment_amount_cents"": 1000,
              ""adjustment_note"": ""test_note""
            }
          ],
          ""related_invoices"": [
            {
              ""id"": ""901BE2F1-41BC-456E-9987-4FE2F84F9D75"",
              ""created_at"": ""2023-01-01T00:00:00Z"",
              ""updated_at"": ""2023-01-01T00:00:00Z"",
              ""organzation_id"": ""F13F73D4-4344-46EA-9D93-33BCFFBB9F36"",
              ""source_id"": ""9B626577-8808-4F28-9ED1-F0DFF0D49BBC"",
              ""source_customer_id"": ""624D1972-8C69-4C2F-AEFA-10856F734DB3"",
              ""patient_external_id"": ""10FED4D6-4C5A-48DF-838A-EEF45A74788D"",
              ""note"": ""test_note"",
              ""due_date"": ""2023-10-10"",
              ""status"": ""draft"",
              ""url"": ""https://example.com"",
              ""customer_invoice_url"": ""https://example.com"",
              ""items"": [
                {
                  ""service_line_id"": ""CED00F23-6E68-4678-9DBC-F5AA2969A565"",
                  ""amount_cents"": 500
                }
              ]
            }
          ],
          ""denial_reason"": {
            ""reason"": ""Authorization Required""
          },
          ""place_of_service_code"": ""01"",
          ""service_line_id"": ""CED00F23-6E68-4678-9DBC-F5AA2969A565"",
          ""procedure_code"": ""99213"",
          ""quantity"": ""1"",
          ""units"": ""MJ"",
          ""claim_id"": ""026A1FB8-748E-4859-A2D7-3EA9E07D25AE"",
          ""date_of_service_range"": {
            ""start_date"": ""2023-01-01"",
            ""end_date"": ""2023-01-03""
          },
          ""date_of_service"": ""2023-01-01"",
          ""end_date_of_service"": ""2023-01-03""
        }
      ],
      ""eras"": [
        {
          ""era_id"": ""4D844EF1-2253-43CD-A4F1-6DB7E65CB54B"",
          ""check_number"": ""CHK12345"",
          ""check_date"": ""2023-10-12""
        }
      ]
    }
  ],
  ""patient"": {
    ""individual_id"": ""93DDBEBF-4956-4482-9A6C-21499B7E4E5D"",
    ""phone_numbers"": [
      {
        ""number"": ""1234567890"",
        ""type"": ""Home""
      }
    ],
    ""phone_consent"": true,
    ""email"": ""johndoe@joincandidhealth.com"",
    ""email_consent"": true,
    ""external_id"": ""49460F77-6456-41F1-AC6D-0AED08614D39"",
    ""date_of_birth"": ""2000-01-01"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""gender"": ""male""
  },
  ""guarantor"": {
    ""guarantor_id"": ""8BBDBE63-58D3-4D40-98C9-40403C050977"",
    ""phone_numbers"": [
      {
        ""number"": ""1234567890"",
        ""type"": ""Home""
      }
    ],
    ""phone_consent"": true,
    ""email"": ""johndoe@joincandidhealth.com"",
    ""email_consent"": true,
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""external_id"": ""49460F77-6456-41F1-AC6D-0AED08614D39"",
    ""date_of_birth"": ""2000-01-01"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    }
  },
  ""billing_provider"": {
    ""provider_id"": ""d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""tax_id"": ""123456789"",
    ""npi"": ""1234567890"",
    ""taxonomy_code"": ""207Q00000X"",
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""organization_name"": ""Organization Name""
  },
  ""rendering_provider"": {
    ""provider_id"": ""d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""tax_id"": ""123456789"",
    ""npi"": ""1234567890"",
    ""taxonomy_code"": ""207Q00000X"",
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""organization_name"": ""Organization Name""
  },
  ""referring_provider"": {
    ""provider_id"": ""d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""tax_id"": ""123456789"",
    ""npi"": ""1234567890"",
    ""taxonomy_code"": ""207Q00000X"",
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""organization_name"": ""Organization Name""
  },
  ""service_facility"": {
    ""service_facility_id"": ""2861487B-232C-4DED-A874-616A5DB0688F"",
    ""organization_name"": ""Test Organization"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    }
  },
  ""subscriber_primary"": {
    ""individual_id"": ""797348A9-E7E8-4E59-8628-95390D079C0B"",
    ""insurance_card"": {
      ""insurance_card_id"": ""CA5B7711-4419-4161-9B7C-3494AC40C8D4"",
      ""member_id"": ""E85313B4-0FFC-4119-8042-8161A4ECFF0A"",
      ""payer_name"": ""John Doe"",
      ""payer_id"": ""836DDAA6-863F-4020-ACCA-205A689F0002"",
      ""rx_bin"": ""610014"",
      ""rx_pcn"": ""MEDDPRIME"",
      ""image_url_front"": ""https://s3.amazonaws.com/front.jpg"",
      ""image_url_back"": ""https://s3.amazonaws.com/back.jpg"",
      ""group_number"": ""ABC12345"",
      ""plan_name"": ""Silver PPO Plan"",
      ""plan_type"": ""09"",
      ""insurance_type"": ""12""
    },
    ""patient_relationship_to_subscriber_code"": ""01"",
    ""date_of_birth"": ""2000-01-01"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""gender"": ""male""
  },
  ""subscriber_secondary"": {
    ""individual_id"": ""797348A9-E7E8-4E59-8628-95390D079C0B"",
    ""insurance_card"": {
      ""insurance_card_id"": ""CA5B7711-4419-4161-9B7C-3494AC40C8D4"",
      ""member_id"": ""E85313B4-0FFC-4119-8042-8161A4ECFF0A"",
      ""payer_name"": ""John Doe"",
      ""payer_id"": ""836DDAA6-863F-4020-ACCA-205A689F0002"",
      ""rx_bin"": ""610014"",
      ""rx_pcn"": ""MEDDPRIME"",
      ""image_url_front"": ""https://s3.amazonaws.com/front.jpg"",
      ""image_url_back"": ""https://s3.amazonaws.com/back.jpg"",
      ""group_number"": ""ABC12345"",
      ""plan_name"": ""Silver PPO Plan"",
      ""plan_type"": ""09"",
      ""insurance_type"": ""12""
    },
    ""patient_relationship_to_subscriber_code"": ""01"",
    ""date_of_birth"": ""2000-01-01"",
    ""address"": {
      ""address1"": ""123 Main St"",
      ""address2"": ""Apt 1"",
      ""city"": ""New York"",
      ""state"": ""NY"",
      ""zip_code"": ""10001"",
      ""zip_plus_four_code"": ""1234""
    },
    ""first_name"": ""John"",
    ""last_name"": ""Doe"",
    ""gender"": ""male""
  },
  ""url"": ""https://example.com"",
  ""diagnoses"": [
    {
      ""diagnosis_id"": ""5C770E00-4BBF-42AF-A73F-99C5E91FC0DB"",
      ""created_at"": ""2023-01-01T00:00:00Z"",
      ""updated_at"": ""2023-01-01T00:00:00Z"",
      ""encounter_id"": ""3F63985B-51A4-4DD4-9418-7D50B2520792"",
      ""name"": ""John Doe"",
      ""code_type"": ""ABF"",
      ""code"": ""I10""
    }
  ],
  ""clinical_notes"": [
    {
      ""category"": ""clinical"",
      ""notes"": [
        ""Patient complained of mild chest pain.""
      ],
      ""notes_structured"": [
        {
          ""text"": ""Mild chest pain since morning."",
          ""author_name"": ""John Doe"",
          ""author_npi"": ""1234567890"",
          ""timestamp"": ""2023-01-01T00:00:00Z""
        }
      ]
    }
  ],
  ""billing_notes"": [
    {
      ""billing_note_id"": ""99882EEA-936F-4E71-BC4F-520E4D14E3E2"",
      ""encounter_id"": ""8BCFB6A8-2876-4111-9E3F-602B541FCF62"",
      ""created_at"": ""2023-01-01T00:00:00Z"",
      ""author_auth0_id"": ""F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8"",
      ""author_name"": ""John Doe"",
      ""text"": ""Patient was billed for an MRI.""
    }
  ],
  ""place_of_service_code"": ""01"",
  ""place_of_service_code_as_submitted"": ""01"",
  ""patient_histories"": [
    {
      ""category"": ""present_illness"",
      ""questions"": [
        {
          ""id"": ""6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176"",
          ""text"": ""Do you have any allergies?"",
          ""responses"": [
            {
              ""response"": ""No allergies"",
              ""follow_ups"": [
                {
                  ""id"": ""4F3D57F9-AC94-49D6-87E4-E804B709917A"",
                  ""text"": ""Do you have any allergies?"",
                  ""response"": ""No allergies""
                }
              ]
            }
          ]
        }
      ]
    }
  ],
  ""patient_payments"": [
    {
      ""patient_payment_id"": ""CF237BE1-E793-4BBF-8958-61D5179D1D0D"",
      ""organization_id"": ""0788CA2A-B20D-4B8E-B8D4-07FA0B3B4907"",
      ""source_internal_id"": ""D1A76039-D5C5-4323-A2FC-B7C8B6AEF6A4"",
      ""source"": ""MANUAL_ENTRY"",
      ""amount_cents"": 2000,
      ""payment_timestamp"": ""2023-01-01T00:00:00Z"",
      ""status"": ""PENDING"",
      ""payment_name"": ""John Doe"",
      ""payment_note"": ""test payment note"",
      ""patient_external_id"": ""B7437260-D6B4-48CF-B9D7-753C09F34E76"",
      ""encounter_external_id"": ""0F26B9C3-199F-4CBB-A166-B87EA7C631BB"",
      ""service_line_id"": ""B557DC86-C629-478C-850A-02D45AC11783""
    }
  ],
  ""tags"": [
    {
      ""creator_id"": ""00EB5A46-35C6-441B-9751-AF307AEF5888"",
      ""tag_id"": ""void-claim-submitted"",
      ""description"": ""to indicate claims where a void claim has been submitted"",
      ""color"": ""black""
    }
  ],
  ""coding_attribution"": ""CANDID"",
  ""work_queue_id"": ""000856FE-1024-418F-BF96-2E7347AB4520"",
  ""work_queue_membership_activated_at"": ""2023-01-01T00:00:00Z"",
  ""owner_of_next_action"": ""CANDID"",
  ""submission_origin"": ""CANDID"",
  ""external_id"": ""5C21490F-A9C0-45F4-B5DB-136E3AEC617A"",
  ""date_of_service"": ""2023-01-01"",
  ""end_date_of_service"": ""2023-01-05"",
  ""prior_authorization_number"": ""PA1234567"",
  ""patient_authorized_release"": true,
  ""benefits_assigned_to_provider"": true,
  ""provider_accepts_assignment"": true,
  ""appointment_type"": ""Routine Checkup"",
  ""existing_medications"": [
    {
      ""name"": ""Lisinopril"",
      ""rx_cui"": ""860975"",
      ""dosage"": ""10mg"",
      ""dosage_form"": ""Tablet"",
      ""frequency"": ""Once Daily"",
      ""as_needed"": true
    }
  ],
  ""vitals"": {
    ""height_in"": 70,
    ""weight_lbs"": 165,
    ""blood_pressure_systolic_mmhg"": 115,
    ""blood_pressure_diastolic_mmhg"": 85,
    ""body_temperature_f"": 98
  },
  ""interventions"": [
    {
      ""name"": ""Physical Therapy Session"",
      ""category"": ""lifestyle"",
      ""description"": ""A session focused on improving muscular strength, flexibility, and range of motion post-injury."",
      ""medication"": {
        ""name"": ""Lisinopril"",
        ""rx_cui"": ""860975"",
        ""dosage"": ""10mg"",
        ""dosage_form"": ""Tablet"",
        ""frequency"": ""Once Daily"",
        ""as_needed"": true
      },
      ""labs"": [
        {
          ""name"": ""Genetic Health Labs"",
          ""code"": ""GH12345"",
          ""code_type"": ""quest""
        }
      ]
    }
  ],
  ""pay_to_address"": {
    ""address1"": ""123 Main St"",
    ""address2"": ""Apt 1"",
    ""city"": ""New York"",
    ""state"": ""NY"",
    ""zip_code"": ""10001"",
    ""zip_plus_four_code"": ""1234""
  },
  ""synchronicity"": ""Synchronous"",
  ""billable_status"": ""BILLABLE"",
  ""responsible_party"": ""INSURANCE_PAY"",
  ""service_authorization_exception_code"": ""1"",
  ""admission_date"": ""2023-01-01"",
  ""discharge_date"": ""2023-01-05"",
  ""onset_of_current_illness_or_symptom_date"": ""2023-01-01"",
  ""schema_instances"": [
    {
      ""schema_id"": ""ec096b13-f80a-471d-aaeb-54b021c9d582"",
      ""content"": {
        ""provider_category"": ""internist"",
        ""is_urgent_care"": true,
        ""bmi"": 24.2,
        ""age"": 38
      }
    }
  ]
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<Encounter>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
