using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(EnumSerializer<TypeOfBillFrequencyCode>))]
public enum TypeOfBillFrequencyCode
{
    [EnumMember(Value = "0")]
    C0,

    [EnumMember(Value = "1")]
    C1,

    [EnumMember(Value = "2")]
    C2,

    [EnumMember(Value = "3")]
    C3,

    [EnumMember(Value = "4")]
    C4,

    [EnumMember(Value = "5")]
    C5,

    [EnumMember(Value = "7")]
    C7,

    [EnumMember(Value = "8")]
    C8,

    [EnumMember(Value = "9")]
    C9,

    [EnumMember(Value = "A")]
    Ca,

    [EnumMember(Value = "B")]
    Cb,

    [EnumMember(Value = "C")]
    Cc,

    [EnumMember(Value = "D")]
    Cd,

    [EnumMember(Value = "E")]
    Ce,

    [EnumMember(Value = "F")]
    Cf,

    [EnumMember(Value = "G")]
    Cg,

    [EnumMember(Value = "H")]
    Ch,

    [EnumMember(Value = "I")]
    Ci,

    [EnumMember(Value = "J")]
    Cj,

    [EnumMember(Value = "K")]
    Ck,

    [EnumMember(Value = "M")]
    Cm,

    [EnumMember(Value = "O")]
    CoFreq,

    [EnumMember(Value = "P")]
    Cp,

    [EnumMember(Value = "Q")]
    Cq,

    [EnumMember(Value = "X")]
    Cx,

    [EnumMember(Value = "Y")]
    CyFreq,

    [EnumMember(Value = "Z")]
    CzFreq,
}
