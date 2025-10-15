using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<CoverageStatus>))]
[Serializable]
public readonly record struct CoverageStatus : IStringEnum
{
    public static readonly CoverageStatus Active = new(Values.Active);

    public static readonly CoverageStatus Cancelled = new(Values.Cancelled);

    public static readonly CoverageStatus Draft = new(Values.Draft);

    public static readonly CoverageStatus EnteredInError = new(Values.EnteredInError);

    public CoverageStatus(string value)
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
    public static CoverageStatus FromCustom(string value)
    {
        return new CoverageStatus(value);
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

    public static bool operator ==(CoverageStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageStatus value) => value.Value;

    public static explicit operator CoverageStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Cancelled = "CANCELLED";

        public const string Draft = "DRAFT";

        public const string EnteredInError = "ENTERED_IN_ERROR";
    }
}
