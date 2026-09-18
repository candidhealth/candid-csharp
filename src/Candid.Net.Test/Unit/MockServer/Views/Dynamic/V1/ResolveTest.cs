using global::Candid.Net.Test.Unit.MockServer;
using global::Candid.Net.Test.Utils;
using global::Candid.Net.Views.Dynamic.V1;
using NUnit.Framework;

namespace Candid.Net.Test.Unit.MockServer.Views.Dynamic.V1;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResolveTest : BaseMockServerTest
{
    [global::NUnit.Framework.Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "items": [
                {
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "patient_control_number": "patient_control_number",
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "claim_status": "biller_received",
                  "billing_provider_npi": "billing_provider_npi",
                  "billing_provider_name": "billing_provider_name",
                  "billing_provider_tin": "billing_provider_tin",
                  "rendering_provider_npi": "rendering_provider_npi",
                  "rendering_provider_name": "rendering_provider_name",
                  "rendering_provider_tin": "rendering_provider_tin",
                  "optional_rendering_provider_npi": "optional_rendering_provider_npi",
                  "optional_rendering_provider_name": "optional_rendering_provider_name",
                  "patient_first_name": "patient_first_name",
                  "patient_last_name": "patient_last_name",
                  "patient_external_id": "patient_external_id",
                  "patient_state": "AA",
                  "primary_payer_id": "primary_payer_id",
                  "primary_payer_name": "primary_payer_name",
                  "primary_payer_plan_group_name": "primary_payer_plan_group_name",
                  "primary_payer_plan_name": "primary_payer_plan_name",
                  "primary_group_number": "primary_group_number",
                  "secondary_payer_id": "secondary_payer_id",
                  "secondary_payer_name": "secondary_payer_name",
                  "secondary_payer_plan_group_name": "secondary_payer_plan_group_name",
                  "secondary_payer_plan_name": "secondary_payer_plan_name",
                  "secondary_group_number": "secondary_group_number",
                  "primary_member_id": "primary_member_id",
                  "sum_allowed_amount_cents": 1,
                  "sum_charge_amount_cents": 1,
                  "sum_paid_amount_cents": 1,
                  "primary_plan_type": "09",
                  "secondary_plan_type": "09",
                  "primary_insurance_paid_cents": 1,
                  "secondary_insurance_paid_cents": 1,
                  "tertiary_insurance_paid_cents": 1,
                  "sum_patient_responsibility_cents": 1,
                  "sum_insurance_balance_amount_cents": 1,
                  "sum_insurance_adjustment_amount_cents": 1,
                  "sum_patient_paid_amount_cents": 1,
                  "sum_patient_balance_amount_cents": 1,
                  "sum_total_balance_amount_cents": 1,
                  "sum_patient_write_off_amount_cents": 1,
                  "sum_non_insurance_paid_cents": 1,
                  "claim_balance_amount_cents": 1,
                  "procedure_codes": [
                    "procedure_codes"
                  ],
                  "procedure_modifiers": [
                    "AV"
                  ],
                  "carcs": [
                    "carcs"
                  ],
                  "rarcs": [
                    "rarcs"
                  ],
                  "denial_reasons": [
                    "Authorization Required",
                    "Authorization Required"
                  ],
                  "rejection_reason": "DUPLICATE_CLAIM",
                  "tag_ids": [
                    "tag_ids",
                    "tag_ids"
                  ],
                  "date_of_service": "2023-01-15",
                  "end_date_of_service": "2023-01-15",
                  "timely_filing_deadline": "2023-01-15",
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
                  "place_of_service_code": "01",
                  "service_line_place_of_service_codes": [
                    "01",
                    "01"
                  ],
                  "service_line_total_quantity": 1.1,
                  "diagnosis_codes": [
                    "diagnosis_codes"
                  ],
                  "encounter_external_id": "encounter_external_id",
                  "billable_status": "BILLABLE",
                  "responsible_party": "INSURANCE_PAY",
                  "work_queue_id": "work_queue_id",
                  "work_queue_name": "work_queue_name",
                  "work_queue_membership_activated_at": "2024-01-15T09:30:00.000Z",
                  "owner_of_next_action": "CANDID",
                  "has_active_job": true,
                  "task_category": "other",
                  "task_type": "CUSTOMER_DATA_REQUEST",
                  "active_snooze": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "created_by": "created_by",
                    "updated_by": "updated_by",
                    "snooze_reason": "Pending Appeal",
                    "comments": "comments",
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15"
                  },
                  "days_since_unsnoozed": 1,
                  "claim_updated_at": "2024-01-15T09:30:00.000Z",
                  "task_assignees": [
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "task_assignees_by_name": [
                    "task_assignees_by_name",
                    "task_assignees_by_name"
                  ],
                  "task_description": "task_description",
                  "next_responsible_party": "primary",
                  "non_insurance_payer_categories": [
                    "non_insurance_payer_categories",
                    "non_insurance_payer_categories"
                  ],
                  "non_insurance_payer_names": [
                    "non_insurance_payer_names",
                    "non_insurance_payer_names"
                  ],
                  "clinical_trial_phases": [
                    "Phase 1"
                  ],
                  "submission_expectation": "TARGET_PROFESSIONAL",
                  "type_of_bill": {
                    "code": "code",
                    "type_of_facility": "1",
                    "type_of_care": "1",
                    "frequency_code": "0"
                  },
                  "attending_provider_npi": "attending_provider_npi",
                  "attending_provider_name": "attending_provider_name",
                  "revenue_codes": [
                    "revenue_codes",
                    "revenue_codes"
                  ],
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                },
                {
                  "encounter_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "patient_control_number": "patient_control_number",
                  "claim_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                  "claim_status": "biller_received",
                  "billing_provider_npi": "billing_provider_npi",
                  "billing_provider_name": "billing_provider_name",
                  "billing_provider_tin": "billing_provider_tin",
                  "rendering_provider_npi": "rendering_provider_npi",
                  "rendering_provider_name": "rendering_provider_name",
                  "rendering_provider_tin": "rendering_provider_tin",
                  "optional_rendering_provider_npi": "optional_rendering_provider_npi",
                  "optional_rendering_provider_name": "optional_rendering_provider_name",
                  "patient_first_name": "patient_first_name",
                  "patient_last_name": "patient_last_name",
                  "patient_external_id": "patient_external_id",
                  "patient_state": "AA",
                  "primary_payer_id": "primary_payer_id",
                  "primary_payer_name": "primary_payer_name",
                  "primary_payer_plan_group_name": "primary_payer_plan_group_name",
                  "primary_payer_plan_name": "primary_payer_plan_name",
                  "primary_group_number": "primary_group_number",
                  "secondary_payer_id": "secondary_payer_id",
                  "secondary_payer_name": "secondary_payer_name",
                  "secondary_payer_plan_group_name": "secondary_payer_plan_group_name",
                  "secondary_payer_plan_name": "secondary_payer_plan_name",
                  "secondary_group_number": "secondary_group_number",
                  "primary_member_id": "primary_member_id",
                  "sum_allowed_amount_cents": 1,
                  "sum_charge_amount_cents": 1,
                  "sum_paid_amount_cents": 1,
                  "primary_plan_type": "09",
                  "secondary_plan_type": "09",
                  "primary_insurance_paid_cents": 1,
                  "secondary_insurance_paid_cents": 1,
                  "tertiary_insurance_paid_cents": 1,
                  "sum_patient_responsibility_cents": 1,
                  "sum_insurance_balance_amount_cents": 1,
                  "sum_insurance_adjustment_amount_cents": 1,
                  "sum_patient_paid_amount_cents": 1,
                  "sum_patient_balance_amount_cents": 1,
                  "sum_total_balance_amount_cents": 1,
                  "sum_patient_write_off_amount_cents": 1,
                  "sum_non_insurance_paid_cents": 1,
                  "claim_balance_amount_cents": 1,
                  "procedure_codes": [
                    "procedure_codes"
                  ],
                  "procedure_modifiers": [
                    "AV"
                  ],
                  "carcs": [
                    "carcs"
                  ],
                  "rarcs": [
                    "rarcs"
                  ],
                  "denial_reasons": [
                    "Authorization Required",
                    "Authorization Required"
                  ],
                  "rejection_reason": "DUPLICATE_CLAIM",
                  "tag_ids": [
                    "tag_ids",
                    "tag_ids"
                  ],
                  "date_of_service": "2023-01-15",
                  "end_date_of_service": "2023-01-15",
                  "timely_filing_deadline": "2023-01-15",
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
                  "place_of_service_code": "01",
                  "service_line_place_of_service_codes": [
                    "01",
                    "01"
                  ],
                  "service_line_total_quantity": 1.1,
                  "diagnosis_codes": [
                    "diagnosis_codes"
                  ],
                  "encounter_external_id": "encounter_external_id",
                  "billable_status": "BILLABLE",
                  "responsible_party": "INSURANCE_PAY",
                  "work_queue_id": "work_queue_id",
                  "work_queue_name": "work_queue_name",
                  "work_queue_membership_activated_at": "2024-01-15T09:30:00.000Z",
                  "owner_of_next_action": "CANDID",
                  "has_active_job": true,
                  "task_category": "other",
                  "task_type": "CUSTOMER_DATA_REQUEST",
                  "active_snooze": {
                    "id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "created_by": "created_by",
                    "updated_by": "updated_by",
                    "snooze_reason": "Pending Appeal",
                    "comments": "comments",
                    "start_date": "2023-01-15",
                    "end_date": "2023-01-15"
                  },
                  "days_since_unsnoozed": 1,
                  "claim_updated_at": "2024-01-15T09:30:00.000Z",
                  "task_assignees": [
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                  ],
                  "task_assignees_by_name": [
                    "task_assignees_by_name",
                    "task_assignees_by_name"
                  ],
                  "task_description": "task_description",
                  "next_responsible_party": "primary",
                  "non_insurance_payer_categories": [
                    "non_insurance_payer_categories",
                    "non_insurance_payer_categories"
                  ],
                  "non_insurance_payer_names": [
                    "non_insurance_payer_names",
                    "non_insurance_payer_names"
                  ],
                  "clinical_trial_phases": [
                    "Phase 1"
                  ],
                  "submission_expectation": "TARGET_PROFESSIONAL",
                  "type_of_bill": {
                    "code": "code",
                    "type_of_facility": "1",
                    "type_of_care": "1",
                    "frequency_code": "0"
                  },
                  "attending_provider_npi": "attending_provider_npi",
                  "attending_provider_name": "attending_provider_name",
                  "revenue_codes": [
                    "revenue_codes",
                    "revenue_codes"
                  ],
                  "organization_id": "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
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
                        "/api/claim-dynamic-views/v1/d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32/resolve"
                    )
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Views.Dynamic.V1.ResolveAsync(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new ResolveDynamicView()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
