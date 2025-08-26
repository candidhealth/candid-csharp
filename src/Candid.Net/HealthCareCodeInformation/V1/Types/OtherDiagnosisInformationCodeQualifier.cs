using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<OtherDiagnosisInformationCodeQualifier>))]
public enum OtherDiagnosisInformationCodeQualifier
{
    [EnumMember(Value = "BF")]
    Cbf,

    [EnumMember(Value = "ABF")]
    Cabf,
}
