using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureClaimCreationSortField>))]
public enum ChargeCaptureClaimCreationSortField
{
    [EnumMember(Value = "created_at")]
    CreatedAt,
}
