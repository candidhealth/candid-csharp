using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<BillingProviderCommercialLicenseType>))]
public enum BillingProviderCommercialLicenseType
{
    [EnumMember(Value = "0")]
    LicensedClinicalSocialWorker,

    [EnumMember(Value = "A")]
    LicensedProfessionalCounselor,

    [EnumMember(Value = "B")]
    LicensedMarriageAndFamilyCounselor,

    [EnumMember(Value = "C")]
    LicensedClinicalAlcoholAndDrugCounselor,

    [EnumMember(Value = "D")]
    Psychologist,

    [EnumMember(Value = "E")]
    PsychiatricNurse,

    [EnumMember(Value = "F")]
    Psychiatrist,

    [EnumMember(Value = "G")]
    ChildAdolescentPsychiatrist,

    [EnumMember(Value = "H")]
    PhysicianAssistant,

    [EnumMember(Value = "I")]
    NurseCnp,
}
