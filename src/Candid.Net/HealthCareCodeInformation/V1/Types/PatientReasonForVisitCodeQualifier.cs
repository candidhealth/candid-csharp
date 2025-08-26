using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<PatientReasonForVisitCodeQualifier>))]
public enum PatientReasonForVisitCodeQualifier
{
    [EnumMember(Value = "PR")]
    Cpr,

    [EnumMember(Value = "APR")]
    Capr,
}
