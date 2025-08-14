using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record GetMultiNonInsurancePayersRequest
{
    public string? Name { get; set; }

    /// <summary>
    /// Fuzzy-match category names of non-insurance payers.
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Filter by one or more categories by name.
    /// When multiple are present, non-insurance payers with any of the specified
    /// categories will be matched.
    /// </summary>
    public IEnumerable<string> CategoriesExact { get; set; } = new List<string>();

    /// <summary>
    /// Filter by one or more clinical trials by their `clinical_trial_id`.
    /// When multiple are present, non-insurance payers with any of the specified
    /// clinical trials will be matched.
    /// </summary>
    public IEnumerable<string> ClinicalTrialIds { get; set; } = new List<string>();

    public bool? Enabled { get; set; }

    public NonInsurancePayerSortField? Sort { get; set; }

    public SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
