using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<NetworkType>))]
[Serializable]
public readonly record struct NetworkType : IStringEnum
{
    /// <summary>
    /// Preferred Provider Organization (PPO)
    /// </summary>
    public static readonly NetworkType Ppo = new(Values.Ppo);

    /// <summary>
    /// Point of Service (POS)
    /// </summary>
    public static readonly NetworkType Pos = new(Values.Pos);

    /// <summary>
    /// Exclusive Provider Organization (EPO)
    /// </summary>
    public static readonly NetworkType Epo = new(Values.Epo);

    /// <summary>
    /// Indemnity Insurance
    /// </summary>
    public static readonly NetworkType IndemnityInsurance = new(Values.IndemnityInsurance);

    /// <summary>
    /// Health Maintenance Organization (HMO) Medicare Risk
    /// </summary>
    public static readonly NetworkType HmoMedicareRisk = new(Values.HmoMedicareRisk);

    /// <summary>
    /// Dental Maintenance Organization
    /// </summary>
    public static readonly NetworkType Dmo = new(Values.Dmo);

    /// <summary>
    /// Automobile Medical
    /// </summary>
    public static readonly NetworkType Auto = new(Values.Auto);

    /// <summary>
    /// CHAMPUS
    /// </summary>
    public static readonly NetworkType Champus = new(Values.Champus);

    /// <summary>
    /// Disability
    /// </summary>
    public static readonly NetworkType Disability = new(Values.Disability);

    /// <summary>
    /// Health Maintenance Organization (HMO)
    /// </summary>
    public static readonly NetworkType Hmo = new(Values.Hmo);

    /// <summary>
    /// Liability Medical
    /// </summary>
    public static readonly NetworkType Liability = new(Values.Liability);

    /// <summary>
    /// Medicare Part A
    /// </summary>
    public static readonly NetworkType MedicarePartA = new(Values.MedicarePartA);

    /// <summary>
    /// Medicare Part B
    /// </summary>
    public static readonly NetworkType MedicarePartB = new(Values.MedicarePartB);

    /// <summary>
    /// Medicaid
    /// </summary>
    public static readonly NetworkType Medicaid = new(Values.Medicaid);

    /// <summary>
    /// Other Federal Program
    /// </summary>
    public static readonly NetworkType OtherFederalProgram = new(Values.OtherFederalProgram);

    /// <summary>
    /// Title V
    /// </summary>
    public static readonly NetworkType TitleV = new(Values.TitleV);

    /// <summary>
    /// Veterans Affairs Plan
    /// </summary>
    public static readonly NetworkType VeteransAffairsPlan = new(Values.VeteransAffairsPlan);

    /// <summary>
    /// Workers' Compensation Health Claim
    /// </summary>
    public static readonly NetworkType WorkersCompHealthClaim = new(Values.WorkersCompHealthClaim);

    /// <summary>
    /// Mutually Defined
    /// </summary>
    public static readonly NetworkType MutuallyDefined = new(Values.MutuallyDefined);

    /// <summary>
    /// Commercial Insurance
    /// </summary>
    public static readonly NetworkType CommercialInsuranceCo = new(Values.CommercialInsuranceCo);

    /// <summary>
    /// Blue Cross Blue Shield
    /// </summary>
    public static readonly NetworkType BlueCrossBlueShield = new(Values.BlueCrossBlueShield);

    public NetworkType(string value)
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
    public static NetworkType FromCustom(string value)
    {
        return new NetworkType(value);
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

    public static bool operator ==(NetworkType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NetworkType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NetworkType value) => value.Value;

    public static explicit operator NetworkType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
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
        /// CHAMPUS
        /// </summary>
        public const string Champus = "CH";

        /// <summary>
        /// Disability
        /// </summary>
        public const string Disability = "DS";

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

        /// <summary>
        /// Commercial Insurance
        /// </summary>
        public const string CommercialInsuranceCo = "CI";

        /// <summary>
        /// Blue Cross Blue Shield
        /// </summary>
        public const string BlueCrossBlueShield = "BL";
    }
}
