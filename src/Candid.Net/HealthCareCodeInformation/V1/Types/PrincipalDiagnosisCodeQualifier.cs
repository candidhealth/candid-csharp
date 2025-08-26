using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<PrincipalDiagnosisCodeQualifier>))]
public enum PrincipalDiagnosisCodeQualifier
{
    [EnumMember(Value = "BK")]
    Cbk,

    [EnumMember(Value = "ABK")]
    Cabk,
}
