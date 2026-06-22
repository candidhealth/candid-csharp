using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Demographic information for the patient when they are a dependent on a health plan.
/// If you only have the dependent's information, identify them in the subscriber object instead and leave this empty.
/// </summary>
[Serializable]
public record InsuranceDiscoveryDependent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The dependent's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    /// <summary>
    /// The dependent's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    /// <summary>
    /// The dependent's middle name or initial.
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }

    /// <summary>
    /// The dependent's date of birth, formatted as YYYYMMDD.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; set; }

    /// <summary>
    /// The dependent's Social Security Number (SSN).
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
