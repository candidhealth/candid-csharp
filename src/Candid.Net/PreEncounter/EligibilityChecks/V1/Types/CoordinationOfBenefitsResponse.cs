using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the data for a coordination of benefits response.
/// </summary>
[Serializable]
public record CoordinationOfBenefitsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Information about the provider who submitted the COB request.
    /// </summary>
    [JsonPropertyName("provider")]
    public CobResponseProvider? Provider { get; set; }

    /// <summary>
    /// Information about the primary policyholder.
    /// </summary>
    [JsonPropertyName("subscriber")]
    public CobResponseSubscriber? Subscriber { get; set; }

    /// <summary>
    /// Information about the dependent listed in the COB request.
    /// </summary>
    [JsonPropertyName("dependent")]
    public CobResponseDependent? Dependent { get; set; }

    /// <summary>
    /// Information about the payer listed in the COB request.
    /// </summary>
    [JsonPropertyName("payer")]
    public CobPayer? Payer { get; set; }

    /// <summary>
    /// Date information for the plan.
    /// </summary>
    [JsonPropertyName("plan_date_information")]
    public CobPlanDateInformation? PlanDateInformation { get; set; }

    /// <summary>
    /// Raw passthrough of Stedi's benefits information (coverage, service types, related entities, etc.).
    /// </summary>
    [JsonPropertyName("benefits_information")]
    public IEnumerable<object>? BenefitsInformation { get; set; }

    [JsonPropertyName("errors")]
    public IEnumerable<EligibilityCheckErrorDetails>? Errors { get; set; }

    /// <summary>
    /// Overview of the COB response including whether coverage overlap exists and payer primacy.
    /// </summary>
    [JsonPropertyName("coordination_of_benefits")]
    public Cob? CoordinationOfBenefits { get; set; }

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
