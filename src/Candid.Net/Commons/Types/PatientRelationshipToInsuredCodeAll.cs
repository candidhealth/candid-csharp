using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<PatientRelationshipToInsuredCodeAll>))]
public enum PatientRelationshipToInsuredCodeAll
{
    [EnumMember(Value = "01")]
    Spouse,

    [EnumMember(Value = "04")]
    Grandparent,

    [EnumMember(Value = "05")]
    Grandchild,

    [EnumMember(Value = "07")]
    NieceNephew,

    [EnumMember(Value = "10")]
    FosterChild,

    [EnumMember(Value = "15")]
    WardOfTheCourt,

    [EnumMember(Value = "17")]
    Stepchild,

    [EnumMember(Value = "18")]
    Self,

    [EnumMember(Value = "19")]
    Child,

    [EnumMember(Value = "20")]
    Employee,

    [EnumMember(Value = "21")]
    Unknown,

    [EnumMember(Value = "22")]
    HandicappedDependent,

    [EnumMember(Value = "23")]
    SponsoredDependent,

    [EnumMember(Value = "24")]
    DependentOfMinorDependent,

    [EnumMember(Value = "29")]
    SignificantOther,

    [EnumMember(Value = "32")]
    Mother,

    [EnumMember(Value = "33")]
    Father,

    [EnumMember(Value = "36")]
    EmancipatedMinor,

    [EnumMember(Value = "39")]
    OrganDonor,

    [EnumMember(Value = "40")]
    CadaverDonor,

    [EnumMember(Value = "41")]
    InjuredPlaintiff,

    [EnumMember(Value = "43")]
    ChildNoFinancialResponsibility,

    [EnumMember(Value = "53")]
    LifePartner,

    [EnumMember(Value = "G8")]
    OtherRelationship
}
