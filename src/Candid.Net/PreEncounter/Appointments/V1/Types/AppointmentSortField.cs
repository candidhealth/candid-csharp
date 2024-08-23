using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentSortField>))]
public enum AppointmentSortField
{
    [EnumMember(Value = "startTimestamp")]
    StartTimestamp,

    [EnumMember(Value = "updatedAt")]
    UpdatedAt
}
