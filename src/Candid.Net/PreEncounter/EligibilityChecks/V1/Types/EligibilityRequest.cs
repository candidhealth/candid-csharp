using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;
using OneOf;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record EligibilityRequest
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
