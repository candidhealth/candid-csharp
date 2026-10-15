using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[JsonConverter(typeof(InsuranceAdjustmentSource.InsuranceAdjustmentSourceSerializer))]
[Serializable]
public readonly record struct InsuranceAdjustmentSource : IStringEnum
{
    public static readonly InsuranceAdjustmentSource Manual = new(Values.Manual);

    public static readonly InsuranceAdjustmentSource Era = new(Values.Era);

    public static readonly InsuranceAdjustmentSource EraRule = new(Values.EraRule);

    public static readonly InsuranceAdjustmentSource PaymentBundle = new(Values.PaymentBundle);

    public InsuranceAdjustmentSource(string value)
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
    public static InsuranceAdjustmentSource FromCustom(string value)
    {
        return new InsuranceAdjustmentSource(value);
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

    public static bool operator ==(InsuranceAdjustmentSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceAdjustmentSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceAdjustmentSource value) => value.Value;

    public static explicit operator InsuranceAdjustmentSource(string value) => new(value);

    internal class InsuranceAdjustmentSourceSerializer : JsonConverter<InsuranceAdjustmentSource>
    {
        public override InsuranceAdjustmentSource Read(
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
            return new InsuranceAdjustmentSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceAdjustmentSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InsuranceAdjustmentSource ReadAsPropertyName(
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
            return new InsuranceAdjustmentSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InsuranceAdjustmentSource value,
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
        public const string Manual = "MANUAL";

        public const string Era = "ERA";

        public const string EraRule = "ERA_RULE";

        public const string PaymentBundle = "PAYMENT_BUNDLE";
    }
}
