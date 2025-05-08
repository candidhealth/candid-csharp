using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureClaimCreationStatus>))]
public enum ChargeCaptureClaimCreationStatus
{
    [EnumMember(Value = "not-started")]
    NotStarted,

    [EnumMember(Value = "in-error")]
    InError,

    [EnumMember(Value = "successful")]
    Successful,

    [EnumMember(Value = "successful-dry-run")]
    SuccessfulDryRun,

    [EnumMember(Value = "aborted")]
    Aborted,

    [EnumMember(Value = "held")]
    Held,
}
