using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<OccurrenceInformationCodeQualifier>))]
public enum OccurrenceInformationCodeQualifier
{
    [EnumMember(Value = "BH")]
    Cbh,
}
