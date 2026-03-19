using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[JsonConverter(
    typeof(BillingProviderSecondaryIdentificationQualifier.BillingProviderSecondaryIdentificationQualifierSerializer)
)]
[Serializable]
public readonly record struct BillingProviderSecondaryIdentificationQualifier : IStringEnum
{
    /// <summary>
    /// Provider Commercial Number
    /// </summary>
    public static readonly BillingProviderSecondaryIdentificationQualifier G2 = new(Values.G2);

    /// <summary>
    /// Location Number
    /// </summary>
    public static readonly BillingProviderSecondaryIdentificationQualifier Lu = new(Values.Lu);

    public BillingProviderSecondaryIdentificationQualifier(string value)
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
    public static BillingProviderSecondaryIdentificationQualifier FromCustom(string value)
    {
        return new BillingProviderSecondaryIdentificationQualifier(value);
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

    public static bool operator ==(
        BillingProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BillingProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BillingProviderSecondaryIdentificationQualifier value) =>
        value.Value;

    public static explicit operator BillingProviderSecondaryIdentificationQualifier(string value) =>
        new(value);

    internal class BillingProviderSecondaryIdentificationQualifierSerializer
        : JsonConverter<BillingProviderSecondaryIdentificationQualifier>
    {
        public override BillingProviderSecondaryIdentificationQualifier Read(
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
            return new BillingProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BillingProviderSecondaryIdentificationQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BillingProviderSecondaryIdentificationQualifier ReadAsPropertyName(
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
            return new BillingProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BillingProviderSecondaryIdentificationQualifier value,
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
        /// <summary>
        /// Provider Commercial Number
        /// </summary>
        public const string G2 = "G2";

        /// <summary>
        /// Location Number
        /// </summary>
        public const string Lu = "LU";
    }
}
