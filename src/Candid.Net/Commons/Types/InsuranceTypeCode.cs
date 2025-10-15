using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<InsuranceTypeCode>))]
[Serializable]
public readonly record struct InsuranceTypeCode : IStringEnum
{
    /// <summary>
    /// Short Term Insurance
    /// </summary>
    public static readonly InsuranceTypeCode C01 = new(Values.C01);

    /// <summary>
    /// Medicare Secondary Working Aged Beneficiary or Spouse with Employer Group Health Plan
    /// </summary>
    public static readonly InsuranceTypeCode C12 = new(Values.C12);

    /// <summary>
    /// Medicare Secondary End-Stage Renal Disease Beneficiary in the Mandated Coordination Period with an Employer's Group Health Plan
    /// </summary>
    public static readonly InsuranceTypeCode C13 = new(Values.C13);

    /// <summary>
    /// Medicare Secondary, No-fault Insurance including Auto is Primary
    /// </summary>
    public static readonly InsuranceTypeCode C14 = new(Values.C14);

    /// <summary>
    /// Medicare Secondary Worker's Compensation
    /// </summary>
    public static readonly InsuranceTypeCode C15 = new(Values.C15);

    /// <summary>
    /// Medicare Secondary Public Health Service (PHS) or Other Federal Agency
    /// </summary>
    public static readonly InsuranceTypeCode C16 = new(Values.C16);

    /// <summary>
    /// Dental
    /// </summary>
    public static readonly InsuranceTypeCode C17 = new(Values.C17);

    /// <summary>
    /// Vision
    /// </summary>
    public static readonly InsuranceTypeCode C18 = new(Values.C18);

    /// <summary>
    /// Prescription Drugs
    /// </summary>
    public static readonly InsuranceTypeCode C19 = new(Values.C19);

    /// <summary>
    /// Medicare Secondary Black Lung
    /// </summary>
    public static readonly InsuranceTypeCode C41 = new(Values.C41);

    /// <summary>
    /// Medicare Secondary Veteran's Administration
    /// </summary>
    public static readonly InsuranceTypeCode C42 = new(Values.C42);

    /// <summary>
    /// Medicare Secondary Disabled Beneficiary Under Age 65 with Large Group Health Plan (LGHP)
    /// </summary>
    public static readonly InsuranceTypeCode C43 = new(Values.C43);

    /// <summary>
    /// Medicare Secondary, Other Liability Insurance is Primary
    /// </summary>
    public static readonly InsuranceTypeCode C47 = new(Values.C47);

    /// <summary>
    /// Auto Insurance Policy
    /// </summary>
    public static readonly InsuranceTypeCode Cap = new(Values.Cap);

    /// <summary>
    /// Commercial
    /// </summary>
    public static readonly InsuranceTypeCode Cc1 = new(Values.Cc1);

    /// <summary>
    /// Consolidated Omnibus Budget Reconciliation Act (COBRA)
    /// </summary>
    public static readonly InsuranceTypeCode Cco = new(Values.Cco);

    /// <summary>
    /// Medicare Conditionally Primary
    /// </summary>
    public static readonly InsuranceTypeCode Ccp = new(Values.Ccp);

    /// <summary>
    /// Disability - Provides periodic payments to replace income when an insured person is unable to work as a result of illness, injury or disease
    /// </summary>
    public static readonly InsuranceTypeCode Cd = new(Values.Cd);

    /// <summary>
    /// Disability Benefits
    /// </summary>
    public static readonly InsuranceTypeCode Cdb = new(Values.Cdb);

    /// <summary>
    /// Medicare - Point of Service (POS)
    /// </summary>
    public static readonly InsuranceTypeCode Ce = new(Values.Ce);

    /// <summary>
    /// Exclusive Provider Organization - Gives subscriber a choice of providers from an approved/contracted payer list; there are fixed dollar co-payments for most covered services in return for using plan providers
    /// </summary>
    public static readonly InsuranceTypeCode Cep = new(Values.Cep);

    /// <summary>
    /// Family or Friends
    /// </summary>
    public static readonly InsuranceTypeCode Cff = new(Values.Cff);

    /// <summary>
    /// Group Policy - Two or more people who are part of complete unit who enter into an insurance contract with an insurance company
    /// </summary>
    public static readonly InsuranceTypeCode Cgp = new(Values.Cgp);

    /// <summary>
    /// Health Insurance Exchange (HIX) Silver
    /// </summary>
    public static readonly InsuranceTypeCode Cha = new(Values.Cha);

    /// <summary>
    /// Health Insurance Exchange (HIX) Bronze
    /// </summary>
    public static readonly InsuranceTypeCode Chb = new(Values.Chb);

    /// <summary>
    /// High Deductible Health Plan
    /// </summary>
    public static readonly InsuranceTypeCode Chd = new(Values.Chd);

    /// <summary>
    /// Health Insurance Exchange (HIX) Gold
    /// </summary>
    public static readonly InsuranceTypeCode Chg = new(Values.Chg);

    /// <summary>
    /// Health Maintenance Organization (HMO)
    /// </summary>
    public static readonly InsuranceTypeCode Chm = new(Values.Chm);

    /// <summary>
    /// Health Maintenance Organization (HMO) - Medicare Risk
    /// </summary>
    public static readonly InsuranceTypeCode Chn = new(Values.Chn);

    /// <summary>
    /// Health Insurance Exchange (HIX) Platinum
    /// </summary>
    public static readonly InsuranceTypeCode Chp = new(Values.Chp);

    /// <summary>
    /// Special Low Income Medicare Beneficiary - An individual eligible for Medicare for whom Medicaid pays only Medicare premiums
    /// </summary>
    public static readonly InsuranceTypeCode Chs = new(Values.Chs);

    /// <summary>
    /// Indemnity - Gives a subscriber the choice to select any provider.  Payment is fixed percentage of the cost for covered care after satisfying an annual deductible
    /// </summary>
    public static readonly InsuranceTypeCode Cin = new(Values.Cin);

    /// <summary>
    /// Individual Policy
    /// </summary>
    public static readonly InsuranceTypeCode Cip = new(Values.Cip);

    /// <summary>
    /// Long Term Care - Coverage designed to help pay for some or all long term care costs, reducing the risk that a policy-holder would need to deplete all of his or her assets to pay for long term care
    /// </summary>
    public static readonly InsuranceTypeCode Clc = new(Values.Clc);

    /// <summary>
    /// Long Term Policy
    /// </summary>
    public static readonly InsuranceTypeCode Cld = new(Values.Cld);

    /// <summary>
    /// Life Insurance
    /// </summary>
    public static readonly InsuranceTypeCode Cli = new(Values.Cli);

    /// <summary>
    /// Litigation
    /// </summary>
    public static readonly InsuranceTypeCode Clt = new(Values.Clt);

    /// <summary>
    /// Medicare Advantage Point of Service (POS) Plan that excludes Part D coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cm = new(Values.Cm);

    /// <summary>
    /// Medicare Part A
    /// </summary>
    public static readonly InsuranceTypeCode Cma = new(Values.Cma);

    /// <summary>
    /// Medicare Part B
    /// </summary>
    public static readonly InsuranceTypeCode Cmb = new(Values.Cmb);

    /// <summary>
    /// Medicaid - Program of health care services made available to medically indigent and other needy persons, regardless of age, under terms of a 1965 amendment to the U.S. Social Security Act
    /// </summary>
    public static readonly InsuranceTypeCode Cmc = new(Values.Cmc);

    /// <summary>
    /// Medicare Part D
    /// </summary>
    public static readonly InsuranceTypeCode Cmd = new(Values.Cmd);

    /// <summary>
    /// Medicare Advantage Preferred Provider Organization (PPO) Plan that excludes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cme = new(Values.Cme);

    /// <summary>
    /// Medicare Advantage Private Fee for Service
    /// </summary>
    public static readonly InsuranceTypeCode Cmf = new(Values.Cmf);

    /// <summary>
    /// Medigap Part A - Health insurance policy intended to cover the non-covered portion of expenses eligible for Medicare Part A reimbursement which must be paid by a Medicare beneficiary for health care services and/or supplies received
    /// </summary>
    public static readonly InsuranceTypeCode Cmh = new(Values.Cmh);

    /// <summary>
    /// Medigap Part B - Health insurance policy intended to cover the non-covered portion of expenses eligible for Medicare Part B reimbursement which must be paid by a Medicare beneficiary for health care services and/or supplies received
    /// </summary>
    public static readonly InsuranceTypeCode Cmi = new(Values.Cmi);

    /// <summary>
    /// Medicare Advantage Health Maintenance Organization (HMO) Plan that includes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmj = new(Values.Cmj);

    /// <summary>
    /// Medicare Advantage Health Maintenance Organization (HMO) Risk Plan that includes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmk = new(Values.Cmk);

    /// <summary>
    /// Medicare Advantage Indemnity Plan that includes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cml = new(Values.Cml);

    /// <summary>
    /// Medicare Advantage Preferred Provider Organization (PPO) Plan that includes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmm = new(Values.Cmm);

    /// <summary>
    /// Medicare Advantage Indemnity Plan that excludes Part D coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmn = new(Values.Cmn);

    /// <summary>
    /// Medicare Advantage Point of Service (POS) Plan that includes Part D Coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmo = new(Values.Cmo);

    /// <summary>
    /// Medicare Primary - Medicare has the primary responsibility to pay for health care services and/or supplies received by a covered beneficiary (a person entitled to Medicare benefits)
    /// </summary>
    public static readonly InsuranceTypeCode Cmp = new(Values.Cmp);

    /// <summary>
    /// Medicare Advantage Health Maintenance Organization (HMO) Risk Plan that excludes Part D coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmr = new(Values.Cmr);

    /// <summary>
    /// Medicare Advantage Health Maintenance Organization (HMO) Plan that excludes Part D coverage
    /// </summary>
    public static readonly InsuranceTypeCode Cmt = new(Values.Cmt);

    /// <summary>
    /// Medicare Advantage
    /// </summary>
    public static readonly InsuranceTypeCode Cmv = new(Values.Cmv);

    /// <summary>
    /// Open Access Point of Service Plan
    /// </summary>
    public static readonly InsuranceTypeCode Coa = new(Values.Coa);

    /// <summary>
    /// Other
    /// </summary>
    public static readonly InsuranceTypeCode Cot = new(Values.Cot);

    /// <summary>
    /// Property Insurance - Personal
    /// </summary>
    public static readonly InsuranceTypeCode Cpe = new(Values.Cpe);

    /// <summary>
    /// Personal
    /// </summary>
    public static readonly InsuranceTypeCode Cpl = new(Values.Cpl);

    /// <summary>
    /// Personal Payment (Cash - No Insurance)
    /// </summary>
    public static readonly InsuranceTypeCode Cpp = new(Values.Cpp);

    /// <summary>
    /// Preferred Provider Organization (PPO)
    /// </summary>
    public static readonly InsuranceTypeCode Cpr = new(Values.Cpr);

    /// <summary>
    /// Point of Service (POS)
    /// </summary>
    public static readonly InsuranceTypeCode Cps = new(Values.Cps);

    /// <summary>
    /// Qualified Medicare Beneficiary - Coverage for a Medicare eligible individual for whom Medicaid pays only for Medicare premiums, co-insurance, and deductibles
    /// </summary>
    public static readonly InsuranceTypeCode Cqm = new(Values.Cqm);

    /// <summary>
    /// Property Insurance - Real
    /// </summary>
    public static readonly InsuranceTypeCode Crp = new(Values.Crp);

    /// <summary>
    /// Supplemental Policy - An insurance policy intended to cover non-covered charges of another insurance policy
    /// </summary>
    public static readonly InsuranceTypeCode Csp = new(Values.Csp);

    /// <summary>
    /// Tax Equity Fiscal Responsibility Act (TEFRA)
    /// </summary>
    public static readonly InsuranceTypeCode Ctf = new(Values.Ctf);

    /// <summary>
    /// Multiple Options Health Plan
    /// </summary>
    public static readonly InsuranceTypeCode Cu = new(Values.Cu);

    /// <summary>
    /// Workers Compensation - Coverage provides medical treatment, rehabilitation, lost wages and related expenses arising from a job related injury or disease
    /// </summary>
    public static readonly InsuranceTypeCode Cwc = new(Values.Cwc);

    /// <summary>
    /// Wrap Up Policy - A Workers Compensation Policy written for a specific job site, which will include or cover more than one insured
    /// </summary>
    public static readonly InsuranceTypeCode Cwu = new(Values.Cwu);

    public InsuranceTypeCode(string value)
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
    public static InsuranceTypeCode FromCustom(string value)
    {
        return new InsuranceTypeCode(value);
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

    public static bool operator ==(InsuranceTypeCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceTypeCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceTypeCode value) => value.Value;

    public static explicit operator InsuranceTypeCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Short Term Insurance
        /// </summary>
        public const string C01 = "01";

        /// <summary>
        /// Medicare Secondary Working Aged Beneficiary or Spouse with Employer Group Health Plan
        /// </summary>
        public const string C12 = "12";

        /// <summary>
        /// Medicare Secondary End-Stage Renal Disease Beneficiary in the Mandated Coordination Period with an Employer's Group Health Plan
        /// </summary>
        public const string C13 = "13";

        /// <summary>
        /// Medicare Secondary, No-fault Insurance including Auto is Primary
        /// </summary>
        public const string C14 = "14";

        /// <summary>
        /// Medicare Secondary Worker's Compensation
        /// </summary>
        public const string C15 = "15";

        /// <summary>
        /// Medicare Secondary Public Health Service (PHS) or Other Federal Agency
        /// </summary>
        public const string C16 = "16";

        /// <summary>
        /// Dental
        /// </summary>
        public const string C17 = "17";

        /// <summary>
        /// Vision
        /// </summary>
        public const string C18 = "18";

        /// <summary>
        /// Prescription Drugs
        /// </summary>
        public const string C19 = "19";

        /// <summary>
        /// Medicare Secondary Black Lung
        /// </summary>
        public const string C41 = "41";

        /// <summary>
        /// Medicare Secondary Veteran's Administration
        /// </summary>
        public const string C42 = "42";

        /// <summary>
        /// Medicare Secondary Disabled Beneficiary Under Age 65 with Large Group Health Plan (LGHP)
        /// </summary>
        public const string C43 = "43";

        /// <summary>
        /// Medicare Secondary, Other Liability Insurance is Primary
        /// </summary>
        public const string C47 = "47";

        /// <summary>
        /// Auto Insurance Policy
        /// </summary>
        public const string Cap = "AP";

        /// <summary>
        /// Commercial
        /// </summary>
        public const string Cc1 = "C1";

        /// <summary>
        /// Consolidated Omnibus Budget Reconciliation Act (COBRA)
        /// </summary>
        public const string Cco = "CO";

        /// <summary>
        /// Medicare Conditionally Primary
        /// </summary>
        public const string Ccp = "CP";

        /// <summary>
        /// Disability - Provides periodic payments to replace income when an insured person is unable to work as a result of illness, injury or disease
        /// </summary>
        public const string Cd = "D";

        /// <summary>
        /// Disability Benefits
        /// </summary>
        public const string Cdb = "DB";

        /// <summary>
        /// Medicare - Point of Service (POS)
        /// </summary>
        public const string Ce = "E";

        /// <summary>
        /// Exclusive Provider Organization - Gives subscriber a choice of providers from an approved/contracted payer list; there are fixed dollar co-payments for most covered services in return for using plan providers
        /// </summary>
        public const string Cep = "EP";

        /// <summary>
        /// Family or Friends
        /// </summary>
        public const string Cff = "FF";

        /// <summary>
        /// Group Policy - Two or more people who are part of complete unit who enter into an insurance contract with an insurance company
        /// </summary>
        public const string Cgp = "GP";

        /// <summary>
        /// Health Insurance Exchange (HIX) Silver
        /// </summary>
        public const string Cha = "HA";

        /// <summary>
        /// Health Insurance Exchange (HIX) Bronze
        /// </summary>
        public const string Chb = "HB";

        /// <summary>
        /// High Deductible Health Plan
        /// </summary>
        public const string Chd = "HD";

        /// <summary>
        /// Health Insurance Exchange (HIX) Gold
        /// </summary>
        public const string Chg = "HG";

        /// <summary>
        /// Health Maintenance Organization (HMO)
        /// </summary>
        public const string Chm = "HM";

        /// <summary>
        /// Health Maintenance Organization (HMO) - Medicare Risk
        /// </summary>
        public const string Chn = "HN";

        /// <summary>
        /// Health Insurance Exchange (HIX) Platinum
        /// </summary>
        public const string Chp = "HP";

        /// <summary>
        /// Special Low Income Medicare Beneficiary - An individual eligible for Medicare for whom Medicaid pays only Medicare premiums
        /// </summary>
        public const string Chs = "HS";

        /// <summary>
        /// Indemnity - Gives a subscriber the choice to select any provider.  Payment is fixed percentage of the cost for covered care after satisfying an annual deductible
        /// </summary>
        public const string Cin = "IN";

        /// <summary>
        /// Individual Policy
        /// </summary>
        public const string Cip = "IP";

        /// <summary>
        /// Long Term Care - Coverage designed to help pay for some or all long term care costs, reducing the risk that a policy-holder would need to deplete all of his or her assets to pay for long term care
        /// </summary>
        public const string Clc = "LC";

        /// <summary>
        /// Long Term Policy
        /// </summary>
        public const string Cld = "LD";

        /// <summary>
        /// Life Insurance
        /// </summary>
        public const string Cli = "LI";

        /// <summary>
        /// Litigation
        /// </summary>
        public const string Clt = "LT";

        /// <summary>
        /// Medicare Advantage Point of Service (POS) Plan that excludes Part D coverage
        /// </summary>
        public const string Cm = "M";

        /// <summary>
        /// Medicare Part A
        /// </summary>
        public const string Cma = "MA";

        /// <summary>
        /// Medicare Part B
        /// </summary>
        public const string Cmb = "MB";

        /// <summary>
        /// Medicaid - Program of health care services made available to medically indigent and other needy persons, regardless of age, under terms of a 1965 amendment to the U.S. Social Security Act
        /// </summary>
        public const string Cmc = "MC";

        /// <summary>
        /// Medicare Part D
        /// </summary>
        public const string Cmd = "MD";

        /// <summary>
        /// Medicare Advantage Preferred Provider Organization (PPO) Plan that excludes Part D Coverage
        /// </summary>
        public const string Cme = "ME";

        /// <summary>
        /// Medicare Advantage Private Fee for Service
        /// </summary>
        public const string Cmf = "MF";

        /// <summary>
        /// Medigap Part A - Health insurance policy intended to cover the non-covered portion of expenses eligible for Medicare Part A reimbursement which must be paid by a Medicare beneficiary for health care services and/or supplies received
        /// </summary>
        public const string Cmh = "MH";

        /// <summary>
        /// Medigap Part B - Health insurance policy intended to cover the non-covered portion of expenses eligible for Medicare Part B reimbursement which must be paid by a Medicare beneficiary for health care services and/or supplies received
        /// </summary>
        public const string Cmi = "MI";

        /// <summary>
        /// Medicare Advantage Health Maintenance Organization (HMO) Plan that includes Part D Coverage
        /// </summary>
        public const string Cmj = "MJ";

        /// <summary>
        /// Medicare Advantage Health Maintenance Organization (HMO) Risk Plan that includes Part D Coverage
        /// </summary>
        public const string Cmk = "MK";

        /// <summary>
        /// Medicare Advantage Indemnity Plan that includes Part D Coverage
        /// </summary>
        public const string Cml = "ML";

        /// <summary>
        /// Medicare Advantage Preferred Provider Organization (PPO) Plan that includes Part D Coverage
        /// </summary>
        public const string Cmm = "MM";

        /// <summary>
        /// Medicare Advantage Indemnity Plan that excludes Part D coverage
        /// </summary>
        public const string Cmn = "MN";

        /// <summary>
        /// Medicare Advantage Point of Service (POS) Plan that includes Part D Coverage
        /// </summary>
        public const string Cmo = "MO";

        /// <summary>
        /// Medicare Primary - Medicare has the primary responsibility to pay for health care services and/or supplies received by a covered beneficiary (a person entitled to Medicare benefits)
        /// </summary>
        public const string Cmp = "MP";

        /// <summary>
        /// Medicare Advantage Health Maintenance Organization (HMO) Risk Plan that excludes Part D coverage
        /// </summary>
        public const string Cmr = "MR";

        /// <summary>
        /// Medicare Advantage Health Maintenance Organization (HMO) Plan that excludes Part D coverage
        /// </summary>
        public const string Cmt = "MT";

        /// <summary>
        /// Medicare Advantage
        /// </summary>
        public const string Cmv = "MV";

        /// <summary>
        /// Open Access Point of Service Plan
        /// </summary>
        public const string Coa = "OA";

        /// <summary>
        /// Other
        /// </summary>
        public const string Cot = "OT";

        /// <summary>
        /// Property Insurance - Personal
        /// </summary>
        public const string Cpe = "PE";

        /// <summary>
        /// Personal
        /// </summary>
        public const string Cpl = "PL";

        /// <summary>
        /// Personal Payment (Cash - No Insurance)
        /// </summary>
        public const string Cpp = "PP";

        /// <summary>
        /// Preferred Provider Organization (PPO)
        /// </summary>
        public const string Cpr = "PR";

        /// <summary>
        /// Point of Service (POS)
        /// </summary>
        public const string Cps = "PS";

        /// <summary>
        /// Qualified Medicare Beneficiary - Coverage for a Medicare eligible individual for whom Medicaid pays only for Medicare premiums, co-insurance, and deductibles
        /// </summary>
        public const string Cqm = "QM";

        /// <summary>
        /// Property Insurance - Real
        /// </summary>
        public const string Crp = "RP";

        /// <summary>
        /// Supplemental Policy - An insurance policy intended to cover non-covered charges of another insurance policy
        /// </summary>
        public const string Csp = "SP";

        /// <summary>
        /// Tax Equity Fiscal Responsibility Act (TEFRA)
        /// </summary>
        public const string Ctf = "TF";

        /// <summary>
        /// Multiple Options Health Plan
        /// </summary>
        public const string Cu = "U";

        /// <summary>
        /// Workers Compensation - Coverage provides medical treatment, rehabilitation, lost wages and related expenses arising from a job related injury or disease
        /// </summary>
        public const string Cwc = "WC";

        /// <summary>
        /// Wrap Up Policy - A Workers Compensation Policy written for a specific job site, which will include or cover more than one insured
        /// </summary>
        public const string Cwu = "WU";
    }
}
