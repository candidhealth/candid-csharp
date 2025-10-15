using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(StringEnumSerializer<ContactPointUse>))]
[Serializable]
public readonly record struct ContactPointUse : IStringEnum
{
    public static readonly ContactPointUse Home = new(Values.Home);

    public static readonly ContactPointUse Work = new(Values.Work);

    public static readonly ContactPointUse Temp = new(Values.Temp);

    public static readonly ContactPointUse Old = new(Values.Old);

    public static readonly ContactPointUse Mobile = new(Values.Mobile);

    public ContactPointUse(string value)
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
    public static ContactPointUse FromCustom(string value)
    {
        return new ContactPointUse(value);
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

    public static bool operator ==(ContactPointUse value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactPointUse value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactPointUse value) => value.Value;

    public static explicit operator ContactPointUse(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Home = "HOME";

        public const string Work = "WORK";

        public const string Temp = "TEMP";

        public const string Old = "OLD";

        public const string Mobile = "MOBILE";
    }
}
