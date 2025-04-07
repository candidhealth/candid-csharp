using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureSortField>))]
public enum ChargeCaptureSortField
{
    [EnumMember(Value = "created_at")]
    CreatedAt,

    [EnumMember(Value = "date_of_service")]
    DateOfService,
}
