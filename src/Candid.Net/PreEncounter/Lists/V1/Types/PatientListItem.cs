using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments.V1;
using Candid.Net.PreEncounter.Coverages.V1;

namespace Candid.Net.PreEncounter.Lists.V1;

[Serializable]
public record PatientListItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("patient")]
    public required Candid.Net.PreEncounter.Patients.V1.Patient Patient { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

    [JsonPropertyName("secondary_coverage")]
    public MutableCoverage? SecondaryCoverage { get; set; }

    [JsonPropertyName("tertiary_coverage")]
    public MutableCoverage? TertiaryCoverage { get; set; }

    [JsonPropertyName("next_appointment")]
    public MutableAppointment? NextAppointment { get; set; }

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
