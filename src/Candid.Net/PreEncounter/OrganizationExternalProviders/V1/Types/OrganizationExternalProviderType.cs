using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders.V1;

[JsonConverter(typeof(OrganizationExternalProviderType.OrganizationExternalProviderTypeSerializer))]
[Serializable]
public readonly record struct OrganizationExternalProviderType : IStringEnum
{
    public static readonly OrganizationExternalProviderType Referring = new(Values.Referring);

    public static readonly OrganizationExternalProviderType Primary = new(Values.Primary);

    public static readonly OrganizationExternalProviderType Treating = new(Values.Treating);

    public OrganizationExternalProviderType(string value)
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
    public static OrganizationExternalProviderType FromCustom(string value)
    {
        return new OrganizationExternalProviderType(value);
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

    public static bool operator ==(OrganizationExternalProviderType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OrganizationExternalProviderType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OrganizationExternalProviderType value) => value.Value;

    public static explicit operator OrganizationExternalProviderType(string value) => new(value);

    internal class OrganizationExternalProviderTypeSerializer
        : JsonConverter<OrganizationExternalProviderType>
    {
        public override OrganizationExternalProviderType Read(
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
            return new OrganizationExternalProviderType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OrganizationExternalProviderType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OrganizationExternalProviderType ReadAsPropertyName(
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
            return new OrganizationExternalProviderType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OrganizationExternalProviderType value,
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
        public const string Referring = "REFERRING";

        public const string Primary = "PRIMARY";

        public const string Treating = "TREATING";
    }
}
