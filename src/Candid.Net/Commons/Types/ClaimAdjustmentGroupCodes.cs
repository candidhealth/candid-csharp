using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<ClaimAdjustmentGroupCodes>))]
[Serializable]
public readonly record struct ClaimAdjustmentGroupCodes : IStringEnum
{
    public static readonly ClaimAdjustmentGroupCodes Co = new(Values.Co);

    public static readonly ClaimAdjustmentGroupCodes Cr = new(Values.Cr);

    public static readonly ClaimAdjustmentGroupCodes De = new(Values.De);

    public static readonly ClaimAdjustmentGroupCodes Ma = new(Values.Ma);

    public static readonly ClaimAdjustmentGroupCodes Oa = new(Values.Oa);

    public static readonly ClaimAdjustmentGroupCodes Pi = new(Values.Pi);

    public static readonly ClaimAdjustmentGroupCodes Pr = new(Values.Pr);

    public static readonly ClaimAdjustmentGroupCodes Rr = new(Values.Rr);

    public static readonly ClaimAdjustmentGroupCodes Nc = new(Values.Nc);

    public static readonly ClaimAdjustmentGroupCodes Unknown = new(Values.Unknown);

    public ClaimAdjustmentGroupCodes(string value)
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
    public static ClaimAdjustmentGroupCodes FromCustom(string value)
    {
        return new ClaimAdjustmentGroupCodes(value);
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

    public static bool operator ==(ClaimAdjustmentGroupCodes value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClaimAdjustmentGroupCodes value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClaimAdjustmentGroupCodes value) => value.Value;

    public static explicit operator ClaimAdjustmentGroupCodes(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Co = "CO";

        public const string Cr = "CR";

        public const string De = "DE";

        public const string Ma = "MA";

        public const string Oa = "OA";

        public const string Pi = "PI";

        public const string Pr = "PR";

        public const string Rr = "RR";

        public const string Nc = "NC";

        public const string Unknown = "UNKNOWN";
    }
}
