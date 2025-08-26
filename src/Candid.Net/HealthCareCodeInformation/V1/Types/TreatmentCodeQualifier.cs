using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<TreatmentCodeQualifier>))]
public enum TreatmentCodeQualifier
{
    [EnumMember(Value = "TC")]
    Ctc,
}
