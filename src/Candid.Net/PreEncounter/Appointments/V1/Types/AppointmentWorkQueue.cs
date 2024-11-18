using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentWorkQueue>))]
public enum AppointmentWorkQueue
{
    [EnumMember(Value = "EMERGENT_ISSUE")]
    EmergentIssue,

    [EnumMember(Value = "NEW_PATIENT")]
    NewPatient,

    [EnumMember(Value = "RETURNING_PATIENT")]
    ReturningPatient,

    [EnumMember(Value = "MANUAL_ESCALATION")]
    ManualEscalation,
}
