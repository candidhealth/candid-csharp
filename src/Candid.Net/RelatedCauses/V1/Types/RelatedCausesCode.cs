using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.RelatedCauses.V1;

[JsonConverter(typeof(StringEnumSerializer<RelatedCausesCode>))]
[Serializable]
public readonly record struct RelatedCausesCode : IStringEnum
{
    /// <summary>
    /// Auto Accident
    /// </summary>
    public static readonly RelatedCausesCode Caa = new(Values.Caa);

    /// <summary>
    /// Abuse
    /// </summary>
    public static readonly RelatedCausesCode Cab = new(Values.Cab);

    /// <summary>
    /// Another Party Responsible
    /// </summary>
    public static readonly RelatedCausesCode Cap = new(Values.Cap);

    /// <summary>
    /// Employment
    /// </summary>
    public static readonly RelatedCausesCode Cem = new(Values.Cem);

    /// <summary>
    /// Other Accident
    /// </summary>
    public static readonly RelatedCausesCode Coa = new(Values.Coa);

    /// <summary>
    /// Mutually Defined
    /// </summary>
    public static readonly RelatedCausesCode Czz = new(Values.Czz);

    public RelatedCausesCode(string value)
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
    public static RelatedCausesCode FromCustom(string value)
    {
        return new RelatedCausesCode(value);
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

    public static bool operator ==(RelatedCausesCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RelatedCausesCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RelatedCausesCode value) => value.Value;

    public static explicit operator RelatedCausesCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Auto Accident
        /// </summary>
        public const string Caa = "AA";

        /// <summary>
        /// Abuse
        /// </summary>
        public const string Cab = "AB";

        /// <summary>
        /// Another Party Responsible
        /// </summary>
        public const string Cap = "AP";

        /// <summary>
        /// Employment
        /// </summary>
        public const string Cem = "EM";

        /// <summary>
        /// Other Accident
        /// </summary>
        public const string Coa = "OA";

        /// <summary>
        /// Mutually Defined
        /// </summary>
        public const string Czz = "ZZ";
    }
}
