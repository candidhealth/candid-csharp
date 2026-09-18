using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Appointments.V1;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record AuditAppointmentWorkQueueChanged : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from_work_queue")]
    public AppointmentWorkQueue? FromWorkQueue { get; set; }

    [JsonPropertyName("to_work_queue")]
    public AppointmentWorkQueue? ToWorkQueue { get; set; }

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
