using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[Serializable]
public record GetMultiNonInsurancePayersRequest
{
    [JsonIgnore]
    public string? Name { get; set; }

    /// <summary>
    /// Fuzzy-match category names of non-insurance payers.
    /// </summary>
    [JsonIgnore]
    public string? Category { get; set; }

    /// <summary>
    /// Filter by one or more categories by name.
    /// When multiple are present, non-insurance payers with any of the specified
    /// categories will be matched.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> CategoriesExact { get; set; } = new List<string>();

    /// <summary>
    /// Filter by one or more clinical trials by their `clinical_trial_id`.
    /// When multiple are present, non-insurance payers with any of the specified
    /// clinical trials will be matched.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ClinicalTrialIds { get; set; } = new List<string>();

    [JsonIgnore]
    public bool? Enabled { get; set; }

    [JsonIgnore]
    public NonInsurancePayerSortField? Sort { get; set; }

    [JsonIgnore]
    public Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
