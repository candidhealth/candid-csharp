using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[JsonConverter(typeof(StringEnumSerializer<ContractType>))]
[Serializable]
public readonly record struct ContractType : IStringEnum
{
    /// <summary>
    /// Professional contract
    /// </summary>
    public static readonly ContractType Professional = new(Values.Professional);

    /// <summary>
    /// Institutional contract
    /// </summary>
    public static readonly ContractType Institutional = new(Values.Institutional);

    public ContractType(string value)
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
    public static ContractType FromCustom(string value)
    {
        return new ContractType(value);
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

    public static bool operator ==(ContractType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractType value) => value.Value;

    public static explicit operator ContractType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Professional contract
        /// </summary>
        public const string Professional = "professional";

        /// <summary>
        /// Institutional contract
        /// </summary>
        public const string Institutional = "institutional";
    }
}
