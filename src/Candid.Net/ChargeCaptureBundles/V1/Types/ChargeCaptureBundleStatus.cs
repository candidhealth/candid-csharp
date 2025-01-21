using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureBundleStatus>))]
public enum ChargeCaptureBundleStatus
{
    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "in-error")]
    InError,

    [EnumMember(Value = "successful")]
    Successful,

    [EnumMember(Value = "aborted")]
    Aborted,
}
