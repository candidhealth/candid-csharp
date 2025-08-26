using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<OccurrenceCode>))]
public enum OccurrenceCode
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

    [EnumMember(Value = "09")]
    C09,

    [EnumMember(Value = "10")]
    C10,

    [EnumMember(Value = "11")]
    C11,

    [EnumMember(Value = "12")]
    C12,

    [EnumMember(Value = "16")]
    C16,

    [EnumMember(Value = "17")]
    C17,

    [EnumMember(Value = "18")]
    C18,

    [EnumMember(Value = "19")]
    C19,

    [EnumMember(Value = "20")]
    C20,

    [EnumMember(Value = "21")]
    C21,

    [EnumMember(Value = "22")]
    C22,

    [EnumMember(Value = "24")]
    C24,

    [EnumMember(Value = "25")]
    C25,

    [EnumMember(Value = "26")]
    C26,

    [EnumMember(Value = "27")]
    C27,

    [EnumMember(Value = "28")]
    C28,

    [EnumMember(Value = "29")]
    C29,

    [EnumMember(Value = "30")]
    C30,

    [EnumMember(Value = "31")]
    C31,

    [EnumMember(Value = "32")]
    C32,

    [EnumMember(Value = "33")]
    C33,

    [EnumMember(Value = "34")]
    C34,

    [EnumMember(Value = "35")]
    C35,

    [EnumMember(Value = "36")]
    C36,

    [EnumMember(Value = "37")]
    C37,

    [EnumMember(Value = "38")]
    C38,

    [EnumMember(Value = "39")]
    C39,

    [EnumMember(Value = "40")]
    C40,

    [EnumMember(Value = "41")]
    C41,

    [EnumMember(Value = "42")]
    C42,

    [EnumMember(Value = "43")]
    C43,

    [EnumMember(Value = "44")]
    C44,

    [EnumMember(Value = "45")]
    C45,

    [EnumMember(Value = "46")]
    C46,

    [EnumMember(Value = "47")]
    C47,

    [EnumMember(Value = "50")]
    C50,

    [EnumMember(Value = "51")]
    C51,

    [EnumMember(Value = "52")]
    C52,

    [EnumMember(Value = "54")]
    C54,

    [EnumMember(Value = "55")]
    C55,

    [EnumMember(Value = "56")]
    C56,

    [EnumMember(Value = "61")]
    C61,

    [EnumMember(Value = "62")]
    C62,

    [EnumMember(Value = "A1")]
    Ca1,

    [EnumMember(Value = "A2")]
    Ca2,

    [EnumMember(Value = "A3")]
    Ca3,

    [EnumMember(Value = "A4")]
    Ca4,

    [EnumMember(Value = "B1")]
    Cb1,

    [EnumMember(Value = "B2")]
    Cb2,

    [EnumMember(Value = "B3")]
    Cb3,

    [EnumMember(Value = "C1")]
    Cc1,

    [EnumMember(Value = "C2")]
    Cc2,

    [EnumMember(Value = "C3")]
    Cc3,
}
