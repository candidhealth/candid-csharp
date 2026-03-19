using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(Clearinghouse.ClearinghouseSerializer))]
[Serializable]
public readonly record struct Clearinghouse : IStringEnum
{
    public static readonly Clearinghouse ChangeHealthcare = new(Values.ChangeHealthcare);

    public static readonly Clearinghouse Olive = new(Values.Olive);

    public static readonly Clearinghouse UcsfCirius = new(Values.UcsfCirius);

    public static readonly Clearinghouse Availity = new(Values.Availity);

    public static readonly Clearinghouse Jopari = new(Values.Jopari);

    public static readonly Clearinghouse PayerPortal = new(Values.PayerPortal);

    public static readonly Clearinghouse Stedi = new(Values.Stedi);

    public static readonly Clearinghouse Waystar = new(Values.Waystar);

    public static readonly Clearinghouse Unknown = new(Values.Unknown);

    public Clearinghouse(string value)
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
    public static Clearinghouse FromCustom(string value)
    {
        return new Clearinghouse(value);
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

    public static bool operator ==(Clearinghouse value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(Clearinghouse value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(Clearinghouse value) => value.Value;

    public static explicit operator Clearinghouse(string value) => new(value);

    internal class ClearinghouseSerializer : JsonConverter<Clearinghouse>
    {
        public override Clearinghouse Read(
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
            return new Clearinghouse(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Clearinghouse value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override Clearinghouse ReadAsPropertyName(
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
            return new Clearinghouse(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            Clearinghouse value,
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
        public const string ChangeHealthcare = "CHANGE_HEALTHCARE";

        public const string Olive = "OLIVE";

        public const string UcsfCirius = "UCSF_CIRIUS";

        public const string Availity = "AVAILITY";

        public const string Jopari = "JOPARI";

        public const string PayerPortal = "PAYER_PORTAL";

        public const string Stedi = "STEDI";

        public const string Waystar = "WAYSTAR";

        public const string Unknown = "UNKNOWN";
    }
}
