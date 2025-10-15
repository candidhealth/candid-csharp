using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V1;

[JsonConverter(typeof(StringEnumSerializer<ExpectedNetworkStatus>))]
[Serializable]
public readonly record struct ExpectedNetworkStatus : IStringEnum
{
    public static readonly ExpectedNetworkStatus InNetwork = new(Values.InNetwork);

    public static readonly ExpectedNetworkStatus OutOfNetwork = new(Values.OutOfNetwork);

    public static readonly ExpectedNetworkStatus Unknown = new(Values.Unknown);

    public ExpectedNetworkStatus(string value)
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
    public static ExpectedNetworkStatus FromCustom(string value)
    {
        return new ExpectedNetworkStatus(value);
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

    public static bool operator ==(ExpectedNetworkStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ExpectedNetworkStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ExpectedNetworkStatus value) => value.Value;

    public static explicit operator ExpectedNetworkStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InNetwork = "in_network";

        public const string OutOfNetwork = "out_of_network";

        public const string Unknown = "unknown";
    }
}
