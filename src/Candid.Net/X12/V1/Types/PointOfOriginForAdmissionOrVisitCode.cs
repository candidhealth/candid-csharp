using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<PointOfOriginForAdmissionOrVisitCode>))]
[Serializable]
public readonly record struct PointOfOriginForAdmissionOrVisitCode : IStringEnum
{
    /// <summary>
    /// NON-HEALTH CARE FACILITY POINT OF ORIGIN - Inpatient: The patient was admitted to this facility. Outpatient: The patient presented for outpatient services. Examples: Includes patients coming from home or workplace and patients receiving care at home (such as home health services).
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C1 = new(Values.C1);

    /// <summary>
    /// CLINIC OR PHYSICIAN'S OFFICE - Inpatient: The patient was admitted to this facility. Outpatient: The patient presented to this facility for outpatient services.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C2 = new(Values.C2);

    /// <summary>
    /// TRANSFER FROM A HOSPITAL (DIFFERENT FACILITY) - Inpatient: The patient was admitted to this facility as a hospital transfer from an acute care facility where he or she was an inpatient or outpatient. Outpatient: The patient was transferred to this facility as an outpatient from an acute care facility. Excludes Transfers from Hospital Inpatient in the Same Facility (See Code D).
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C4 = new(Values.C4);

    /// <summary>
    /// TRANSFER FROM A SKILLED NURSING FACILITY (SNF), ASSISTED LIVING FACILITY (ALF), INTERMEDIATE CARE FACILITY (ICF) OR OTHER NURSING FACILITY (NF). - Inpatient: The patient was admitted to this facility as a transfer from a SNF, ALF, ICF or other NF where he or she was a resident. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from a SNF, ALF, ICF or other NF where he or she was a resident.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C5 = new(Values.C5);

    /// <summary>
    /// TRANSFER FROM ANOTHER HEALTH CARE FACILITY - Inpatient: The patient was admitted to this facility as a transfer from another type of health care facility not defined elsewhere in this code list. Outpatient: The patient presented to this facility for services from another health care facility not defined elsewhere in this code list.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C6 = new(Values.C6);

    /// <summary>
    /// COURT/LAW ENFORCEMENT - Inpatient: The patient was admitted to this facility upon the direction of a court of law, or upon the request of a law enforcement agency representative. Outpatient: The patient presented to this facility upon the direction of a court of law, or upon the request of a law enforcement agency representative for outpatient or referenced diagnostic services. Usage Note: Includes transfers from incarceration facilities.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C8 = new(Values.C8);

    /// <summary>
    /// INFORMATION NOT AVAILABLE - Inpatient: The patient's Point of Origin is not known. Outpatient: The patient's Point of Origin is not known.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode C9 = new(Values.C9);

    /// <summary>
    /// TRANSFER FROM ONE DISTINCT UNIT OF THE HOSPITAL TO ANOTHER DISTINCT UNIT OF THE SAME HOSPITAL RESULTING IN A SEPARATE CLAIM TO THE PAYER - Inpatient: The patient was admitted to this facility as a transfer from hospital inpatient within this hospital resulting in a separate claim to the payer. Outpatient: The patient received outpatient services in this facility as a transfer from within this hospital resulting in a separate claim to the payer. Usage Note: For purposes of this code, "Distinct Unit" is defined as a unique unit or level of care at the hospital requiring the issuance of a separate claim to the payer. Examples could include observation services, psychiatric units, rehabilitation units, a unit in a critical access hospital, or a swing bed located in an acute hospital.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode Cd = new(Values.Cd);

    /// <summary>
    /// TRANSFER FROM AMBULATORY SURGERY CENTER - Inpatient: The patient was admitted to this facility as a transfer from an ambulatory surgery center. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from an ambulatory surgery center.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode Ce = new(Values.Ce);

    /// <summary>
    /// TRANSFER FROM A HOSPICE FACILITY - Inpatient: The patient was admitted to this facility as a transfer from a hospice facility. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from a hospice facility.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode Cf = new(Values.Cf);

    /// <summary>
    /// TRANSFER FROM A DESIGNATED DISASTER ALTERNATE CARE SITE (EFFECTIVE 7/1/20) - The patient was transferred to this facility from a Designated Disaster Alternate Care Site for inpatient or outpatient services.
    /// </summary>
    public static readonly PointOfOriginForAdmissionOrVisitCode Cg = new(Values.Cg);

    public PointOfOriginForAdmissionOrVisitCode(string value)
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
    public static PointOfOriginForAdmissionOrVisitCode FromCustom(string value)
    {
        return new PointOfOriginForAdmissionOrVisitCode(value);
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

    public static bool operator ==(PointOfOriginForAdmissionOrVisitCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PointOfOriginForAdmissionOrVisitCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PointOfOriginForAdmissionOrVisitCode value) =>
        value.Value;

    public static explicit operator PointOfOriginForAdmissionOrVisitCode(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// NON-HEALTH CARE FACILITY POINT OF ORIGIN - Inpatient: The patient was admitted to this facility. Outpatient: The patient presented for outpatient services. Examples: Includes patients coming from home or workplace and patients receiving care at home (such as home health services).
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// CLINIC OR PHYSICIAN'S OFFICE - Inpatient: The patient was admitted to this facility. Outpatient: The patient presented to this facility for outpatient services.
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// TRANSFER FROM A HOSPITAL (DIFFERENT FACILITY) - Inpatient: The patient was admitted to this facility as a hospital transfer from an acute care facility where he or she was an inpatient or outpatient. Outpatient: The patient was transferred to this facility as an outpatient from an acute care facility. Excludes Transfers from Hospital Inpatient in the Same Facility (See Code D).
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// TRANSFER FROM A SKILLED NURSING FACILITY (SNF), ASSISTED LIVING FACILITY (ALF), INTERMEDIATE CARE FACILITY (ICF) OR OTHER NURSING FACILITY (NF). - Inpatient: The patient was admitted to this facility as a transfer from a SNF, ALF, ICF or other NF where he or she was a resident. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from a SNF, ALF, ICF or other NF where he or she was a resident.
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// TRANSFER FROM ANOTHER HEALTH CARE FACILITY - Inpatient: The patient was admitted to this facility as a transfer from another type of health care facility not defined elsewhere in this code list. Outpatient: The patient presented to this facility for services from another health care facility not defined elsewhere in this code list.
        /// </summary>
        public const string C6 = "6";

        /// <summary>
        /// COURT/LAW ENFORCEMENT - Inpatient: The patient was admitted to this facility upon the direction of a court of law, or upon the request of a law enforcement agency representative. Outpatient: The patient presented to this facility upon the direction of a court of law, or upon the request of a law enforcement agency representative for outpatient or referenced diagnostic services. Usage Note: Includes transfers from incarceration facilities.
        /// </summary>
        public const string C8 = "8";

        /// <summary>
        /// INFORMATION NOT AVAILABLE - Inpatient: The patient's Point of Origin is not known. Outpatient: The patient's Point of Origin is not known.
        /// </summary>
        public const string C9 = "9";

        /// <summary>
        /// TRANSFER FROM ONE DISTINCT UNIT OF THE HOSPITAL TO ANOTHER DISTINCT UNIT OF THE SAME HOSPITAL RESULTING IN A SEPARATE CLAIM TO THE PAYER - Inpatient: The patient was admitted to this facility as a transfer from hospital inpatient within this hospital resulting in a separate claim to the payer. Outpatient: The patient received outpatient services in this facility as a transfer from within this hospital resulting in a separate claim to the payer. Usage Note: For purposes of this code, "Distinct Unit" is defined as a unique unit or level of care at the hospital requiring the issuance of a separate claim to the payer. Examples could include observation services, psychiatric units, rehabilitation units, a unit in a critical access hospital, or a swing bed located in an acute hospital.
        /// </summary>
        public const string Cd = "D";

        /// <summary>
        /// TRANSFER FROM AMBULATORY SURGERY CENTER - Inpatient: The patient was admitted to this facility as a transfer from an ambulatory surgery center. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from an ambulatory surgery center.
        /// </summary>
        public const string Ce = "E";

        /// <summary>
        /// TRANSFER FROM A HOSPICE FACILITY - Inpatient: The patient was admitted to this facility as a transfer from a hospice facility. Outpatient: The patient presented to this facility for outpatient or referenced diagnostic services from a hospice facility.
        /// </summary>
        public const string Cf = "F";

        /// <summary>
        /// TRANSFER FROM A DESIGNATED DISASTER ALTERNATE CARE SITE (EFFECTIVE 7/1/20) - The patient was transferred to this facility from a Designated Disaster Alternate Care Site for inpatient or outpatient services.
        /// </summary>
        public const string Cg = "G";
    }
}
