using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(EnumSerializer<PatientDischargeStatusCode>))]
public enum PatientDischargeStatusCode
{
    [EnumMember(Value = "01")]
    C01,

    [EnumMember(Value = "02")]
    C02,

    [EnumMember(Value = "03")]
    C03,

    [EnumMember(Value = "04")]
    C04,

    [EnumMember(Value = "05")]
    C05,

    [EnumMember(Value = "06")]
    C06,

    [EnumMember(Value = "07")]
    C07,

    [EnumMember(Value = "09")]
    C09,

    [EnumMember(Value = "20")]
    C20,

    [EnumMember(Value = "21")]
    C21,

    [EnumMember(Value = "30")]
    C30,

    [EnumMember(Value = "40")]
    C40,

    [EnumMember(Value = "41")]
    C41,

    [EnumMember(Value = "42")]
    C42,

    [EnumMember(Value = "43")]
    C43,

    [EnumMember(Value = "50")]
    C50,

    [EnumMember(Value = "51")]
    C51,

    [EnumMember(Value = "61")]
    C61,

    [EnumMember(Value = "62")]
    C62,

    [EnumMember(Value = "63")]
    C63,

    [EnumMember(Value = "64")]
    C64,

    [EnumMember(Value = "65")]
    C65,

    [EnumMember(Value = "66")]
    C66,

    [EnumMember(Value = "69")]
    C69,

    [EnumMember(Value = "70")]
    C70,

    [EnumMember(Value = "81")]
    C81,

    [EnumMember(Value = "82")]
    C82,

    [EnumMember(Value = "83")]
    C83,

    [EnumMember(Value = "84")]
    C84,

    [EnumMember(Value = "85")]
    C85,

    [EnumMember(Value = "86")]
    C86,

    [EnumMember(Value = "87")]
    C87,

    [EnumMember(Value = "88")]
    C88,

    [EnumMember(Value = "89")]
    C89,

    [EnumMember(Value = "90")]
    C90,

    [EnumMember(Value = "91")]
    C91,

    [EnumMember(Value = "92")]
    C92,

    [EnumMember(Value = "93")]
    C93,

    [EnumMember(Value = "94")]
    C94,

    [EnumMember(Value = "95")]
    C95,
}
