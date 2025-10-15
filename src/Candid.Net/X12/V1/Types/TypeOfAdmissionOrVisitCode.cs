using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(StringEnumSerializer<TypeOfAdmissionOrVisitCode>))]
[Serializable]
public readonly record struct TypeOfAdmissionOrVisitCode : IStringEnum
{
    /// <summary>
    /// EMERGENCY - As a result of severe, life threatening or potentially disabling conditions, the patient requires immediate medical intervention.
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C1 = new(Values.C1);

    /// <summary>
    /// URGENT - The patient requires immediate attention for the care and treatment of a physical or mental disorder.
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C2 = new(Values.C2);

    /// <summary>
    /// ELECTIVE - The patient's condition permits adequate time to schedule the services.
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C3 = new(Values.C3);

    /// <summary>
    /// NEWBORN - Use of this code necessitates the use of special Point of Origin Codes (See Form Locator 15 page 5 of 9).
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C4 = new(Values.C4);

    /// <summary>
    /// TRAUMA - Visit to a trauma center/hospital as licensed or designated by the state or local government authority authorized to do so, or as verified by the American College of Surgeons and involving a trauma activation. (Use Revenue Code 068x capture trauma activation charges involving pre-hospital notification.)
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C5 = new(Values.C5);

    /// <summary>
    /// INFORMATION NOT AVAILABLE - Information not available.
    /// </summary>
    public static readonly TypeOfAdmissionOrVisitCode C9 = new(Values.C9);

    public TypeOfAdmissionOrVisitCode(string value)
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
    public static TypeOfAdmissionOrVisitCode FromCustom(string value)
    {
        return new TypeOfAdmissionOrVisitCode(value);
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

    public static bool operator ==(TypeOfAdmissionOrVisitCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TypeOfAdmissionOrVisitCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TypeOfAdmissionOrVisitCode value) => value.Value;

    public static explicit operator TypeOfAdmissionOrVisitCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// EMERGENCY - As a result of severe, life threatening or potentially disabling conditions, the patient requires immediate medical intervention.
        /// </summary>
        public const string C1 = "1";

        /// <summary>
        /// URGENT - The patient requires immediate attention for the care and treatment of a physical or mental disorder.
        /// </summary>
        public const string C2 = "2";

        /// <summary>
        /// ELECTIVE - The patient's condition permits adequate time to schedule the services.
        /// </summary>
        public const string C3 = "3";

        /// <summary>
        /// NEWBORN - Use of this code necessitates the use of special Point of Origin Codes (See Form Locator 15 page 5 of 9).
        /// </summary>
        public const string C4 = "4";

        /// <summary>
        /// TRAUMA - Visit to a trauma center/hospital as licensed or designated by the state or local government authority authorized to do so, or as verified by the American College of Surgeons and involving a trauma activation. (Use Revenue Code 068x capture trauma activation charges involving pre-hospital notification.)
        /// </summary>
        public const string C5 = "5";

        /// <summary>
        /// INFORMATION NOT AVAILABLE - Information not available.
        /// </summary>
        public const string C9 = "9";
    }
}
