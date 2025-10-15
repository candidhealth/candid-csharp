using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<TypeOfFacilityCode>))]
[Serializable]
public readonly record struct TypeOfFacilityCode : IStringEnum
{
    /// <summary>
    /// Hospital
    /// </summary>
    public static readonly TypeOfFacilityCode C1 = new(Values.C1);

    /// <summary>
    /// Skilled Nursing Facility
    /// </summary>
    public static readonly TypeOfFacilityCode C2 = new(Values.C2);

    /// <summary>
    /// Home Health
    /// </summary>
    public static readonly TypeOfFacilityCode C3 = new(Values.C3);

    /// <summary>
    /// Religious Nonmedical (Hospital)
    /// </summary>
    public static readonly TypeOfFacilityCode C4 = new(Values.C4);

    /// <summary>
    /// Intermediate Care
    /// </summary>
    public static readonly TypeOfFacilityCode C6 = new(Values.C6);

    /// <summary>
    /// Clinic or Hospital based End Stage Renal Disease (ESRD) facility (requires Special second digit)
    /// </summary>
    public static readonly TypeOfFacilityCode C7 = new(Values.C7);

    /// <summary>
    /// Special facility or hospital (Critical Access Hospital (CAH)) (Ambulatory Surgical Center (ASC)) surgery (requires special second digit)
    /// </summary>
    public static readonly TypeOfFacilityCode C8 = new(Values.C8);

    public TypeOfFacilityCode(string value)
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
    public static TypeOfFacilityCode FromCustom(string value)
    {
        return new TypeOfFacilityCode(value);
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

    public static bool operator ==(TypeOfFacilityCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TypeOfFacilityCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TypeOfFacilityCode value) => value.Value;

    public static explicit operator TypeOfFacilityCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Hospital
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// Skilled Nursing Facility
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// Home Health
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// Religious Nonmedical (Hospital)
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// Intermediate Care
        /// </summary>
        public const string C6 = "6";

        /// <summary>
        /// Clinic or Hospital based End Stage Renal Disease (ESRD) facility (requires Special second digit)
        /// </summary>
        public const string C7 = "7";

        /// <summary>
        /// Special facility or hospital (Critical Access Hospital (CAH)) (Ambulatory Surgical Center (ASC)) surgery (requires special second digit)
        /// </summary>
        public const string C8 = "8";
    }
}
