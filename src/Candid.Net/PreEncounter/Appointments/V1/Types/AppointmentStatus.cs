using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentStatus>))]
public enum AppointmentStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "NOT_READY")]
    NotReady,

    [EnumMember(Value = "READY")]
    Ready,

    [EnumMember(Value = "CHECKED_IN")]
    CheckedIn,
}
