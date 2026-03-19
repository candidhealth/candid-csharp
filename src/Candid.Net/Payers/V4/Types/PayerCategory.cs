using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

[JsonConverter(typeof(StringEnumSerializer<PayerCategory>))]
[Serializable]
public readonly record struct PayerCategory : IStringEnum
{
    public static readonly PayerCategory Bcbs = new(Values.Bcbs);

    public static readonly PayerCategory AetnaAffiliated = new(Values.AetnaAffiliated);

    public static readonly PayerCategory CignaAffiliated = new(Values.CignaAffiliated);

    public static readonly PayerCategory UnitedAffiliated = new(Values.UnitedAffiliated);

    public static readonly PayerCategory Medicare = new(Values.Medicare);

    public static readonly PayerCategory NonTraditionalMedicare = new(
        Values.NonTraditionalMedicare
    );

    public static readonly PayerCategory Medicaid = new(Values.Medicaid);

    public static readonly PayerCategory Hospice = new(Values.Hospice);

    public static readonly PayerCategory Snf = new(Values.Snf);

    public static readonly PayerCategory Tricare = new(Values.Tricare);

    public static readonly PayerCategory WorkersComp = new(Values.WorkersComp);

    public static readonly PayerCategory OtherGovernment = new(Values.OtherGovernment);

    public static readonly PayerCategory AutoTpl = new(Values.AutoTpl);

    public PayerCategory(string value)
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
    public static PayerCategory FromCustom(string value)
    {
        return new PayerCategory(value);
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

    public static bool operator ==(PayerCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayerCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayerCategory value) => value.Value;

    public static explicit operator PayerCategory(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Bcbs = "BCBS";

        public const string AetnaAffiliated = "AETNA_AFFILIATED";

        public const string CignaAffiliated = "CIGNA_AFFILIATED";

        public const string UnitedAffiliated = "UNITED_AFFILIATED";

        public const string Medicare = "MEDICARE";

        public const string NonTraditionalMedicare = "NON_TRADITIONAL_MEDICARE";

        public const string Medicaid = "MEDICAID";

        public const string Hospice = "HOSPICE";

        public const string Snf = "SNF";

        public const string Tricare = "TRICARE";

        public const string WorkersComp = "WORKERS_COMP";

        public const string OtherGovernment = "OTHER_GOVERNMENT";

        public const string AutoTpl = "AUTO_TPL";
    }
}
