using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An overview of the COB response. Indicates whether there is a coverage overlap, whether that
/// overlap creates a coordination of benefits instance, and whether Stedi was able to identify
/// payer primacy (when a COB instance exists).
/// </summary>
[Serializable]
public record Cob : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The classification for the discovered benefits. One of: `CobInstanceExistsPrimacyDetermined`,
    /// `CobInstanceExistsPrimacyUndetermined`, `CoverageOverlapNoBenefitOverlap`,
    /// `CoverageOverlapExistsNotSubjectToCob`, or `MemberFoundNoCob`.
    /// </summary>
    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    /// <summary>
    /// If true, the COB response contains at least one coordination of benefits instance.
    /// </summary>
    [JsonPropertyName("instance_exists")]
    public bool? InstanceExists { get; set; }

    /// <summary>
    /// If true, Stedi was able to determine the primary payer for the patient.
    /// </summary>
    [JsonPropertyName("primacy_determined")]
    public bool? PrimacyDetermined { get; set; }

    /// <summary>
    /// If true, the patient has active coverage with two or more payers during the service date.
    /// </summary>
    [JsonPropertyName("coverage_overlap")]
    public bool? CoverageOverlap { get; set; }

    /// <summary>
    /// If true, the patient has active coverage from two or more payers for the same service type code.
    /// </summary>
    [JsonPropertyName("benefit_overlap")]
    public bool? BenefitOverlap { get; set; }

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
