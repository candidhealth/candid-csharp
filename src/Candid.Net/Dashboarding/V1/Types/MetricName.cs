using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Dashboarding.V1;

[JsonConverter(typeof(MetricName.MetricNameSerializer))]
[Serializable]
public readonly record struct MetricName : IStringEnum
{
    public static readonly MetricName PatientTotalBalanceV1 = new(Values.PatientTotalBalanceV1);

    public static readonly MetricName PatientOldestBalanceDaysV1 = new(
        Values.PatientOldestBalanceDaysV1
    );

    public static readonly MetricName PatientOutstandingBalanceCountV1 = new(
        Values.PatientOutstandingBalanceCountV1
    );

    public static readonly MetricName PreAdjudicationClaimsCountV1 = new(
        Values.PreAdjudicationClaimsCountV1
    );

    public static readonly MetricName PreAdjudicationTotalAmountV1 = new(
        Values.PreAdjudicationTotalAmountV1
    );

    public static readonly MetricName PreAdjudicationOldestAgeDaysV1 = new(
        Values.PreAdjudicationOldestAgeDaysV1
    );

    public static readonly MetricName PostAdjudicationClaimsCountV1 = new(
        Values.PostAdjudicationClaimsCountV1
    );

    public static readonly MetricName PostAdjudicationTotalAmountV1 = new(
        Values.PostAdjudicationTotalAmountV1
    );

    public static readonly MetricName PostAdjudicationOldestAgeDaysV1 = new(
        Values.PostAdjudicationOldestAgeDaysV1
    );

    public static readonly MetricName PaymentPostingClaimsCountV1 = new(
        Values.PaymentPostingClaimsCountV1
    );

    public static readonly MetricName PaymentPostingTotalAmountV1 = new(
        Values.PaymentPostingTotalAmountV1
    );

    public static readonly MetricName PaymentPostingOldestAgeDaysV1 = new(
        Values.PaymentPostingOldestAgeDaysV1
    );

    public static readonly MetricName KpiDenialRateV1 = new(Values.KpiDenialRateV1);

    public static readonly MetricName KpiFirstPassResolutionRateV1 = new(
        Values.KpiFirstPassResolutionRateV1
    );

    public static readonly MetricName KpiDaysInArV1 = new(Values.KpiDaysInArV1);

    public static readonly MetricName KpiArOver90DaysRateV1 = new(Values.KpiArOver90DaysRateV1);

    public static readonly MetricName KpiNetCollectionRateV1 = new(Values.KpiNetCollectionRateV1);

    public MetricName(string value)
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
    public static MetricName FromCustom(string value)
    {
        return new MetricName(value);
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

    public static bool operator ==(MetricName value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(MetricName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MetricName value) => value.Value;

    public static explicit operator MetricName(string value) => new(value);

    internal class MetricNameSerializer : JsonConverter<MetricName>
    {
        public override MetricName Read(
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
            return new MetricName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MetricName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MetricName ReadAsPropertyName(
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
            return new MetricName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MetricName value,
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
        public const string PatientTotalBalanceV1 = "patient_total_balance_v1";

        public const string PatientOldestBalanceDaysV1 = "patient_oldest_balance_days_v1";

        public const string PatientOutstandingBalanceCountV1 =
            "patient_outstanding_balance_count_v1";

        public const string PreAdjudicationClaimsCountV1 = "pre_adjudication_claims_count_v1";

        public const string PreAdjudicationTotalAmountV1 = "pre_adjudication_total_amount_v1";

        public const string PreAdjudicationOldestAgeDaysV1 = "pre_adjudication_oldest_age_days_v1";

        public const string PostAdjudicationClaimsCountV1 = "post_adjudication_claims_count_v1";

        public const string PostAdjudicationTotalAmountV1 = "post_adjudication_total_amount_v1";

        public const string PostAdjudicationOldestAgeDaysV1 =
            "post_adjudication_oldest_age_days_v1";

        public const string PaymentPostingClaimsCountV1 = "payment_posting_claims_count_v1";

        public const string PaymentPostingTotalAmountV1 = "payment_posting_total_amount_v1";

        public const string PaymentPostingOldestAgeDaysV1 = "payment_posting_oldest_age_days_v1";

        public const string KpiDenialRateV1 = "kpi_denial_rate_v1";

        public const string KpiFirstPassResolutionRateV1 = "kpi_first_pass_resolution_rate_v1";

        public const string KpiDaysInArV1 = "kpi_days_in_ar_v1";

        public const string KpiArOver90DaysRateV1 = "kpi_ar_over_90_days_rate_v1";

        public const string KpiNetCollectionRateV1 = "kpi_net_collection_rate_v1";
    }
}
