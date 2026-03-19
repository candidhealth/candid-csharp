using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

[JsonConverter(
    typeof(ReferringProviderSecondaryIdentificationQualifier.ReferringProviderSecondaryIdentificationQualifierSerializer)
)]
[Serializable]
public readonly record struct ReferringProviderSecondaryIdentificationQualifier : IStringEnum
{
    /// <summary>
    /// State License Number
    /// </summary>
    public static readonly ReferringProviderSecondaryIdentificationQualifier ZeroB = new(
        Values.ZeroB
    );

    /// <summary>
    /// Provider UPIN Number
    /// </summary>
    public static readonly ReferringProviderSecondaryIdentificationQualifier OneG = new(
        Values.OneG
    );

    /// <summary>
    /// Provider Commercial Number
    /// </summary>
    public static readonly ReferringProviderSecondaryIdentificationQualifier G2 = new(Values.G2);

    public ReferringProviderSecondaryIdentificationQualifier(string value)
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
    public static ReferringProviderSecondaryIdentificationQualifier FromCustom(string value)
    {
        return new ReferringProviderSecondaryIdentificationQualifier(value);
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
        ReferringProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReferringProviderSecondaryIdentificationQualifier value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReferringProviderSecondaryIdentificationQualifier value
    ) => value.Value;

    public static explicit operator ReferringProviderSecondaryIdentificationQualifier(
        string value
    ) => new(value);

    internal class ReferringProviderSecondaryIdentificationQualifierSerializer
        : JsonConverter<ReferringProviderSecondaryIdentificationQualifier>
    {
        public override ReferringProviderSecondaryIdentificationQualifier Read(
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
            return new ReferringProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReferringProviderSecondaryIdentificationQualifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReferringProviderSecondaryIdentificationQualifier ReadAsPropertyName(
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
            return new ReferringProviderSecondaryIdentificationQualifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReferringProviderSecondaryIdentificationQualifier value,
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
    }
}
