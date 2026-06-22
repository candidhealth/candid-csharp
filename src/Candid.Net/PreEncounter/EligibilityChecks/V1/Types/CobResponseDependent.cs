using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Information about the dependent listed in the original COB request.
/// </summary>
[Serializable]
public record CobResponseDependent : IJsonOnDeserialized
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
    /// The dependent's gender. Typically `F` - Female, `M` - Male, or `U` - Unknown.
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
    /// The name of the relation_to_subscriber_code. For example, `Child` when the code is `19`.
    /// </summary>
    [JsonPropertyName("relation_to_subscriber")]
    public string? RelationToSubscriber { get; set; }

    /// <summary>
    /// The dependent's relationship to the subscriber. For example `01` - Spouse, `19` - Child,
    /// `20` - Employee, `21` - Unknown, `39` - Organ Donor, `40` - Cadaver Donor,
    /// `53` - Life Partner, or `G8` - Other Relationship.
    /// </summary>
    [JsonPropertyName("relation_to_subscriber_code")]
    public string? RelationToSubscriberCode { get; set; }

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
