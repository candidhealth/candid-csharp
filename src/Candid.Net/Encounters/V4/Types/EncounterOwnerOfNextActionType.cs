using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterOwnerOfNextActionType>))]
[Serializable]
public readonly record struct EncounterOwnerOfNextActionType : IStringEnum
{
    public static readonly EncounterOwnerOfNextActionType Candid = new(Values.Candid);

    public static readonly EncounterOwnerOfNextActionType Customer = new(Values.Customer);

    public static readonly EncounterOwnerOfNextActionType Coder = new(Values.Coder);

    public static readonly EncounterOwnerOfNextActionType None = new(Values.None);

    public EncounterOwnerOfNextActionType(string value)
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
    public static EncounterOwnerOfNextActionType FromCustom(string value)
    {
        return new EncounterOwnerOfNextActionType(value);
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

    public static bool operator ==(EncounterOwnerOfNextActionType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterOwnerOfNextActionType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterOwnerOfNextActionType value) => value.Value;

    public static explicit operator EncounterOwnerOfNextActionType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candid = "CANDID";

        public const string Customer = "CUSTOMER";

        public const string Coder = "CODER";

        public const string None = "NONE";
    }
}
