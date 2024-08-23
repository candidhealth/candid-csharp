using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentReason>))]
public enum AppointmentReason
{
    [EnumMember(Value = "CHECKUP")]
    Checkup,

    [EnumMember(Value = "EMERGENCY")]
    Emergency,

    [EnumMember(Value = "FOLLOWUP")]
    Followup,

    [EnumMember(Value = "ROUTINE")]
    Routine,

    [EnumMember(Value = "WALKIN")]
    Walkin
}
