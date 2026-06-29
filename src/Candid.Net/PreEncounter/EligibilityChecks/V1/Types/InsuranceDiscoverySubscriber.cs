using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Demographic information for the patient when they are the health plan subscriber.
/// Providing as much information as possible improves the probability of finding matching coverage.
/// SSN and address (especially zip code) are strongly recommended.
/// </summary>
[Serializable]
public record InsuranceDiscoverySubscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The subscriber's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    /// <summary>
    /// The subscriber's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    /// <summary>
    /// The subscriber's middle name or initial.
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }

    /// <summary>
    /// The subscriber's date of birth, formatted as YYYYMMDD.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// The subscriber's Social Security Number (SSN). Full SSN is preferred, but even the last 4 digits can help.
    /// </summary>
    [JsonPropertyName("ssn")]
    public string? Ssn { get; set; }

    [JsonPropertyName("gender")]
    public InsuranceDiscoveryGender? Gender { get; set; }

    [JsonPropertyName("address")]
    public InsuranceDiscoveryAddress? Address { get; set; }

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
