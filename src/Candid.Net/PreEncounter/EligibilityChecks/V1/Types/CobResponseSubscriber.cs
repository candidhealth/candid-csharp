using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Information about the primary policyholder for the insurance plan listed in the COB request.
/// </summary>
[Serializable]
public record CobResponseSubscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The member ID for the subscriber's insurance policy.
    /// </summary>
    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }

    /// <summary>
    /// The subscriber's gender. Typically `F` - Female, `M` - Male, or `U` - Unknown.
    /// </summary>
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }

    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth { get; set; }

    [JsonPropertyName("ssn")]
    public string? Ssn { get; set; }

    /// <summary>
    /// The group number associated with the subscriber's insurance policy.
    /// </summary>
    [JsonPropertyName("group_number")]
    public string? GroupNumber { get; set; }

    /// <summary>
    /// Birth order when there are multiple births associated with the provided birth date.
    /// </summary>
    [JsonPropertyName("birth_sequence_number")]
    public string? BirthSequenceNumber { get; set; }

    [JsonPropertyName("address")]
    public CobAddress? Address { get; set; }

    /// <summary>
    /// AAA errors specifying reasons for rejection and recommended follow-up actions.
    /// </summary>
    [JsonPropertyName("aaa_errors")]
    public IEnumerable<EligibilityCheckErrorDetails>? AaaErrors { get; set; }

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
