using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterSubmissionOriginType>))]
[Serializable]
public readonly record struct EncounterSubmissionOriginType : IStringEnum
{
    public static readonly EncounterSubmissionOriginType Candid = new(Values.Candid);

    public static readonly EncounterSubmissionOriginType External = new(Values.External);

    public EncounterSubmissionOriginType(string value)
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
    public static EncounterSubmissionOriginType FromCustom(string value)
    {
        return new EncounterSubmissionOriginType(value);
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

    public static bool operator ==(EncounterSubmissionOriginType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterSubmissionOriginType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterSubmissionOriginType value) => value.Value;

    public static explicit operator EncounterSubmissionOriginType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candid = "CANDID";

        public const string External = "EXTERNAL";
    }
}
