using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<Race>))]
[Serializable]
public readonly record struct Race : IStringEnum
{
    public static readonly Race AmericanIndianOrAlaskaNative = new(
        Values.AmericanIndianOrAlaskaNative
    );

    public static readonly Race White = new(Values.White);

    public static readonly Race Black = new(Values.Black);

    public static readonly Race Asian = new(Values.Asian);

    public static readonly Race NativeHawaiianOrOtherPacificIslander = new(
        Values.NativeHawaiianOrOtherPacificIslander
    );

    public static readonly Race MiddleEasternOrNorthAfrican = new(
        Values.MiddleEasternOrNorthAfrican
    );

    public static readonly Race Other = new(Values.Other);

    public static readonly Race Unknown = new(Values.Unknown);

    public static readonly Race Refused = new(Values.Refused);

    public Race(string value)
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
    public static Race FromCustom(string value)
    {
        return new Race(value);
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

    public static bool operator ==(Race value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Race value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Race value) => value.Value;

    public static explicit operator Race(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AmericanIndianOrAlaskaNative = "AMERICAN_INDIAN_OR_ALASKA_NATIVE";

        public const string White = "WHITE";

        public const string Black = "BLACK";

        public const string Asian = "ASIAN";

        public const string NativeHawaiianOrOtherPacificIslander =
            "NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER";

        public const string MiddleEasternOrNorthAfrican = "MIDDLE_EASTERN_OR_NORTH_AFRICAN";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string Refused = "REFUSED";
    }
}
