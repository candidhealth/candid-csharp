using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<PatientRelationshipToInsuredCodeAll>))]
[Serializable]
public readonly record struct PatientRelationshipToInsuredCodeAll : IStringEnum
{
    /// <summary>
    /// Spouse
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Spouse = new(Values.Spouse);

    /// <summary>
    /// Grandparent
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Grandparent = new(
        Values.Grandparent
    );

    /// <summary>
    /// Grandchild
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Grandchild = new(Values.Grandchild);

    /// <summary>
    /// Niece/Nephew
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll NieceNephew = new(
        Values.NieceNephew
    );

    /// <summary>
    /// Foster Child
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll FosterChild = new(
        Values.FosterChild
    );

    /// <summary>
    /// Ward of the Court
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll WardOfTheCourt = new(
        Values.WardOfTheCourt
    );

    /// <summary>
    /// Stepchild
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Stepchild = new(Values.Stepchild);

    /// <summary>
    /// Self
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Self = new(Values.Self);

    /// <summary>
    /// Child
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Child = new(Values.Child);

    /// <summary>
    /// Employee
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Employee = new(Values.Employee);

    /// <summary>
    /// Unknown
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Unknown = new(Values.Unknown);

    /// <summary>
    /// Handicapped Dependent
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll HandicappedDependent = new(
        Values.HandicappedDependent
    );

    /// <summary>
    /// Sponsored Dependent
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll SponsoredDependent = new(
        Values.SponsoredDependent
    );

    /// <summary>
    /// Dependent of Minor Dependent
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll DependentOfMinorDependent = new(
        Values.DependentOfMinorDependent
    );

    /// <summary>
    /// Significant Other
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll SignificantOther = new(
        Values.SignificantOther
    );

    /// <summary>
    /// Mother
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Mother = new(Values.Mother);

    /// <summary>
    /// Father
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll Father = new(Values.Father);

    /// <summary>
    /// Emancipated Minor
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll EmancipatedMinor = new(
        Values.EmancipatedMinor
    );

    /// <summary>
    /// Organ Donor
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll OrganDonor = new(Values.OrganDonor);

    /// <summary>
    /// Cadaver Donor
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll CadaverDonor = new(
        Values.CadaverDonor
    );

    /// <summary>
    /// Injured Plaintiff
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll InjuredPlaintiff = new(
        Values.InjuredPlaintiff
    );

    /// <summary>
    /// Child (No Financial Responsibility)
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll ChildNoFinancialResponsibility = new(
        Values.ChildNoFinancialResponsibility
    );

    /// <summary>
    /// Life Partner
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll LifePartner = new(
        Values.LifePartner
    );

    /// <summary>
    /// Other Relationship
    /// </summary>
    public static readonly PatientRelationshipToInsuredCodeAll OtherRelationship = new(
        Values.OtherRelationship
    );

    public PatientRelationshipToInsuredCodeAll(string value)
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
    public static PatientRelationshipToInsuredCodeAll FromCustom(string value)
    {
        return new PatientRelationshipToInsuredCodeAll(value);
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

    public static bool operator ==(PatientRelationshipToInsuredCodeAll value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientRelationshipToInsuredCodeAll value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientRelationshipToInsuredCodeAll value) =>
        value.Value;

    public static explicit operator PatientRelationshipToInsuredCodeAll(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Spouse
        /// </summary>
        public const string Spouse = "01";

        /// <summary>
        /// Grandparent
        /// </summary>
        public const string Grandparent = "04";

        /// <summary>
        /// Grandchild
        /// </summary>
        public const string Grandchild = "05";

        /// <summary>
        /// Niece/Nephew
        /// </summary>
        public const string NieceNephew = "07";

        /// <summary>
        /// Foster Child
        /// </summary>
        public const string FosterChild = "10";

        /// <summary>
        /// Ward of the Court
        /// </summary>
        public const string WardOfTheCourt = "15";

        /// <summary>
        /// Stepchild
        /// </summary>
        public const string Stepchild = "17";

        /// <summary>
        /// Self
        /// </summary>
        public const string Self = "18";

        /// <summary>
        /// Child
        /// </summary>
        public const string Child = "19";

        /// <summary>
        /// Employee
        /// </summary>
        public const string Employee = "20";

        /// <summary>
        /// Unknown
        /// </summary>
        public const string Unknown = "21";

        /// <summary>
        /// Handicapped Dependent
        /// </summary>
        public const string HandicappedDependent = "22";

        /// <summary>
        /// Sponsored Dependent
        /// </summary>
        public const string SponsoredDependent = "23";

        /// <summary>
        /// Dependent of Minor Dependent
        /// </summary>
        public const string DependentOfMinorDependent = "24";

        /// <summary>
        /// Significant Other
        /// </summary>
        public const string SignificantOther = "29";

        /// <summary>
        /// Mother
        /// </summary>
        public const string Mother = "32";

        /// <summary>
        /// Father
        /// </summary>
        public const string Father = "33";

        /// <summary>
        /// Emancipated Minor
        /// </summary>
        public const string EmancipatedMinor = "36";

        /// <summary>
        /// Organ Donor
        /// </summary>
        public const string OrganDonor = "39";

        /// <summary>
        /// Cadaver Donor
        /// </summary>
        public const string CadaverDonor = "40";

        /// <summary>
        /// Injured Plaintiff
        /// </summary>
        public const string InjuredPlaintiff = "41";

        /// <summary>
        /// Child (No Financial Responsibility)
        /// </summary>
        public const string ChildNoFinancialResponsibility = "43";

        /// <summary>
        /// Life Partner
        /// </summary>
        public const string LifePartner = "53";

        /// <summary>
        /// Other Relationship
        /// </summary>
        public const string OtherRelationship = "G8";
    }
}
