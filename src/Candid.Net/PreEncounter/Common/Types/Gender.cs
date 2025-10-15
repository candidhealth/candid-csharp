using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<Gender>))]
[Serializable]
public readonly record struct Gender : IStringEnum
{
    public static readonly Gender Man = new(Values.Man);

    public static readonly Gender Woman = new(Values.Woman);

    public static readonly Gender NonBinary = new(Values.NonBinary);

    public static readonly Gender TwoSpirit = new(Values.TwoSpirit);

    public static readonly Gender FemaleToMale = new(Values.FemaleToMale);

    public static readonly Gender MaleToFemale = new(Values.MaleToFemale);

    public static readonly Gender Other = new(Values.Other);

    public static readonly Gender Unknown = new(Values.Unknown);

    public static readonly Gender Refused = new(Values.Refused);

    public Gender(string value)
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
    public static Gender FromCustom(string value)
    {
        return new Gender(value);
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

    public static bool operator ==(Gender value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(Gender value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(Gender value) => value.Value;

    public static explicit operator Gender(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Man = "MAN";

        public const string Woman = "WOMAN";

        public const string NonBinary = "NON_BINARY";

        public const string TwoSpirit = "TWO_SPIRIT";

        public const string FemaleToMale = "FEMALE_TO_MALE";

        public const string MaleToFemale = "MALE_TO_FEMALE";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string Refused = "REFUSED";
    }
}
