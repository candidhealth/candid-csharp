using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<CoverageLevel>))]
[Serializable]
public readonly record struct CoverageLevel : IStringEnum
{
    public static readonly CoverageLevel EmployeeAndChildren = new(Values.EmployeeAndChildren);

    public static readonly CoverageLevel EmployeeOnly = new(Values.EmployeeOnly);

    public static readonly CoverageLevel EmployeeAndSpouse = new(Values.EmployeeAndSpouse);

    public static readonly CoverageLevel Family = new(Values.Family);

    public static readonly CoverageLevel Individual = new(Values.Individual);

    public CoverageLevel(string value)
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
    public static CoverageLevel FromCustom(string value)
    {
        return new CoverageLevel(value);
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

    public static bool operator ==(CoverageLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CoverageLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CoverageLevel value) => value.Value;

    public static explicit operator CoverageLevel(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EmployeeAndChildren = "EMPLOYEE_AND_CHILDREN";

        public const string EmployeeOnly = "EMPLOYEE_ONLY";

        public const string EmployeeAndSpouse = "EMPLOYEE_AND_SPOUSE";

        public const string Family = "FAMILY";

        public const string Individual = "INDIVIDUAL";
    }
}
