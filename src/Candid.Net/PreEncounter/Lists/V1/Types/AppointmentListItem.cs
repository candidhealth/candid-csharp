using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Appointments.V1;
using global::Candid.Net.PreEncounter.Coverages.V1;
using global::Candid.Net.PreEncounter.Patients.V1;

namespace Candid.Net.PreEncounter.Lists.V1;

[Serializable]
public record AppointmentListItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("appointment")]
    public required Appointment Appointment { get; set; }

    [JsonPropertyName("patient")]
    public required MutablePatientWithMrn Patient { get; set; }

    [JsonPropertyName("primary_coverage")]
    public MutableCoverage? PrimaryCoverage { get; set; }

    [JsonPropertyName("secondary_coverage")]
    public MutableCoverage? SecondaryCoverage { get; set; }

    [JsonPropertyName("primary_service_type")]
    public UniversalServiceIdentifier? PrimaryServiceType { get; set; }

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
