using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(StringEnumSerializer<AppointmentType>))]
public enum AppointmentType
{
    [EnumMember(Value = "Complete")]
    Complete,

    [EnumMember(Value = "Normal")]
    Normal,

    [EnumMember(Value = "Tentative")]
    Tentative
}
