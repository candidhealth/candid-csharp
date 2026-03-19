using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(
    typeof(EpsdtReferralConditionIndicatorCode.EpsdtReferralConditionIndicatorCodeSerializer)
)]
[Serializable]
public readonly record struct EpsdtReferralConditionIndicatorCode : IStringEnum
{
    public static readonly EpsdtReferralConditionIndicatorCode Av = new(Values.Av);

    public static readonly EpsdtReferralConditionIndicatorCode Nu = new(Values.Nu);

    public static readonly EpsdtReferralConditionIndicatorCode S2 = new(Values.S2);

    public static readonly EpsdtReferralConditionIndicatorCode St = new(Values.St);

    public EpsdtReferralConditionIndicatorCode(string value)
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
    public static EpsdtReferralConditionIndicatorCode FromCustom(string value)
    {
        return new EpsdtReferralConditionIndicatorCode(value);
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

    public static bool operator ==(EpsdtReferralConditionIndicatorCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EpsdtReferralConditionIndicatorCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EpsdtReferralConditionIndicatorCode value) =>
        value.Value;

    public static explicit operator EpsdtReferralConditionIndicatorCode(string value) => new(value);

    internal class EpsdtReferralConditionIndicatorCodeSerializer
        : JsonConverter<EpsdtReferralConditionIndicatorCode>
    {
        public override EpsdtReferralConditionIndicatorCode Read(
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
            return new EpsdtReferralConditionIndicatorCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EpsdtReferralConditionIndicatorCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EpsdtReferralConditionIndicatorCode ReadAsPropertyName(
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
            return new EpsdtReferralConditionIndicatorCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EpsdtReferralConditionIndicatorCode value,
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
        public const string Av = "AV";

        public const string Nu = "NU";

        public const string S2 = "S2";

        public const string St = "ST";
    }
}
