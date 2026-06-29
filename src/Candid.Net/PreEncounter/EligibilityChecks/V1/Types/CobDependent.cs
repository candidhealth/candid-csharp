using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// A dependent for which you want to check coordination of benefits.
/// If the dependent has their own member ID, include their information in the subscriber object instead.
/// </summary>
[Serializable]
public record CobDependent : IJsonOnDeserialized
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
    /// The dependent's date of birth.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required string DateOfBirth { get; set; }

    /// <summary>
    /// The dependent's Social Security Number (SSN).
    /// </summary>
    [JsonPropertyName("ssn")]
    public string? Ssn { get; set; }

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
