using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record Referral : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required ExternalProvider Provider { get; set; }

    [JsonPropertyName("referral_number")]
    public required string ReferralNumber { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("serviceFacility")]
    public PatientServiceFacility? ServiceFacility { get; set; }

    [JsonPropertyName("units")]
    public ReferralUnit? Units { get; set; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; set; }

    [JsonPropertyName("cptCodes")]
    public IEnumerable<string>? CptCodes { get; set; }

    [JsonPropertyName("applyForAllCptCodes")]
    public bool? ApplyForAllCptCodes { get; set; }

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
