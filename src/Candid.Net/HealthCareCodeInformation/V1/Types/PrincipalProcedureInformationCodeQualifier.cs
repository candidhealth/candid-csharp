using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<PrincipalProcedureInformationCodeQualifier>))]
public enum PrincipalProcedureInformationCodeQualifier
{
    [EnumMember(Value = "BBR")]
    Cbbr,

    [EnumMember(Value = "BR")]
    Cbr,

    [EnumMember(Value = "CAH")]
    Ccah,
}
