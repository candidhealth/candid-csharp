using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(StringEnumSerializer<ContractStatus>))]
[Serializable]
public readonly record struct ContractStatus : IStringEnum
{
    /// <summary>
    /// Contract is still in the works and has not been signed and counter-signed yet
    /// </summary>
    public static readonly ContractStatus Pending = new(Values.Pending);

    /// <summary>
    /// Contract is active and in effect (claims will need to
    /// be submitted under effective contracts)
    /// </summary>
    public static readonly ContractStatus Effective = new(Values.Effective);

    /// <summary>
    /// Contract is no longer effective but kept around for historical documentation
    /// </summary>
    public static readonly ContractStatus Cancelled = new(Values.Cancelled);

    public ContractStatus(string value)
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
    public static ContractStatus FromCustom(string value)
    {
        return new ContractStatus(value);
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

    public static bool operator ==(ContractStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContractStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContractStatus value) => value.Value;

    public static explicit operator ContractStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Contract is still in the works and has not been signed and counter-signed yet
        /// </summary>
        public const string Pending = "pending";

        /// <summary>
        /// Contract is active and in effect (claims will need to
        /// be submitted under effective contracts)
        /// </summary>
        public const string Effective = "effective";

        /// <summary>
        /// Contract is no longer effective but kept around for historical documentation
        /// </summary>
        public const string Cancelled = "cancelled";
    }
}
