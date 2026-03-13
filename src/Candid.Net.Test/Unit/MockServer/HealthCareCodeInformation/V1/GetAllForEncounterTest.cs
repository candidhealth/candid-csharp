using Candid.Net.Test.Unit.MockServer;
using Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.HealthCareCodeInformation.V1;

[TestFixture]
public class GetAllForEncounterTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "principal_diagnosis": {
                "principal_diagnosis_code_qualifier": "BK",
                "primary_diagnosis_code": "primary_diagnosis_code",
                "present_on_admission_indicator": "Y",
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              },
              "other_diagnosis_information": [
                {
                  "other_diagnosis_code_qualifier": "BF",
                  "other_diagnosis": "other_diagnosis",
                  "present_on_admission_indicator": "Y",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "other_diagnosis_code_qualifier": "BF",
                  "other_diagnosis": "other_diagnosis",
                  "present_on_admission_indicator": "Y",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "admitting_diagnosis": {
                "admitting_diagnosis_code_qualifier": "BJ",
                "admitting_diagnosis_code": "admitting_diagnosis_code",
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              },
              "patient_reasons_for_visit": [
                {
                  "patient_reason_for_visit_code_qualifier": "PR",
                  "patient_reason_for_visit": "patient_reason_for_visit",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "patient_reason_for_visit_code_qualifier": "PR",
                  "patient_reason_for_visit": "patient_reason_for_visit",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "external_causes_of_injury": [
                {
                  "external_cause_of_injury_code_qualifier": "BN",
                  "external_cause_of_injury_code": "external_cause_of_injury_code",
                  "present_on_admission_indicator": "Y",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "external_cause_of_injury_code_qualifier": "BN",
                  "external_cause_of_injury_code": "external_cause_of_injury_code",
                  "present_on_admission_indicator": "Y",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "diagnosis_related_groups": {
                "diagnosis_related_group_code_qualifier": "DR",
                "diagnosis_related_group_code": "diagnosis_related_group_code",
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              },
              "principal_procedure": {
                "principal_procedure_code_qualifier": "BBR",
                "principal_procedure_code": "principal_procedure_code",
                "procedure_date": "2023-01-15",
                "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
              },
              "other_procedure_information": [
                {
                  "other_procedure_code_qualifier": "BBQ",
                  "other_procedure_code": "other_procedure_code",
                  "other_procedure_date": "2023-01-15",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "other_procedure_code_qualifier": "BBQ",
                  "other_procedure_code": "other_procedure_code",
                  "other_procedure_date": "2023-01-15",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "occurrence_span_information": [
                {
                  "occurrence_span_code_qualifier": "BI",
                  "occurrence_span_code": "70",
                  "occurrence_span_date": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "occurrence_span_code_qualifier": "BI",
                  "occurrence_span_code": "70",
                  "occurrence_span_date": {
                    "start": "2023-01-15",
                    "end": "2023-01-15"
                  },
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "occurrence_information": [
                {
                  "occurrence_code_qualifier": "BH",
                  "occurrence_code": "01",
                  "occurrence_date": "2023-01-15",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "occurrence_code_qualifier": "BH",
                  "occurrence_code": "01",
                  "occurrence_date": "2023-01-15",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "treatment_code_information": [
                {
                  "treatment_code_qualifier": "TC",
                  "treatment_code": "treatment_code",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "treatment_code_qualifier": "TC",
                  "treatment_code": "treatment_code",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "value_information": [
                {
                  "value_code_qualifier": "BE",
                  "value_code": "01",
                  "value_code_amount": "value_code_amount",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "value_code_qualifier": "BE",
                  "value_code": "01",
                  "value_code_amount": "value_code_amount",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ],
              "condition_information": [
                {
                  "condition_code_qualifier": "BG",
                  "condition_code": "01",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "condition_code_qualifier": "BG",
                  "condition_code": "01",
                  "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/api/health-care-code-informations/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HealthCareCodeInformation.V1.GetAllForEncounterAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
