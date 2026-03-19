using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(PatientTransactionSource.PatientTransactionSourceSerializer))]
[Serializable]
public readonly record struct PatientTransactionSource : IStringEnum
{
    public static readonly PatientTransactionSource ManualEntry = new(Values.ManualEntry);

    public static readonly PatientTransactionSource Chargebee = new(Values.Chargebee);

    public static readonly PatientTransactionSource Square = new(Values.Square);

    public static readonly PatientTransactionSource Stripe = new(Values.Stripe);

    public static readonly PatientTransactionSource Elation = new(Values.Elation);

    public static readonly PatientTransactionSource Cedar = new(Values.Cedar);

    public static readonly PatientTransactionSource Healthie = new(Values.Healthie);

    public static readonly PatientTransactionSource Reallocation = new(Values.Reallocation);

    public static readonly PatientTransactionSource Phreesia = new(Values.Phreesia);

    public static readonly PatientTransactionSource Instamed = new(Values.Instamed);

    public PatientTransactionSource(string value)
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
    public static PatientTransactionSource FromCustom(string value)
    {
        return new PatientTransactionSource(value);
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

    public static bool operator ==(PatientTransactionSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientTransactionSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientTransactionSource value) => value.Value;

    public static explicit operator PatientTransactionSource(string value) => new(value);

    internal class PatientTransactionSourceSerializer : JsonConverter<PatientTransactionSource>
    {
        public override PatientTransactionSource Read(
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
            return new PatientTransactionSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatientTransactionSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatientTransactionSource ReadAsPropertyName(
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
            return new PatientTransactionSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatientTransactionSource value,
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
        public const string ManualEntry = "MANUAL_ENTRY";

        public const string Chargebee = "CHARGEBEE";

        public const string Square = "SQUARE";

        public const string Stripe = "STRIPE";

        public const string Elation = "ELATION";

        public const string Cedar = "CEDAR";

        public const string Healthie = "HEALTHIE";

        public const string Reallocation = "REALLOCATION";

        public const string Phreesia = "PHREESIA";

        public const string Instamed = "INSTAMED";
    }
}
