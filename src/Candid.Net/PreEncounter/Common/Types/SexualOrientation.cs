using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<SexualOrientation>))]
[Serializable]
public readonly record struct SexualOrientation : IStringEnum
{
    public static readonly SexualOrientation Heterosexual = new(Values.Heterosexual);

    public static readonly SexualOrientation Homosexual = new(Values.Homosexual);

    public static readonly SexualOrientation Bisexual = new(Values.Bisexual);

    public static readonly SexualOrientation TwoSpirit = new(Values.TwoSpirit);

    public static readonly SexualOrientation Other = new(Values.Other);

    public static readonly SexualOrientation Unknown = new(Values.Unknown);

    public static readonly SexualOrientation Refused = new(Values.Refused);

    public SexualOrientation(string value)
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
    public static SexualOrientation FromCustom(string value)
    {
        return new SexualOrientation(value);
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

    public static bool operator ==(SexualOrientation value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SexualOrientation value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SexualOrientation value) => value.Value;

    public static explicit operator SexualOrientation(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Heterosexual = "HETEROSEXUAL";

        public const string Homosexual = "HOMOSEXUAL";

        public const string Bisexual = "BISEXUAL";

        public const string TwoSpirit = "TWO_SPIRIT";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string Refused = "REFUSED";
    }
}
