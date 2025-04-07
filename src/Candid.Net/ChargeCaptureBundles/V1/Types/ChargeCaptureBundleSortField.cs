using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureBundleSortField>))]
public enum ChargeCaptureBundleSortField
{
    [EnumMember(Value = "created_at")]
    CreatedAt,
}
