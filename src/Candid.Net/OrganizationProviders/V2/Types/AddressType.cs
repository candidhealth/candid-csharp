using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V2;

[JsonConverter(typeof(AddressType.AddressTypeSerializer))]
[Serializable]
public readonly record struct AddressType : IStringEnum
{
    public static readonly AddressType Default = new(Values.Default);

    public AddressType(string value)
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
    public static AddressType FromCustom(string value)
    {
        return new AddressType(value);
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

    public static bool operator ==(AddressType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressType value) => value.Value;

    public static explicit operator AddressType(string value) => new(value);

    internal class AddressTypeSerializer : JsonConverter<AddressType>
    {
        public override AddressType Read(
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
            return new AddressType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AddressType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AddressType ReadAsPropertyName(
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
            return new AddressType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AddressType value,
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
        public const string Default = "DEFAULT";
    }
}
