using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(AuthorizationUnit.AuthorizationUnitSerializer))]
[Serializable]
public readonly record struct AuthorizationUnit : IStringEnum
{
    public static readonly AuthorizationUnit Visit = new(Values.Visit);

    public static readonly AuthorizationUnit Unit = new(Values.Unit);

    public AuthorizationUnit(string value)
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
    public static AuthorizationUnit FromCustom(string value)
    {
        return new AuthorizationUnit(value);
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

    public static bool operator ==(AuthorizationUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AuthorizationUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AuthorizationUnit value) => value.Value;

    public static explicit operator AuthorizationUnit(string value) => new(value);

    internal class AuthorizationUnitSerializer : JsonConverter<AuthorizationUnit>
    {
        public override AuthorizationUnit Read(
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
            return new AuthorizationUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AuthorizationUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AuthorizationUnit ReadAsPropertyName(
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
            return new AuthorizationUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AuthorizationUnit value,
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
        public const string Visit = "VISIT";

        public const string Unit = "UNIT";
    }
}
