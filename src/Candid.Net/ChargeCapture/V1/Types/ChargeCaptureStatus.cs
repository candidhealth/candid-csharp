using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(EnumSerializer<ChargeCaptureStatus>))]
public enum ChargeCaptureStatus
{
    [EnumMember(Value = "planned")]
    Planned,

    [EnumMember(Value = "not-billable")]
    NotBillable,

    [EnumMember(Value = "billable")]
    Billable,

    [EnumMember(Value = "aborted")]
    Aborted,

    [EnumMember(Value = "billed")]
    Billed,

    [EnumMember(Value = "entered-in-error")]
    EnteredInError,

    [EnumMember(Value = "unknown")]
    Unknown,
}
