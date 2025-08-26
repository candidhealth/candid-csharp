using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<ValueCode>))]
public enum ValueCode
{
    [EnumMember(Value = "01")]
    C01Money,

    [EnumMember(Value = "02")]
    C02Money,

    [EnumMember(Value = "04")]
    C04Money,

    [EnumMember(Value = "05")]
    C05Money,

    [EnumMember(Value = "06")]
    C06Money,

    [EnumMember(Value = "08")]
    C08Money,

    [EnumMember(Value = "09")]
    C09Money,

    [EnumMember(Value = "10")]
    C10Money,

    [EnumMember(Value = "11")]
    C11Money,

    [EnumMember(Value = "12")]
    C12Money,

    [EnumMember(Value = "13")]
    C13Money,

    [EnumMember(Value = "14")]
    C14Money,

    [EnumMember(Value = "15")]
    C15Money,

    [EnumMember(Value = "16")]
    C16Money,

    [EnumMember(Value = "21")]
    C21Money,

    [EnumMember(Value = "22")]
    C22Money,

    [EnumMember(Value = "23")]
    C23Money,

    [EnumMember(Value = "24")]
    C24Num,

    [EnumMember(Value = "25")]
    C25Money,

    [EnumMember(Value = "26")]
    C26Money,

    [EnumMember(Value = "27")]
    C27Money,

    [EnumMember(Value = "28")]
    C28Money,

    [EnumMember(Value = "29")]
    C29Money,

    [EnumMember(Value = "30")]
    C30Money,

    [EnumMember(Value = "31")]
    C31Money,

    [EnumMember(Value = "32")]
    C32Num,

    [EnumMember(Value = "33")]
    C33Money,

    [EnumMember(Value = "34")]
    C34Money,

    [EnumMember(Value = "35")]
    C35Money,

    [EnumMember(Value = "37")]
    C37Num,

    [EnumMember(Value = "38")]
    C38Num,

    [EnumMember(Value = "39")]
    C39Num,

    [EnumMember(Value = "40")]
    C40Money,

    [EnumMember(Value = "41")]
    C41Money,

    [EnumMember(Value = "42")]
    C42Money,

    [EnumMember(Value = "43")]
    C43Money,

    [EnumMember(Value = "44")]
    C44Money,

    [EnumMember(Value = "45")]
    C45Num,

    [EnumMember(Value = "46")]
    C46Num,

    [EnumMember(Value = "47")]
    C47Money,

    [EnumMember(Value = "48")]
    C48Num,

    [EnumMember(Value = "49")]
    C49Num,

    [EnumMember(Value = "50")]
    C50Num,

    [EnumMember(Value = "51")]
    C51Num,

    [EnumMember(Value = "52")]
    C52Num,

    [EnumMember(Value = "53")]
    C53Num,

    [EnumMember(Value = "54")]
    C54Num,

    [EnumMember(Value = "55")]
    C55Money,

    [EnumMember(Value = "56")]
    C56Num,

    [EnumMember(Value = "57")]
    C57Num,

    [EnumMember(Value = "58")]
    C58Num,

    [EnumMember(Value = "59")]
    C59Num,

    [EnumMember(Value = "60")]
    C60Num,

    [EnumMember(Value = "61")]
    C61Num,

    [EnumMember(Value = "66")]
    C66Money,

    [EnumMember(Value = "67")]
    C67Num,

    [EnumMember(Value = "68")]
    C68Num,

    [EnumMember(Value = "69")]
    C69Num,

    [EnumMember(Value = "80")]
    C80Num,

    [EnumMember(Value = "81")]
    C81Num,

    [EnumMember(Value = "82")]
    C82Num,

    [EnumMember(Value = "83")]
    C83Num,

    [EnumMember(Value = "84")]
    C84Num,

    [EnumMember(Value = "85")]
    C85Num,

    [EnumMember(Value = "87")]
    C87Money,

    [EnumMember(Value = "89")]
    C89Money,

    [EnumMember(Value = "90")]
    C90Money,

    [EnumMember(Value = "91")]
    C91Money,

    [EnumMember(Value = "A0")]
    Ca0Num,

    [EnumMember(Value = "A1")]
    Ca1Money,

    [EnumMember(Value = "A2")]
    Ca2Money,

    [EnumMember(Value = "A3")]
    Ca3Money,

    [EnumMember(Value = "A4")]
    Ca4Money,

    [EnumMember(Value = "A5")]
    Ca5Money,

    [EnumMember(Value = "A6")]
    Ca6Money,

    [EnumMember(Value = "A7")]
    Ca7Money,

    [EnumMember(Value = "A8")]
    Ca8Num,

    [EnumMember(Value = "A9")]
    Ca9Num,

    [EnumMember(Value = "AA")]
    CaaMoney,

    [EnumMember(Value = "AB")]
    CabMoney,

    [EnumMember(Value = "B1")]
    Cb1Money,

    [EnumMember(Value = "B2")]
    Cb2Money,

    [EnumMember(Value = "B3")]
    Cb3Money,

    [EnumMember(Value = "B7")]
    Cb7Money,

    [EnumMember(Value = "BA")]
    CbaMoney,

    [EnumMember(Value = "BB")]
    CbbMoney,

    [EnumMember(Value = "C1")]
    Cc1Money,

    [EnumMember(Value = "C2")]
    Cc2Money,

    [EnumMember(Value = "C3")]
    Cc3Money,

    [EnumMember(Value = "C7")]
    Cc7Money,

    [EnumMember(Value = "CA")]
    CcaMoney,

    [EnumMember(Value = "CB")]
    CcbMoney,

    [EnumMember(Value = "D3")]
    Cd3Money,

    [EnumMember(Value = "D4")]
    Cd4Num,

    [EnumMember(Value = "D5")]
    Cd5Num,

    [EnumMember(Value = "D6")]
    Cd6Num,

    [EnumMember(Value = "FC")]
    CfcMoney,

    [EnumMember(Value = "FD")]
    CfdMoney,

    [EnumMember(Value = "G8")]
    Cg8Num,

    [EnumMember(Value = "P1")]
    Cp1Num,

    [EnumMember(Value = "P2")]
    Cp2Num,

    [EnumMember(Value = "P3")]
    Cp3Num,

    [EnumMember(Value = "Y1")]
    Cy1Money,

    [EnumMember(Value = "Y2")]
    Cy2Money,

    [EnumMember(Value = "Y3")]
    Cy3Money,

    [EnumMember(Value = "Y4")]
    Cy4Money,

    [EnumMember(Value = "Y5")]
    Cy5Money,
}
