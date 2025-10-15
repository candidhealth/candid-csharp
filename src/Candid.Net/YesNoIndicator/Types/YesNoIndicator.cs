using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.YesNoIndicator;

[JsonConverter(typeof(StringEnumSerializer<YesNoIndicator>))]
[Serializable]
public readonly record struct YesNoIndicator : IStringEnum
{
    public static readonly YesNoIndicator Yes = new(Values.Yes);

    public static readonly YesNoIndicator No = new(Values.No);

    public static readonly YesNoIndicator Unknown = new(Values.Unknown);

    public static readonly YesNoIndicator NotApplicable = new(Values.NotApplicable);

    public YesNoIndicator(string value)
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
    public static YesNoIndicator FromCustom(string value)
    {
        return new YesNoIndicator(value);
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

    public static bool operator ==(YesNoIndicator value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(YesNoIndicator value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(YesNoIndicator value) => value.Value;

    public static explicit operator YesNoIndicator(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Yes = "YES";

        public const string No = "NO";

        public const string Unknown = "UNKNOWN";

        public const string NotApplicable = "NOT_APPLICABLE";
    }
}
