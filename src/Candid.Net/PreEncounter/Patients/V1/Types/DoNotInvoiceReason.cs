using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(DoNotInvoiceReason.DoNotInvoiceReasonSerializer))]
[Serializable]
public readonly record struct DoNotInvoiceReason : IStringEnum
{
    public static readonly DoNotInvoiceReason Bankruptcy = new(Values.Bankruptcy);

    public static readonly DoNotInvoiceReason Deceased = new(Values.Deceased);

    public static readonly DoNotInvoiceReason Hardship = new(Values.Hardship);

    public static readonly DoNotInvoiceReason Other = new(Values.Other);

    public static readonly DoNotInvoiceReason Collections = new(Values.Collections);

    public static readonly DoNotInvoiceReason BadAddress = new(Values.BadAddress);

    public static readonly DoNotInvoiceReason ProfessionalCourtesy = new(
        Values.ProfessionalCourtesy
    );

    public DoNotInvoiceReason(string value)
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
    public static DoNotInvoiceReason FromCustom(string value)
    {
        return new DoNotInvoiceReason(value);
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

    public static bool operator ==(DoNotInvoiceReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DoNotInvoiceReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DoNotInvoiceReason value) => value.Value;

    public static explicit operator DoNotInvoiceReason(string value) => new(value);

    internal class DoNotInvoiceReasonSerializer : JsonConverter<DoNotInvoiceReason>
    {
        public override DoNotInvoiceReason Read(
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
            return new DoNotInvoiceReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DoNotInvoiceReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DoNotInvoiceReason ReadAsPropertyName(
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
            return new DoNotInvoiceReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DoNotInvoiceReason value,
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
        public const string Bankruptcy = "BANKRUPTCY";

        public const string Deceased = "DECEASED";

        public const string Hardship = "HARDSHIP";

        public const string Other = "OTHER";

        public const string Collections = "COLLECTIONS";

        public const string BadAddress = "BAD_ADDRESS";

        public const string ProfessionalCourtesy = "PROFESSIONAL_COURTESY";
    }
}
