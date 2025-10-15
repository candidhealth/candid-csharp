using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;
using Candid.Net.PreEncounter.Patients.V1;

namespace Candid.Net.PreEncounter.Appointments.V1;

/// <summary>
/// A visit is a collection of appointments that occur on the same day.
/// </summary>
[Serializable]
public record Visit : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    [JsonPropertyName("patient")]
    public required MutablePatientWithMrn Patient { get; set; }

    [JsonPropertyName("start_time")]
    public required DateTime StartTime { get; set; }

    [JsonPropertyName("status")]
    public required AppointmentStatus Status { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

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
