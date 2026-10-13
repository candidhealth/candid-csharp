using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Eligibility.V2;

[Serializable]
public record EligibilityRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    [JsonPropertyName("dependent_member_id")]
    public string? DependentMemberId { get; set; }

    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("provider_npi")]
    public required string ProviderNpi { get; set; }

    [JsonPropertyName("date_of_service")]
    public required DateTime DateOfService { get; set; }

    [JsonPropertyName("service_type_codes")]
    public IEnumerable<string> ServiceTypeCodes { get; set; } = new List<string>();

    [JsonPropertyName("patient_gender")]
    public string? PatientGender { get; set; }

    [JsonPropertyName("patient_first_name")]
    public string? PatientFirstName { get; set; }

    [JsonPropertyName("patient_last_name")]
    public string? PatientLastName { get; set; }

    [JsonPropertyName("patient_date_of_birth")]
    public DateTime? PatientDateOfBirth { get; set; }

    [JsonPropertyName("patient_state")]
    public string? PatientState { get; set; }

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
