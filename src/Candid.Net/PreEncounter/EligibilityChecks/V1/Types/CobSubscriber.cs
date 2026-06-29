using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// The primary policyholder for the insurance plan or a dependent with a unique member ID.
/// You must provide at least one of member_id or ssn.
/// </summary>
[Serializable]
public record CobSubscriber : IJsonOnDeserialized
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
    /// The subscriber's date of birth.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required string DateOfBirth { get; set; }

    /// <summary>
    /// The member ID for the subscriber's insurance policy.
    /// </summary>
    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    /// <summary>
    /// The subscriber's Social Security Number (SSN).
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
