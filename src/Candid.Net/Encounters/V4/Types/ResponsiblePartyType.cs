using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(ResponsiblePartyType.ResponsiblePartyTypeSerializer))]
[Serializable]
public readonly record struct ResponsiblePartyType : IStringEnum
{
    public static readonly ResponsiblePartyType InsurancePay = new(Values.InsurancePay);

    public static readonly ResponsiblePartyType SelfPay = new(Values.SelfPay);

    public static readonly ResponsiblePartyType Unknown = new(Values.Unknown);

    public ResponsiblePartyType(string value)
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
    public static ResponsiblePartyType FromCustom(string value)
    {
        return new ResponsiblePartyType(value);
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

    public static bool operator ==(ResponsiblePartyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ResponsiblePartyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ResponsiblePartyType value) => value.Value;

    public static explicit operator ResponsiblePartyType(string value) => new(value);

    internal class ResponsiblePartyTypeSerializer : JsonConverter<ResponsiblePartyType>
    {
        public override ResponsiblePartyType Read(
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
            return new ResponsiblePartyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ResponsiblePartyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ResponsiblePartyType ReadAsPropertyName(
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
            return new ResponsiblePartyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ResponsiblePartyType value,
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
        public const string InsurancePay = "INSURANCE_PAY";

        public const string SelfPay = "SELF_PAY";

        public const string Unknown = "UNKNOWN";
    }
}
