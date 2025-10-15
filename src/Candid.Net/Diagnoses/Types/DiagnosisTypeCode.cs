using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Diagnoses;

[JsonConverter(typeof(StringEnumSerializer<DiagnosisTypeCode>))]
[Serializable]
public readonly record struct DiagnosisTypeCode : IStringEnum
{
    /// <summary>
    /// ICD-10 Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Abf = new(Values.Abf);

    /// <summary>
    /// ICD-10 Admitting Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Abj = new(Values.Abj);

    /// <summary>
    /// ICD-10 Principal Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Abk = new(Values.Abk);

    /// <summary>
    /// ICD-10 Patient Reason for Visit
    /// </summary>
    public static readonly DiagnosisTypeCode Apr = new(Values.Apr);

    /// <summary>
    /// ICD-9 Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Bf = new(Values.Bf);

    /// <summary>
    /// ICD-9 Admitting Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Bj = new(Values.Bj);

    /// <summary>
    /// ICD-9 Principal Diagnosis
    /// </summary>
    public static readonly DiagnosisTypeCode Bk = new(Values.Bk);

    /// <summary>
    /// ICD-9 Patient Reason for Visit
    /// </summary>
    public static readonly DiagnosisTypeCode Pr = new(Values.Pr);

    /// <summary>
    /// Diagnosis Related Group (DRG)
    /// </summary>
    public static readonly DiagnosisTypeCode Dr = new(Values.Dr);

    /// <summary>
    /// Logical Observation Identifier Names and Codes (LOINC&lt;190&gt;) Codes
    /// </summary>
    public static readonly DiagnosisTypeCode Loi = new(Values.Loi);

    public DiagnosisTypeCode(string value)
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
    public static DiagnosisTypeCode FromCustom(string value)
    {
        return new DiagnosisTypeCode(value);
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

    public static bool operator ==(DiagnosisTypeCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DiagnosisTypeCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DiagnosisTypeCode value) => value.Value;

    public static explicit operator DiagnosisTypeCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// ICD-10 Diagnosis
        /// </summary>
        public const string Abf = "ABF";

        /// <summary>
        /// ICD-10 Admitting Diagnosis
        /// </summary>
        public const string Abj = "ABJ";

        /// <summary>
        /// ICD-10 Principal Diagnosis
        /// </summary>
        public const string Abk = "ABK";

        /// <summary>
        /// ICD-10 Patient Reason for Visit
        /// </summary>
        public const string Apr = "APR";

        /// <summary>
        /// ICD-9 Diagnosis
        /// </summary>
        public const string Bf = "BF";

        /// <summary>
        /// ICD-9 Admitting Diagnosis
        /// </summary>
        public const string Bj = "BJ";

        /// <summary>
        /// ICD-9 Principal Diagnosis
        /// </summary>
        public const string Bk = "BK";

        /// <summary>
        /// ICD-9 Patient Reason for Visit
        /// </summary>
        public const string Pr = "PR";

        /// <summary>
        /// Diagnosis Related Group (DRG)
        /// </summary>
        public const string Dr = "DR";

        /// <summary>
        /// Logical Observation Identifier Names and Codes (LOINC&lt;190&gt;) Codes
        /// </summary>
        public const string Loi = "LOI";
    }
}
