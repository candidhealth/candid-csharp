using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterSummaries.V1;

[JsonConverter(typeof(EncounterSortableFields.EncounterSortableFieldsSerializer))]
[Serializable]
public readonly record struct EncounterSortableFields : IStringEnum
{
    public static readonly EncounterSortableFields CreatedAt = new(Values.CreatedAt);

    public static readonly EncounterSortableFields DateOfService = new(Values.DateOfService);

    public static readonly EncounterSortableFields PayerName = new(Values.PayerName);

    public static readonly EncounterSortableFields PayerId = new(Values.PayerId);

    public static readonly EncounterSortableFields SecondaryPayerName = new(
        Values.SecondaryPayerName
    );

    public static readonly EncounterSortableFields SecondaryPayerId = new(Values.SecondaryPayerId);

    public static readonly EncounterSortableFields ClaimStatus = new(Values.ClaimStatus);

    public static readonly EncounterSortableFields PatientName = new(Values.PatientName);

    public static readonly EncounterSortableFields BillingProviderTaxId = new(
        Values.BillingProviderTaxId
    );

    public static readonly EncounterSortableFields BillingProviderNpi = new(
        Values.BillingProviderNpi
    );

    public static readonly EncounterSortableFields RenderingProviderNpi = new(
        Values.RenderingProviderNpi
    );

    public static readonly EncounterSortableFields RenderingProviderName = new(
        Values.RenderingProviderName
    );

    public static readonly EncounterSortableFields WorkQueueMembershipActivatedAt = new(
        Values.WorkQueueMembershipActivatedAt
    );

    public static readonly EncounterSortableFields SnoozeEndDate = new(Values.SnoozeEndDate);

    public static readonly EncounterSortableFields Carcs = new(Values.Carcs);

    public static readonly EncounterSortableFields ClaimUpdatedAt = new(Values.ClaimUpdatedAt);

    public static readonly EncounterSortableFields TaskCategory = new(Values.TaskCategory);

    public static readonly EncounterSortableFields TaskType = new(Values.TaskType);

    public static readonly EncounterSortableFields DiagnosisCodes = new(Values.DiagnosisCodes);

    public static readonly EncounterSortableFields PatientState = new(Values.PatientState);

    public static readonly EncounterSortableFields PrimaryPlanType = new(Values.PrimaryPlanType);

    public static readonly EncounterSortableFields SecondaryPlanType = new(
        Values.SecondaryPlanType
    );

    public static readonly EncounterSortableFields PrimaryMemberId = new(Values.PrimaryMemberId);

    public static readonly EncounterSortableFields PlaceOfServiceCode = new(
        Values.PlaceOfServiceCode
    );

    public static readonly EncounterSortableFields ServiceLinePlaceOfServiceCodes = new(
        Values.ServiceLinePlaceOfServiceCodes
    );

    public static readonly EncounterSortableFields RejectionReason = new(Values.RejectionReason);

    public static readonly EncounterSortableFields TaskAssignee = new(Values.TaskAssignee);

    public static readonly EncounterSortableFields ServiceLineCptCodes = new(
        Values.ServiceLineCptCodes
    );

    public static readonly EncounterSortableFields ClaimBalance = new(Values.ClaimBalance);

    public static readonly EncounterSortableFields PrimaryPayerPlanGroupName = new(
        Values.PrimaryPayerPlanGroupName
    );

    public static readonly EncounterSortableFields SecondaryPayerPlanGroupName = new(
        Values.SecondaryPayerPlanGroupName
    );

    public static readonly EncounterSortableFields SumChargeAmountCents = new(
        Values.SumChargeAmountCents
    );

    public static readonly EncounterSortableFields PrimaryPayerPlanName = new(
        Values.PrimaryPayerPlanName
    );

    public static readonly EncounterSortableFields SecondaryPayerPlanName = new(
        Values.SecondaryPayerPlanName
    );

    public static readonly EncounterSortableFields DaysSinceUnsnoozed = new(
        Values.DaysSinceUnsnoozed
    );

    public static readonly EncounterSortableFields AttendingProviderNpi = new(
        Values.AttendingProviderNpi
    );

    public static readonly EncounterSortableFields AttendingProviderName = new(
        Values.AttendingProviderName
    );

    public static readonly EncounterSortableFields NonInsurancePayerNames = new(
        Values.NonInsurancePayerNames
    );

    public static readonly EncounterSortableFields TimelyFilingDeadline = new(
        Values.TimelyFilingDeadline
    );

    public EncounterSortableFields(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static EncounterSortableFields FromCustom(string value)
    {
        return new EncounterSortableFields(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(EncounterSortableFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterSortableFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterSortableFields value) => value.Value;

    public static explicit operator EncounterSortableFields(string value) => new(value);

    internal class EncounterSortableFieldsSerializer : JsonConverter<EncounterSortableFields>
    {
        public override EncounterSortableFields Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new EncounterSortableFields(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EncounterSortableFields value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EncounterSortableFields ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new EncounterSortableFields(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EncounterSortableFields value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAt = "created_at";

        public const string DateOfService = "date_of_service";

        public const string PayerName = "payer_name";

        public const string PayerId = "payer_id";

        public const string SecondaryPayerName = "secondary_payer_name";

        public const string SecondaryPayerId = "secondary_payer_id";

        public const string ClaimStatus = "status";

        public const string PatientName = "patient_name";

        public const string BillingProviderTaxId = "billing_provider_tax_id";

        public const string BillingProviderNpi = "billing_provider_npi";

        public const string RenderingProviderNpi = "rendering_provider_npi";

        public const string RenderingProviderName = "rendering_provider_name";

        public const string WorkQueueMembershipActivatedAt = "work_queue_membership_activated_at";

        public const string SnoozeEndDate = "snooze_end_date";

        public const string Carcs = "carcs";

        public const string ClaimUpdatedAt = "claim_updated_at";

        public const string TaskCategory = "task_category";

        public const string TaskType = "task_type";

        public const string DiagnosisCodes = "diagnosis_codes";

        public const string PatientState = "patient_state";

        public const string PrimaryPlanType = "primary_plan_type";

        public const string SecondaryPlanType = "secondary_plan_type";

        public const string PrimaryMemberId = "primary_member_id";

        public const string PlaceOfServiceCode = "place_of_service_code";

        public const string ServiceLinePlaceOfServiceCodes = "service_line_place_of_service_codes";

        public const string RejectionReason = "rejection_reason";

        public const string TaskAssignee = "task_assignee";

        public const string ServiceLineCptCodes = "service_line_cpt_codes";

        public const string ClaimBalance = "claim_balance";

        public const string PrimaryPayerPlanGroupName = "primary_payer_plan_group_name";

        public const string SecondaryPayerPlanGroupName = "secondary_payer_plan_group_name";

        public const string SumChargeAmountCents = "sum_charge_amount_cents";

        public const string PrimaryPayerPlanName = "primary_payer_plan_name";

        public const string SecondaryPayerPlanName = "secondary_payer_plan_name";

        public const string DaysSinceUnsnoozed = "days_since_unsnoozed";

        public const string AttendingProviderNpi = "attending_provider_npi";

        public const string AttendingProviderName = "attending_provider_name";

        public const string NonInsurancePayerNames = "non_insurance_payer_names";

        public const string TimelyFilingDeadline = "timely_filing_deadline";
    }
}
