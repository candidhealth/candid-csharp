using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EraCommons;

[JsonConverter(typeof(ClaimStatusCodeCreate.ClaimStatusCodeCreateSerializer))]
[Serializable]
public readonly record struct ClaimStatusCodeCreate : IStringEnum
{
    public static readonly ClaimStatusCodeCreate ProcessedAsPrimary = new(
        Values.ProcessedAsPrimary
    );

    public static readonly ClaimStatusCodeCreate ProcessedAsSecondary = new(
        Values.ProcessedAsSecondary
    );

    public static readonly ClaimStatusCodeCreate ProcessedAsTertiary = new(
        Values.ProcessedAsTertiary
    );

    public static readonly ClaimStatusCodeCreate Denied = new(Values.Denied);

    public static readonly ClaimStatusCodeCreate ProcessedAsPrimaryForwarded = new(
        Values.ProcessedAsPrimaryForwarded
    );

    public static readonly ClaimStatusCodeCreate ProcessedAsSecondaryForwarded = new(
        Values.ProcessedAsSecondaryForwarded
    );

    public static readonly ClaimStatusCodeCreate ProcessedAsTertiaryForwarded = new(
        Values.ProcessedAsTertiaryForwarded
    );

    public static readonly ClaimStatusCodeCreate ReversalOfPreviousPayment = new(
        Values.ReversalOfPreviousPayment
    );

    public static readonly ClaimStatusCodeCreate NotOurClaimForwarded = new(
        Values.NotOurClaimForwarded
    );

    public ClaimStatusCodeCreate(string value)
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
    public static ClaimStatusCodeCreate FromCustom(string value)
    {
        return new ClaimStatusCodeCreate(value);
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

    public static bool operator ==(ClaimStatusCodeCreate value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClaimStatusCodeCreate value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClaimStatusCodeCreate value) => value.Value;

    public static explicit operator ClaimStatusCodeCreate(string value) => new(value);

    internal class ClaimStatusCodeCreateSerializer : JsonConverter<ClaimStatusCodeCreate>
    {
        public override ClaimStatusCodeCreate Read(
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
            return new ClaimStatusCodeCreate(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ClaimStatusCodeCreate value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ClaimStatusCodeCreate ReadAsPropertyName(
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
            return new ClaimStatusCodeCreate(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ClaimStatusCodeCreate value,
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
        public const string ProcessedAsPrimary = "1";

        public const string ProcessedAsSecondary = "2";

        public const string ProcessedAsTertiary = "3";

        public const string Denied = "4";

        public const string ProcessedAsPrimaryForwarded = "19";

        public const string ProcessedAsSecondaryForwarded = "20";

        public const string ProcessedAsTertiaryForwarded = "21";

        public const string ReversalOfPreviousPayment = "22";

        public const string NotOurClaimForwarded = "23";
    }
}
