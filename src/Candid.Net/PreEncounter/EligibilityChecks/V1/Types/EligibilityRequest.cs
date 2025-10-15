using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;
using OneOf;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the data for an eligibility request.
/// </summary>
[Serializable]
public record EligibilityRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A unique identifier for the eligibility check within the batch. Candid returns this identifier in the response for the
    /// /batch/{batch_id} polling endpoint so you can correlate benefit responses with the original eligibility check.
    /// </summary>
    [JsonPropertyName("submitter_transaction_identifier")]
    public string? SubmitterTransactionIdentifier { get; set; }

    /// <summary>
    /// Supported payer ID values can be found [here](https://www.stedi.com/healthcare/network).
    /// </summary>
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("provider")]
    public required OneOf<IndividualProvider, OrganizationProvider> Provider { get; set; }

    /// <summary>
    /// The primary policyholder for the insurance plan or a dependent with a unique member ID. &lt;Note&gt;If a dependent has a unique member ID, include their information here and leave dependent undefined.&lt;/Note&gt;
    /// </summary>
    [JsonPropertyName("subscriber")]
    public required MemberInfo Subscriber { get; set; }

    /// <summary>
    /// &lt;Note&gt;If a dependent has a unique member ID, include their information as subscriber and leave this field undefined.&lt;/Note&gt;
    /// </summary>
    [JsonPropertyName("dependent")]
    public MemberInfo? Dependent { get; set; }

    [JsonPropertyName("encounter")]
    public Encounter? Encounter { get; set; }

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
