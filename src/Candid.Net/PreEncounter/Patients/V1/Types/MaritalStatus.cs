using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<MaritalStatus>))]
[Serializable]
public readonly record struct MaritalStatus : IStringEnum
{
    public static readonly MaritalStatus Annulled = new(Values.Annulled);

    public static readonly MaritalStatus Divorced = new(Values.Divorced);

    public static readonly MaritalStatus Interlocutory = new(Values.Interlocutory);

    public static readonly MaritalStatus Separated = new(Values.Separated);

    public static readonly MaritalStatus Married = new(Values.Married);

    public static readonly MaritalStatus CommonLaw = new(Values.CommonLaw);

    public static readonly MaritalStatus Polygamous = new(Values.Polygamous);

    public static readonly MaritalStatus DomesticPartner = new(Values.DomesticPartner);

    public static readonly MaritalStatus Unmarried = new(Values.Unmarried);

    public static readonly MaritalStatus NeverMarried = new(Values.NeverMarried);

    public static readonly MaritalStatus Widowed = new(Values.Widowed);

    public static readonly MaritalStatus Unknown = new(Values.Unknown);

    public MaritalStatus(string value)
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
    public static MaritalStatus FromCustom(string value)
    {
        return new MaritalStatus(value);
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

    public static bool operator ==(MaritalStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MaritalStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MaritalStatus value) => value.Value;

    public static explicit operator MaritalStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Annulled = "ANNULLED";

        public const string Divorced = "DIVORCED";

        public const string Interlocutory = "INTERLOCUTORY";

        public const string Separated = "SEPARATED";

        public const string Married = "MARRIED";

        public const string CommonLaw = "COMMON_LAW";

        public const string Polygamous = "POLYGAMOUS";

        public const string DomesticPartner = "DOMESTIC_PARTNER";

        public const string Unmarried = "UNMARRIED";

        public const string NeverMarried = "NEVER_MARRIED";

        public const string Widowed = "WIDOWED";

        public const string Unknown = "UNKNOWN";
    }
}
