using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<NetworkType>))]
public enum NetworkType
{
    [EnumMember(Value = "12")]
    Ppo,

    [EnumMember(Value = "13")]
    Pos,

    [EnumMember(Value = "14")]
    Epo,

    [EnumMember(Value = "15")]
    IndemnityInsurance,

    [EnumMember(Value = "16")]
    HmoMedicareRisk,

    [EnumMember(Value = "17")]
    Dmo,

    [EnumMember(Value = "AM")]
    Auto,

    [EnumMember(Value = "CH")]
    Champus,

    [EnumMember(Value = "DS")]
    Disability,

    [EnumMember(Value = "HM")]
    Hmo,

    [EnumMember(Value = "LM")]
    Liability,

    [EnumMember(Value = "MA")]
    MedicarePartA,

    [EnumMember(Value = "MB")]
    MedicarePartB,

    [EnumMember(Value = "MC")]
    Medicaid,

    [EnumMember(Value = "OF")]
    OtherFederalProgram,

    [EnumMember(Value = "TV")]
    TitleV,

    [EnumMember(Value = "VA")]
    VeteransAffairsPlan,

    [EnumMember(Value = "WC")]
    WorkersCompHealthClaim,

    [EnumMember(Value = "ZZ")]
    MutuallyDefined,
}
