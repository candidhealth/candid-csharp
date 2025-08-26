using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<AdmittingDiagnosisCodeQualifier>))]
public enum AdmittingDiagnosisCodeQualifier
{
    [EnumMember(Value = "BJ")]
    Cbj,

    [EnumMember(Value = "ABJ")]
    Cabj,
}
