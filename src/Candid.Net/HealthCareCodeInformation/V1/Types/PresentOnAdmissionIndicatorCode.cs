using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(StringEnumSerializer<PresentOnAdmissionIndicatorCode>))]
[Serializable]
public readonly record struct PresentOnAdmissionIndicatorCode : IStringEnum
{
    /// <summary>
    /// PRESENT AT THE TIME OF INPATIENT ADMISSION
    /// </summary>
    public static readonly PresentOnAdmissionIndicatorCode Cy = new(Values.Cy);

    /// <summary>
    /// NOT PRESENT AT THE TIME OF INPATIENT ADMISSION
    /// </summary>
    public static readonly PresentOnAdmissionIndicatorCode Cn = new(Values.Cn);

    /// <summary>
    /// DOCUMENTATION IS INSUFFICIENT TO DETERMINE IF CONDITION IS PRESENT ON ADMISSION
    /// </summary>
    public static readonly PresentOnAdmissionIndicatorCode Cu = new(Values.Cu);

    /// <summary>
    /// PROVIDER IS UNABLE TO CLINICALLY DETERMINE WHETHER CONDITION WAS PRESENT ON ADMISSION OR NOT
    /// </summary>
    public static readonly PresentOnAdmissionIndicatorCode Cw = new(Values.Cw);

    /// <summary>
    /// EXEMPT FROM POA REPORTING ON UB-04 PAPER FORM ONLY; NOT FOR USE ON 837
    /// </summary>
    public static readonly PresentOnAdmissionIndicatorCode C1 = new(Values.C1);

    public PresentOnAdmissionIndicatorCode(string value)
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
    public static PresentOnAdmissionIndicatorCode FromCustom(string value)
    {
        return new PresentOnAdmissionIndicatorCode(value);
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

    public static bool operator ==(PresentOnAdmissionIndicatorCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PresentOnAdmissionIndicatorCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PresentOnAdmissionIndicatorCode value) => value.Value;

    public static explicit operator PresentOnAdmissionIndicatorCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// PRESENT AT THE TIME OF INPATIENT ADMISSION
        /// </summary>
        public const string Cy = "Y";

        /// <summary>
        /// NOT PRESENT AT THE TIME OF INPATIENT ADMISSION
        /// </summary>
        public const string Cn = "N";

        /// <summary>
        /// DOCUMENTATION IS INSUFFICIENT TO DETERMINE IF CONDITION IS PRESENT ON ADMISSION
        /// </summary>
        public const string Cu = "U";

        /// <summary>
        /// PROVIDER IS UNABLE TO CLINICALLY DETERMINE WHETHER CONDITION WAS PRESENT ON ADMISSION OR NOT
        /// </summary>
        public const string Cw = "W";

        /// <summary>
        /// EXEMPT FROM POA REPORTING ON UB-04 PAPER FORM ONLY; NOT FOR USE ON 837
        /// </summary>
        public const string C1 = "1";
    }
}
