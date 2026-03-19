using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

[JsonConverter(typeof(PatientArStatus.PatientArStatusSerializer))]
[Serializable]
public readonly record struct PatientArStatus : IStringEnum
{
    public static readonly PatientArStatus Invoiceable = new(Values.Invoiceable);

    public static readonly PatientArStatus NonInvoiceable = new(Values.NonInvoiceable);

    public PatientArStatus(string value)
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
    public static PatientArStatus FromCustom(string value)
    {
        return new PatientArStatus(value);
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

    public static bool operator ==(PatientArStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientArStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientArStatus value) => value.Value;

    public static explicit operator PatientArStatus(string value) => new(value);

    internal class PatientArStatusSerializer : JsonConverter<PatientArStatus>
    {
        public override PatientArStatus Read(
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
            return new PatientArStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatientArStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PatientArStatus ReadAsPropertyName(
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
            return new PatientArStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatientArStatus value,
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
        public const string Invoiceable = "invoiceable";

        public const string NonInvoiceable = "non_invoiceable";
    }
}
