using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Commons;

[JsonConverter(typeof(AdjustmentReasonCode.AdjustmentReasonCodeSerializer))]
[Serializable]
public readonly record struct AdjustmentReasonCode : IStringEnum
{
    /// <summary>
    /// Late Charge
    /// </summary>
    public static readonly AdjustmentReasonCode C50 = new(Values.C50);

    /// <summary>
    /// Interest Penalty Charge
    /// </summary>
    public static readonly AdjustmentReasonCode C51 = new(Values.C51);

    /// <summary>
    /// Authorized Return
    /// </summary>
    public static readonly AdjustmentReasonCode C72 = new(Values.C72);

    /// <summary>
    /// Early Payment Allowance
    /// </summary>
    public static readonly AdjustmentReasonCode C90 = new(Values.C90);

    /// <summary>
    /// Origination Fee
    /// </summary>
    public static readonly AdjustmentReasonCode Cah = new(Values.Cah);

    /// <summary>
    /// Applied to Borrower's Account
    /// </summary>
    public static readonly AdjustmentReasonCode Cam = new(Values.Cam);

    /// <summary>
    /// Acceleration of Benefits
    /// </summary>
    public static readonly AdjustmentReasonCode Cap = new(Values.Cap);

    /// <summary>
    /// Rebate
    /// </summary>
    public static readonly AdjustmentReasonCode Cb2 = new(Values.Cb2);

    /// <summary>
    /// Recovery Allowance
    /// </summary>
    public static readonly AdjustmentReasonCode Cb3 = new(Values.Cb3);

    /// <summary>
    /// Bad Debt Adjustment
    /// </summary>
    public static readonly AdjustmentReasonCode Cbd = new(Values.Cbd);

    /// <summary>
    /// Bonus
    /// </summary>
    public static readonly AdjustmentReasonCode Cbn = new(Values.Cbn);

    /// <summary>
    /// Temporary Allowance
    /// </summary>
    public static readonly AdjustmentReasonCode Cc5 = new(Values.Cc5);

    /// <summary>
    /// Capitation Interest
    /// </summary>
    public static readonly AdjustmentReasonCode Ccr = new(Values.Ccr);

    /// <summary>
    /// Adjustment
    /// </summary>
    public static readonly AdjustmentReasonCode Ccs = new(Values.Ccs);

    /// <summary>
    /// Capitation Payment
    /// </summary>
    public static readonly AdjustmentReasonCode Cct = new(Values.Cct);

    /// <summary>
    /// Capital Passthru
    /// </summary>
    public static readonly AdjustmentReasonCode Ccv = new(Values.Ccv);

    /// <summary>
    /// Certified Registered Nurse Anesthetist Passthru
    /// </summary>
    public static readonly AdjustmentReasonCode Ccw = new(Values.Ccw);

    /// <summary>
    /// Withholding
    /// </summary>
    public static readonly AdjustmentReasonCode Ce3 = new(Values.Ce3);

    /// <summary>
    /// Forwarding Balance
    /// </summary>
    public static readonly AdjustmentReasonCode Cfb = new(Values.Cfb);

    /// <summary>
    /// Fund Allocation
    /// </summary>
    public static readonly AdjustmentReasonCode Cfc = new(Values.Cfc);

    /// <summary>
    /// Graduate Medical Education Passthru
    /// </summary>
    public static readonly AdjustmentReasonCode Cgo = new(Values.Cgo);

    /// <summary>
    /// Hemophilia Clotting Factor Supplement
    /// </summary>
    public static readonly AdjustmentReasonCode Chm = new(Values.Chm);

    /// <summary>
    /// Incentive Premium Payment
    /// </summary>
    public static readonly AdjustmentReasonCode Cip = new(Values.Cip);

    /// <summary>
    /// Internal Revenue Service Withholding
    /// </summary>
    public static readonly AdjustmentReasonCode Cir = new(Values.Cir);

    /// <summary>
    /// Interim Settlement
    /// </summary>
    public static readonly AdjustmentReasonCode Cis = new(Values.Cis);

    /// <summary>
    /// Nonreimbursable
    /// </summary>
    public static readonly AdjustmentReasonCode Cj1 = new(Values.Cj1);

    /// <summary>
    /// Penalty
    /// </summary>
    public static readonly AdjustmentReasonCode Cl3 = new(Values.Cl3);

    /// <summary>
    /// Interest Owed
    /// </summary>
    public static readonly AdjustmentReasonCode Cl6 = new(Values.Cl6);

    /// <summary>
    /// Levy
    /// </summary>
    public static readonly AdjustmentReasonCode Cle = new(Values.Cle);

    /// <summary>
    /// Lump Sum
    /// </summary>
    public static readonly AdjustmentReasonCode Cls = new(Values.Cls);

    /// <summary>
    /// Organ Acquisition Passthru
    /// </summary>
    public static readonly AdjustmentReasonCode Coa = new(Values.Coa);

    /// <summary>
    /// Offset for Affiliated Providers
    /// </summary>
    public static readonly AdjustmentReasonCode Cob = new(Values.Cob);

    /// <summary>
    /// Periodic Interim Payment
    /// </summary>
    public static readonly AdjustmentReasonCode Cpi = new(Values.Cpi);

    /// <summary>
    /// Payment Final
    /// </summary>
    public static readonly AdjustmentReasonCode Cpl = new(Values.Cpl);

    /// <summary>
    /// Retro-activity Adjustment
    /// </summary>
    public static readonly AdjustmentReasonCode Cra = new(Values.Cra);

    /// <summary>
    /// Return on Equity
    /// </summary>
    public static readonly AdjustmentReasonCode Cre = new(Values.Cre);

    /// <summary>
    /// Student Loan Repayment
    /// </summary>
    public static readonly AdjustmentReasonCode Csl = new(Values.Csl);

    /// <summary>
    /// Third Party Liability
    /// </summary>
    public static readonly AdjustmentReasonCode Ctl = new(Values.Ctl);

    /// <summary>
    /// Overpayment Recovery
    /// </summary>
    public static readonly AdjustmentReasonCode Cwo = new(Values.Cwo);

    /// <summary>
    /// Unspecified Recovery
    /// </summary>
    public static readonly AdjustmentReasonCode Cwu = new(Values.Cwu);

    public AdjustmentReasonCode(string value)
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
    public static AdjustmentReasonCode FromCustom(string value)
    {
        return new AdjustmentReasonCode(value);
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

    public static bool operator ==(AdjustmentReasonCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AdjustmentReasonCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AdjustmentReasonCode value) => value.Value;

    public static explicit operator AdjustmentReasonCode(string value) => new(value);

    internal class AdjustmentReasonCodeSerializer : JsonConverter<AdjustmentReasonCode>
    {
        public override AdjustmentReasonCode Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new AdjustmentReasonCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AdjustmentReasonCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AdjustmentReasonCode ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new AdjustmentReasonCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AdjustmentReasonCode value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Late Charge
        /// </summary>
        public const string C50 = "50";

        /// <summary>
        /// Interest Penalty Charge
        /// </summary>
        public const string C51 = "51";

        /// <summary>
        /// Authorized Return
        /// </summary>
        public const string C72 = "72";

        /// <summary>
        /// Early Payment Allowance
        /// </summary>
        public const string C90 = "90";

        /// <summary>
        /// Origination Fee
        /// </summary>
        public const string Cah = "AH";

        /// <summary>
        /// Applied to Borrower's Account
        /// </summary>
        public const string Cam = "AM";

        /// <summary>
        /// Acceleration of Benefits
        /// </summary>
        public const string Cap = "AP";

        /// <summary>
        /// Rebate
        /// </summary>
        public const string Cb2 = "B2";

        /// <summary>
        /// Recovery Allowance
        /// </summary>
        public const string Cb3 = "B3";

        /// <summary>
        /// Bad Debt Adjustment
        /// </summary>
        public const string Cbd = "BD";

        /// <summary>
        /// Bonus
        /// </summary>
        public const string Cbn = "BN";

        /// <summary>
        /// Temporary Allowance
        /// </summary>
        public const string Cc5 = "C5";

        /// <summary>
        /// Capitation Interest
        /// </summary>
        public const string Ccr = "CR";

        /// <summary>
        /// Adjustment
        /// </summary>
        public const string Ccs = "CS";

        /// <summary>
        /// Capitation Payment
        /// </summary>
        public const string Cct = "CT";

        /// <summary>
        /// Capital Passthru
        /// </summary>
        public const string Ccv = "CV";

        /// <summary>
        /// Certified Registered Nurse Anesthetist Passthru
        /// </summary>
        public const string Ccw = "CW";

        /// <summary>
        /// Withholding
        /// </summary>
        public const string Ce3 = "E3";

        /// <summary>
        /// Forwarding Balance
        /// </summary>
        public const string Cfb = "FB";

        /// <summary>
        /// Fund Allocation
        /// </summary>
        public const string Cfc = "FC";

        /// <summary>
        /// Graduate Medical Education Passthru
        /// </summary>
        public const string Cgo = "GO";

        /// <summary>
        /// Hemophilia Clotting Factor Supplement
        /// </summary>
        public const string Chm = "HM";

        /// <summary>
        /// Incentive Premium Payment
        /// </summary>
        public const string Cip = "IP";

        /// <summary>
        /// Internal Revenue Service Withholding
        /// </summary>
        public const string Cir = "IR";

        /// <summary>
        /// Interim Settlement
        /// </summary>
        public const string Cis = "IS";

        /// <summary>
        /// Nonreimbursable
        /// </summary>
        public const string Cj1 = "J1";

        /// <summary>
        /// Penalty
        /// </summary>
        public const string Cl3 = "L3";

        /// <summary>
        /// Interest Owed
        /// </summary>
        public const string Cl6 = "L6";

        /// <summary>
        /// Levy
        /// </summary>
        public const string Cle = "LE";

        /// <summary>
        /// Lump Sum
        /// </summary>
        public const string Cls = "LS";

        /// <summary>
        /// Organ Acquisition Passthru
        /// </summary>
        public const string Coa = "OA";

        /// <summary>
        /// Offset for Affiliated Providers
        /// </summary>
        public const string Cob = "OB";

        /// <summary>
        /// Periodic Interim Payment
        /// </summary>
        public const string Cpi = "PI";

        /// <summary>
        /// Payment Final
        /// </summary>
        public const string Cpl = "PL";

        /// <summary>
        /// Retro-activity Adjustment
        /// </summary>
        public const string Cra = "RA";

        /// <summary>
        /// Return on Equity
        /// </summary>
        public const string Cre = "RE";

        /// <summary>
        /// Student Loan Repayment
        /// </summary>
        public const string Csl = "SL";

        /// <summary>
        /// Third Party Liability
        /// </summary>
        public const string Ctl = "TL";

        /// <summary>
        /// Overpayment Recovery
        /// </summary>
        public const string Cwo = "WO";

        /// <summary>
        /// Unspecified Recovery
        /// </summary>
        public const string Cwu = "WU";
    }
}
