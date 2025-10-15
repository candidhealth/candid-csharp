using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(StringEnumSerializer<ChargeCaptureClaimCreationSortField>))]
[Serializable]
public readonly record struct ChargeCaptureClaimCreationSortField : IStringEnum
{
    public static readonly ChargeCaptureClaimCreationSortField CreatedAt = new(Values.CreatedAt);

    public ChargeCaptureClaimCreationSortField(string value)
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
    public static ChargeCaptureClaimCreationSortField FromCustom(string value)
    {
        return new ChargeCaptureClaimCreationSortField(value);
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

    public static bool operator ==(ChargeCaptureClaimCreationSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChargeCaptureClaimCreationSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChargeCaptureClaimCreationSortField value) =>
        value.Value;

    public static explicit operator ChargeCaptureClaimCreationSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAt = "created_at";
    }
}
