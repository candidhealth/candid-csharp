using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<Clearinghouse>))]
[Serializable]
public readonly record struct Clearinghouse : IStringEnum
{
    public static readonly Clearinghouse ChangeHealthcare = new(Values.ChangeHealthcare);

    public static readonly Clearinghouse Olive = new(Values.Olive);

    public static readonly Clearinghouse UcsfCirius = new(Values.UcsfCirius);

    public static readonly Clearinghouse Availity = new(Values.Availity);

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

        public const string PayerPortal = "PAYER_PORTAL";

        public const string Stedi = "STEDI";

        public const string Waystar = "WAYSTAR";

        public const string Unknown = "UNKNOWN";
    }
}
