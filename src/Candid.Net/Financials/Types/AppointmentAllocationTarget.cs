using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record AppointmentAllocationTarget
{
    [JsonPropertyName("appointment_id")]
    public required string AppointmentId { get; set; }
}
