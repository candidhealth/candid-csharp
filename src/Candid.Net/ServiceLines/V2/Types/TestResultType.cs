using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(StringEnumSerializer<TestResultType>))]
[Serializable]
public readonly record struct TestResultType : IStringEnum
{
    public static readonly TestResultType Hematocrit = new(Values.Hematocrit);

    public static readonly TestResultType Hemoglobin = new(Values.Hemoglobin);

    public static readonly TestResultType Ldl = new(Values.Ldl);

    public TestResultType(string value)
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
    public static TestResultType FromCustom(string value)
    {
        return new TestResultType(value);
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

    public static bool operator ==(TestResultType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TestResultType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TestResultType value) => value.Value;

    public static explicit operator TestResultType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Hematocrit = "HEMATOCRIT";

        public const string Hemoglobin = "HEMOGLOBIN";

        public const string Ldl = "LDL";
    }
}
