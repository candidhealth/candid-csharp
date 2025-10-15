using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<SourceOfPaymentCode>))]
[Serializable]
public readonly record struct SourceOfPaymentCode : IStringEnum
{
    /// <summary>
    /// Self-pay
    /// </summary>
    public static readonly SourceOfPaymentCode SelfPay = new(Values.SelfPay);

    /// <summary>
    /// Other Non-Federal Programs
    /// </summary>
    public static readonly SourceOfPaymentCode OtherNonFederalPrograms = new(
        Values.OtherNonFederalPrograms
    );

    /// <summary>
    /// Preferred Provider Organization (PPO)
    /// </summary>
    public static readonly SourceOfPaymentCode Ppo = new(Values.Ppo);

    /// <summary>
    /// Point of Service (POS)
    /// </summary>
    public static readonly SourceOfPaymentCode Pos = new(Values.Pos);

    /// <summary>
    /// Exclusive Provider Organization (EPO)
    /// </summary>
    public static readonly SourceOfPaymentCode Epo = new(Values.Epo);

    /// <summary>
    /// Indemnity Insurance
    /// </summary>
    public static readonly SourceOfPaymentCode IndemnityInsurance = new(Values.IndemnityInsurance);

    /// <summary>
    /// Health Maintenance Organization (HMO) Medicare Risk
    /// </summary>
    public static readonly SourceOfPaymentCode HmoMedicareRisk = new(Values.HmoMedicareRisk);

    /// <summary>
    /// Dental Maintenance Organization
    /// </summary>
    public static readonly SourceOfPaymentCode Dmo = new(Values.Dmo);

    /// <summary>
    /// Automobile Medical
    /// </summary>
    public static readonly SourceOfPaymentCode Auto = new(Values.Auto);

    /// <summary>
    /// Blue Cross/Blue Shield
    /// </summary>
    public static readonly SourceOfPaymentCode BlueCrossBlueShield = new(
        Values.BlueCrossBlueShield
    );

    /// <summary>
    /// CHAMPUS
    /// </summary>
    public static readonly SourceOfPaymentCode Champus = new(Values.Champus);

    /// <summary>
    /// Commercial Insurance Co.
    /// </summary>
    public static readonly SourceOfPaymentCode CommercialInsuranceCo = new(
        Values.CommercialInsuranceCo
    );

    /// <summary>
    /// Disability
    /// </summary>
    public static readonly SourceOfPaymentCode Disability = new(Values.Disability);

    /// <summary>
    /// Federal Employees Program
    /// </summary>
    public static readonly SourceOfPaymentCode FederalEmployees = new(Values.FederalEmployees);

    /// <summary>
    /// Health Maintenance Organization (HMO)
    /// </summary>
    public static readonly SourceOfPaymentCode Hmo = new(Values.Hmo);

    /// <summary>
    /// Liability Medical
    /// </summary>
    public static readonly SourceOfPaymentCode Liability = new(Values.Liability);

    /// <summary>
    /// Medicare Part A
    /// </summary>
    public static readonly SourceOfPaymentCode MedicarePartA = new(Values.MedicarePartA);

    /// <summary>
    /// Medicare Part B
    /// </summary>
    public static readonly SourceOfPaymentCode MedicarePartB = new(Values.MedicarePartB);

    /// <summary>
    /// Medicaid
    /// </summary>
    public static readonly SourceOfPaymentCode Medicaid = new(Values.Medicaid);

    /// <summary>
    /// Other Federal Program
    /// </summary>
    public static readonly SourceOfPaymentCode OtherFederalProgram = new(
        Values.OtherFederalProgram
    );

    /// <summary>
    /// Title V
    /// </summary>
    public static readonly SourceOfPaymentCode TitleV = new(Values.TitleV);

    /// <summary>
    /// Veterans Affairs Plan
    /// </summary>
    public static readonly SourceOfPaymentCode VeteransAffairsPlan = new(
        Values.VeteransAffairsPlan
    );

    /// <summary>
    /// Workers' Compensation Health Claim
    /// </summary>
    public static readonly SourceOfPaymentCode WorkersCompHealthClaim = new(
        Values.WorkersCompHealthClaim
    );

    /// <summary>
    /// Mutually Defined
    /// </summary>
    public static readonly SourceOfPaymentCode MutuallyDefined = new(Values.MutuallyDefined);

    public SourceOfPaymentCode(string value)
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
    public static SourceOfPaymentCode FromCustom(string value)
    {
        return new SourceOfPaymentCode(value);
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

    public static bool operator ==(SourceOfPaymentCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SourceOfPaymentCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SourceOfPaymentCode value) => value.Value;

    public static explicit operator SourceOfPaymentCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Self-pay
        /// </summary>
        public const string SelfPay = "09";

        /// <summary>
        /// Other Non-Federal Programs
        /// </summary>
        public const string OtherNonFederalPrograms = "11";

        /// <summary>
        /// Preferred Provider Organization (PPO)
        /// </summary>
        public const string Ppo = "12";

        /// <summary>
        /// Point of Service (POS)
        /// </summary>
        public const string Pos = "13";

        /// <summary>
        /// Exclusive Provider Organization (EPO)
        /// </summary>
        public const string Epo = "14";

        /// <summary>
        /// Indemnity Insurance
        /// </summary>
        public const string IndemnityInsurance = "15";

        /// <summary>
        /// Health Maintenance Organization (HMO) Medicare Risk
        /// </summary>
        public const string HmoMedicareRisk = "16";

        /// <summary>
        /// Dental Maintenance Organization
        /// </summary>
        public const string Dmo = "17";

        /// <summary>
        /// Automobile Medical
        /// </summary>
        public const string Auto = "AM";

        /// <summary>
        /// Blue Cross/Blue Shield
        /// </summary>
        public const string BlueCrossBlueShield = "BL";

        /// <summary>
        /// CHAMPUS
        /// </summary>
        public const string Champus = "CH";

        /// <summary>
        /// Commercial Insurance Co.
        /// </summary>
        public const string CommercialInsuranceCo = "CI";

        /// <summary>
        /// Disability
        /// </summary>
        public const string Disability = "DS";

        /// <summary>
        /// Federal Employees Program
        /// </summary>
        public const string FederalEmployees = "FI";

        /// <summary>
        /// Health Maintenance Organization (HMO)
        /// </summary>
        public const string Hmo = "HM";

        /// <summary>
        /// Liability Medical
        /// </summary>
        public const string Liability = "LM";

        /// <summary>
        /// Medicare Part A
        /// </summary>
        public const string MedicarePartA = "MA";

        /// <summary>
        /// Medicare Part B
        /// </summary>
        public const string MedicarePartB = "MB";

        /// <summary>
        /// Medicaid
        /// </summary>
        public const string Medicaid = "MC";

        /// <summary>
        /// Other Federal Program
        /// </summary>
        public const string OtherFederalProgram = "OF";

        /// <summary>
        /// Title V
        /// </summary>
        public const string TitleV = "TV";

        /// <summary>
        /// Veterans Affairs Plan
        /// </summary>
        public const string VeteransAffairsPlan = "VA";

        /// <summary>
        /// Workers' Compensation Health Claim
        /// </summary>
        public const string WorkersCompHealthClaim = "WC";

        /// <summary>
        /// Mutually Defined
        /// </summary>
        public const string MutuallyDefined = "ZZ";
    }
}
