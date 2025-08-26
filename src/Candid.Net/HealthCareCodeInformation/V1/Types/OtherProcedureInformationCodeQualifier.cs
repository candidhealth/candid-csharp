using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<OtherProcedureInformationCodeQualifier>))]
public enum OtherProcedureInformationCodeQualifier
{
    [EnumMember(Value = "BBQ")]
    Cbbq,

    [EnumMember(Value = "BQ")]
    Cbq,
}
