using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Appointments.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record AuditAppointmentStatusChanged : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from_status")]
    public AppointmentStatus? FromStatus { get; set; }

    [JsonPropertyName("to_status")]
    public AppointmentStatus? ToStatus { get; set; }

    [JsonPropertyName("not_ready_reason")]
    public NotReadyReason? NotReadyReason { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
