using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<ExternalCauseOfInjuryCodeQualifier>))]
public enum ExternalCauseOfInjuryCodeQualifier
{
    [EnumMember(Value = "BN")]
    Cbn,

    [EnumMember(Value = "ABN")]
    Cabn,
}
