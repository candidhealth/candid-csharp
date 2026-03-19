using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[JsonConverter(
    typeof(ProviderSecondaryIdentificationQualifier.ProviderSecondaryIdentificationQualifierSerializer)
)]
[Serializable]
public readonly record struct ProviderSecondaryIdentificationQualifier : IStringEnum
{
    /// <summary>
    /// State License Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier ZeroB = new(Values.ZeroB);

    /// <summary>
    /// Provider UPIN Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier OneG = new(Values.OneG);

    /// <summary>
    /// Provider Commercial Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier G2 = new(Values.G2);

    /// <summary>
    /// Location Number
    /// </summary>
    public static readonly ProviderSecondaryIdentificationQualifier Lu = new(Values.Lu);

    public ProviderSecondaryIdentificationQualifier(string value)
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
    public static ProviderSecondaryIdentificationQualifier FromCustom(string value)
    {
        return new ProviderSecondaryIdentificationQualifier(value);
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
        ProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ProviderSecondaryIdentificationQualifier value) =>
        value.Value;

    public static explicit operator ProviderSecondaryIdentificationQualifier(string value) =>
        new(value);

    internal class ProviderSecondaryIdentificationQualifierSerializer
        : JsonConverter<ProviderSecondaryIdentificationQualifier>
    {
        public override ProviderSecondaryIdentificationQualifier Read(
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
            return new ProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ProviderSecondaryIdentificationQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ProviderSecondaryIdentificationQualifier ReadAsPropertyName(
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
            return new ProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ProviderSecondaryIdentificationQualifier value,
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
        /// State License Number
        /// </summary>
        public const string ZeroB = "0B";

        /// <summary>
        /// Provider UPIN Number
        /// </summary>
        public const string OneG = "1G";

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
