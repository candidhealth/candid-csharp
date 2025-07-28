using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.X12.V1;

[JsonConverter(typeof(EnumSerializer<TypeOfAdmissionOrVisitCode>))]
public enum TypeOfAdmissionOrVisitCode
{
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

    [EnumMember(Value = "9")]
    C9,
}
