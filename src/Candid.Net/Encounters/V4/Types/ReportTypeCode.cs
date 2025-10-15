using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<ReportTypeCode>))]
[Serializable]
public readonly record struct ReportTypeCode : IStringEnum
{
    /// <summary>
    /// Report Justifying Treatment Beyond Utilization Guidelines
    /// </summary>
    public static readonly ReportTypeCode C03 = new(Values.C03);

    /// <summary>
    /// Drugs Administered
    /// </summary>
    public static readonly ReportTypeCode C04 = new(Values.C04);

    /// <summary>
    /// Treatment Diagnosis
    /// </summary>
    public static readonly ReportTypeCode C05 = new(Values.C05);

    /// <summary>
    /// Initial Assessment
    /// </summary>
    public static readonly ReportTypeCode C06 = new(Values.C06);

    /// <summary>
    /// Functional Goals
    /// </summary>
    public static readonly ReportTypeCode C07 = new(Values.C07);

    /// <summary>
    /// Plan of Treatment
    /// </summary>
    public static readonly ReportTypeCode C08 = new(Values.C08);

    /// <summary>
    /// Progress Report
    /// </summary>
    public static readonly ReportTypeCode C09 = new(Values.C09);

    /// <summary>
    /// Continued Treatment
    /// </summary>
    public static readonly ReportTypeCode C10 = new(Values.C10);

    /// <summary>
    /// Chemical Analysis
    /// </summary>
    public static readonly ReportTypeCode C11 = new(Values.C11);

    /// <summary>
    /// Certified Test Report
    /// </summary>
    public static readonly ReportTypeCode C13 = new(Values.C13);

    /// <summary>
    /// Justification for Admission
    /// </summary>
    public static readonly ReportTypeCode C15 = new(Values.C15);

    /// <summary>
    /// Recovery Plan
    /// </summary>
    public static readonly ReportTypeCode C21 = new(Values.C21);

    /// <summary>
    /// Allergies/Sensitivities Document
    /// </summary>
    public static readonly ReportTypeCode Ca3 = new(Values.Ca3);

    /// <summary>
    /// Autopsy Report
    /// </summary>
    public static readonly ReportTypeCode Ca4 = new(Values.Ca4);

    /// <summary>
    /// Ambulance Certification
    /// </summary>
    public static readonly ReportTypeCode Cam = new(Values.Cam);

    /// <summary>
    /// Admission Summary
    /// </summary>
    public static readonly ReportTypeCode Cas = new(Values.Cas);

    /// <summary>
    /// Prescription
    /// </summary>
    public static readonly ReportTypeCode Cb2 = new(Values.Cb2);

    /// <summary>
    /// Physician Order
    /// </summary>
    public static readonly ReportTypeCode Cb3 = new(Values.Cb3);

    /// <summary>
    /// Referral Form
    /// </summary>
    public static readonly ReportTypeCode Cb4 = new(Values.Cb4);

    /// <summary>
    /// Benchmark Testing Results
    /// </summary>
    public static readonly ReportTypeCode Cbr = new(Values.Cbr);

    /// <summary>
    /// Baseline
    /// </summary>
    public static readonly ReportTypeCode Cbs = new(Values.Cbs);

    /// <summary>
    /// Blanket Test Results
    /// </summary>
    public static readonly ReportTypeCode Cbt = new(Values.Cbt);

    /// <summary>
    /// Chiropractic Justification
    /// </summary>
    public static readonly ReportTypeCode Ccb = new(Values.Ccb);

    /// <summary>
    /// Consent Form(s)
    /// </summary>
    public static readonly ReportTypeCode Cck = new(Values.Cck);

    /// <summary>
    /// Certification
    /// </summary>
    public static readonly ReportTypeCode Cct = new(Values.Cct);

    /// <summary>
    /// Drug Profile Document
    /// </summary>
    public static readonly ReportTypeCode Cd2 = new(Values.Cd2);

    /// <summary>
    /// Dental Models
    /// </summary>
    public static readonly ReportTypeCode Cda = new(Values.Cda);

    /// <summary>
    /// Durable Medical Equipment Prescription
    /// </summary>
    public static readonly ReportTypeCode Cdb = new(Values.Cdb);

    /// <summary>
    /// Diagnostic Report
    /// </summary>
    public static readonly ReportTypeCode Cdg = new(Values.Cdg);

    /// <summary>
    /// Discharge Monitoring Report
    /// </summary>
    public static readonly ReportTypeCode Cdj = new(Values.Cdj);

    /// <summary>
    /// Discharge Summary
    /// </summary>
    public static readonly ReportTypeCode Cds = new(Values.Cds);

    /// <summary>
    /// Explanation of Benefits (Coordination of Benefits or Medicare Secondary Payor)
    /// </summary>
    public static readonly ReportTypeCode Ceb = new(Values.Ceb);

    /// <summary>
    /// Health Certificate
    /// </summary>
    public static readonly ReportTypeCode Chc = new(Values.Chc);

    /// <summary>
    /// Health Clinic Records
    /// </summary>
    public static readonly ReportTypeCode Chr = new(Values.Chr);

    /// <summary>
    /// Immunization Record
    /// </summary>
    public static readonly ReportTypeCode Ci5 = new(Values.Ci5);

    /// <summary>
    /// State School Immunization Records
    /// </summary>
    public static readonly ReportTypeCode Cir = new(Values.Cir);

    /// <summary>
    /// Laboratory Results
    /// </summary>
    public static readonly ReportTypeCode Cla = new(Values.Cla);

    /// <summary>
    /// Medical Record Attachment
    /// </summary>
    public static readonly ReportTypeCode Cm1 = new(Values.Cm1);

    /// <summary>
    /// Models
    /// </summary>
    public static readonly ReportTypeCode Cmt = new(Values.Cmt);

    /// <summary>
    /// Nursing Notes
    /// </summary>
    public static readonly ReportTypeCode Cnn = new(Values.Cnn);

    /// <summary>
    /// Operative Note
    /// </summary>
    public static readonly ReportTypeCode Cob = new(Values.Cob);

    /// <summary>
    /// Oxygen Content Averaging Report
    /// </summary>
    public static readonly ReportTypeCode Coc = new(Values.Coc);

    /// <summary>
    /// Orders and Treatments Document
    /// </summary>
    public static readonly ReportTypeCode Cod = new(Values.Cod);

    /// <summary>
    /// Objective Physical Examination (including vital signs) Document
    /// </summary>
    public static readonly ReportTypeCode Coe = new(Values.Coe);

    /// <summary>
    /// Oxygen Therapy Certification
    /// </summary>
    public static readonly ReportTypeCode Cox = new(Values.Cox);

    /// <summary>
    /// Support Data for Claim
    /// </summary>
    public static readonly ReportTypeCode Coz = new(Values.Coz);

    /// <summary>
    /// Pathology Report
    /// </summary>
    public static readonly ReportTypeCode Cp4 = new(Values.Cp4);

    /// <summary>
    /// Patient Medical History Document
    /// </summary>
    public static readonly ReportTypeCode Cp5 = new(Values.Cp5);

    /// <summary>
    /// Parenteral or Enteral Certification
    /// </summary>
    public static readonly ReportTypeCode Cpe = new(Values.Cpe);

    /// <summary>
    /// Physical Therapy Notes
    /// </summary>
    public static readonly ReportTypeCode Cpn = new(Values.Cpn);

    /// <summary>
    /// Prosthetics or Orthotic Certification
    /// </summary>
    public static readonly ReportTypeCode Cpo = new(Values.Cpo);

    /// <summary>
    /// Paramedical Results
    /// </summary>
    public static readonly ReportTypeCode Cpq = new(Values.Cpq);

    /// <summary>
    /// Physician's Report
    /// </summary>
    public static readonly ReportTypeCode Cpy = new(Values.Cpy);

    /// <summary>
    /// Physical Therapy Certification
    /// </summary>
    public static readonly ReportTypeCode Cpz = new(Values.Cpz);

    /// <summary>
    /// Radiology Films
    /// </summary>
    public static readonly ReportTypeCode Crb = new(Values.Crb);

    /// <summary>
    /// Radiology Reports
    /// </summary>
    public static readonly ReportTypeCode Crr = new(Values.Crr);

    /// <summary>
    /// Report of Tests and Analysis Report
    /// </summary>
    public static readonly ReportTypeCode Crt = new(Values.Crt);

    /// <summary>
    /// Renewable Oxygen Content Averaging Report
    /// </summary>
    public static readonly ReportTypeCode Crx = new(Values.Crx);

    /// <summary>
    /// Symptoms Document
    /// </summary>
    public static readonly ReportTypeCode Csg = new(Values.Csg);

    /// <summary>
    /// Death Notification
    /// </summary>
    public static readonly ReportTypeCode Cv5 = new(Values.Cv5);

    /// <summary>
    /// Photographs
    /// </summary>
    public static readonly ReportTypeCode Cxp = new(Values.Cxp);

    public ReportTypeCode(string value)
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
    public static ReportTypeCode FromCustom(string value)
    {
        return new ReportTypeCode(value);
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

    public static bool operator ==(ReportTypeCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportTypeCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportTypeCode value) => value.Value;

    public static explicit operator ReportTypeCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Report Justifying Treatment Beyond Utilization Guidelines
        /// </summary>
        public const string C03 = "03";

        /// <summary>
        /// Drugs Administered
        /// </summary>
        public const string C04 = "04";

        /// <summary>
        /// Treatment Diagnosis
        /// </summary>
        public const string C05 = "05";

        /// <summary>
        /// Initial Assessment
        /// </summary>
        public const string C06 = "06";

        /// <summary>
        /// Functional Goals
        /// </summary>
        public const string C07 = "07";

        /// <summary>
        /// Plan of Treatment
        /// </summary>
        public const string C08 = "08";

        /// <summary>
        /// Progress Report
        /// </summary>
        public const string C09 = "09";

        /// <summary>
        /// Continued Treatment
        /// </summary>
        public const string C10 = "10";

        /// <summary>
        /// Chemical Analysis
        /// </summary>
        public const string C11 = "11";

        /// <summary>
        /// Certified Test Report
        /// </summary>
        public const string C13 = "13";

        /// <summary>
        /// Justification for Admission
        /// </summary>
        public const string C15 = "15";

        /// <summary>
        /// Recovery Plan
        /// </summary>
        public const string C21 = "21";

        /// <summary>
        /// Allergies/Sensitivities Document
        /// </summary>
        public const string Ca3 = "A3";

        /// <summary>
        /// Autopsy Report
        /// </summary>
        public const string Ca4 = "A4";

        /// <summary>
        /// Ambulance Certification
        /// </summary>
        public const string Cam = "AM";

        /// <summary>
        /// Admission Summary
        /// </summary>
        public const string Cas = "AS";

        /// <summary>
        /// Prescription
        /// </summary>
        public const string Cb2 = "B2";

        /// <summary>
        /// Physician Order
        /// </summary>
        public const string Cb3 = "B3";

        /// <summary>
        /// Referral Form
        /// </summary>
        public const string Cb4 = "B4";

        /// <summary>
        /// Benchmark Testing Results
        /// </summary>
        public const string Cbr = "BR";

        /// <summary>
        /// Baseline
        /// </summary>
        public const string Cbs = "BS";

        /// <summary>
        /// Blanket Test Results
        /// </summary>
        public const string Cbt = "BT";

        /// <summary>
        /// Chiropractic Justification
        /// </summary>
        public const string Ccb = "CB";

        /// <summary>
        /// Consent Form(s)
        /// </summary>
        public const string Cck = "CK";

        /// <summary>
        /// Certification
        /// </summary>
        public const string Cct = "CT";

        /// <summary>
        /// Drug Profile Document
        /// </summary>
        public const string Cd2 = "D2";

        /// <summary>
        /// Dental Models
        /// </summary>
        public const string Cda = "DA";

        /// <summary>
        /// Durable Medical Equipment Prescription
        /// </summary>
        public const string Cdb = "DB";

        /// <summary>
        /// Diagnostic Report
        /// </summary>
        public const string Cdg = "DG";

        /// <summary>
        /// Discharge Monitoring Report
        /// </summary>
        public const string Cdj = "DJ";

        /// <summary>
        /// Discharge Summary
        /// </summary>
        public const string Cds = "DS";

        /// <summary>
        /// Explanation of Benefits (Coordination of Benefits or Medicare Secondary Payor)
        /// </summary>
        public const string Ceb = "EB";

        /// <summary>
        /// Health Certificate
        /// </summary>
        public const string Chc = "HC";

        /// <summary>
        /// Health Clinic Records
        /// </summary>
        public const string Chr = "HR";

        /// <summary>
        /// Immunization Record
        /// </summary>
        public const string Ci5 = "I5";

        /// <summary>
        /// State School Immunization Records
        /// </summary>
        public const string Cir = "IR";

        /// <summary>
        /// Laboratory Results
        /// </summary>
        public const string Cla = "LA";

        /// <summary>
        /// Medical Record Attachment
        /// </summary>
        public const string Cm1 = "M1";

        /// <summary>
        /// Models
        /// </summary>
        public const string Cmt = "MT";

        /// <summary>
        /// Nursing Notes
        /// </summary>
        public const string Cnn = "NN";

        /// <summary>
        /// Operative Note
        /// </summary>
        public const string Cob = "OB";

        /// <summary>
        /// Oxygen Content Averaging Report
        /// </summary>
        public const string Coc = "OC";

        /// <summary>
        /// Orders and Treatments Document
        /// </summary>
        public const string Cod = "OD";

        /// <summary>
        /// Objective Physical Examination (including vital signs) Document
        /// </summary>
        public const string Coe = "OE";

        /// <summary>
        /// Oxygen Therapy Certification
        /// </summary>
        public const string Cox = "OX";

        /// <summary>
        /// Support Data for Claim
        /// </summary>
        public const string Coz = "OZ";

        /// <summary>
        /// Pathology Report
        /// </summary>
        public const string Cp4 = "P4";

        /// <summary>
        /// Patient Medical History Document
        /// </summary>
        public const string Cp5 = "P5";

        /// <summary>
        /// Parenteral or Enteral Certification
        /// </summary>
        public const string Cpe = "PE";

        /// <summary>
        /// Physical Therapy Notes
        /// </summary>
        public const string Cpn = "PN";

        /// <summary>
        /// Prosthetics or Orthotic Certification
        /// </summary>
        public const string Cpo = "PO";

        /// <summary>
        /// Paramedical Results
        /// </summary>
        public const string Cpq = "PQ";

        /// <summary>
        /// Physician's Report
        /// </summary>
        public const string Cpy = "PY";

        /// <summary>
        /// Physical Therapy Certification
        /// </summary>
        public const string Cpz = "PZ";

        /// <summary>
        /// Radiology Films
        /// </summary>
        public const string Crb = "RB";

        /// <summary>
        /// Radiology Reports
        /// </summary>
        public const string Crr = "RR";

        /// <summary>
        /// Report of Tests and Analysis Report
        /// </summary>
        public const string Crt = "RT";

        /// <summary>
        /// Renewable Oxygen Content Averaging Report
        /// </summary>
        public const string Crx = "RX";

        /// <summary>
        /// Symptoms Document
        /// </summary>
        public const string Csg = "SG";

        /// <summary>
        /// Death Notification
        /// </summary>
        public const string Cv5 = "V5";

        /// <summary>
        /// Photographs
        /// </summary>
        public const string Cxp = "XP";
    }
}
