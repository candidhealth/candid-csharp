using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

[JsonConverter(typeof(StringEnumSerializer<InvoiceSortField>))]
[Serializable]
public readonly record struct InvoiceSortField : IStringEnum
{
    public static readonly InvoiceSortField CreatedAt = new(Values.CreatedAt);

    public static readonly InvoiceSortField UpdatedAt = new(Values.UpdatedAt);

    public static readonly InvoiceSortField PatientExternalId = new(Values.PatientExternalId);

    public static readonly InvoiceSortField Note = new(Values.Note);

    public static readonly InvoiceSortField DueDate = new(Values.DueDate);

    public static readonly InvoiceSortField Status = new(Values.Status);

    public InvoiceSortField(string value)
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
    public static InvoiceSortField FromCustom(string value)
    {
        return new InvoiceSortField(value);
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

    public static bool operator ==(InvoiceSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoiceSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoiceSortField value) => value.Value;

    public static explicit operator InvoiceSortField(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAt = "CREATED_AT";

        public const string UpdatedAt = "UPDATED_AT";

        public const string PatientExternalId = "PATIENT_EXTERNAL_ID";

        public const string Note = "NOTE";

        public const string DueDate = "DUE_DATE";

        public const string Status = "STATUS";
    }
}
