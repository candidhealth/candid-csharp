using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public record PayerPlanGroupGetMultiRequest
{
    public IEnumerable<string> PlanGroupName { get; set; } = new List<string>();

    public IEnumerable<string> PayerUuid { get; set; } = new List<string>();

    public IEnumerable<string> PayerId { get; set; } = new List<string>();

    public IEnumerable<SourceOfPaymentCode> PlanType { get; set; } =
        new List<SourceOfPaymentCode>();

    public bool? IsActive { get; set; }

    public IEnumerable<string> PayerPlanGroupId { get; set; } = new List<string>();

    /// <summary>
    /// Defaults to 100. Cannot exc
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// If this property is passed, the results will be ordered by those that contain a payer_id, payer_name, plan_group_name, or
    /// payer_address most similar to the value passed. This will take precedence over the sort and sort_direction properties. This
    /// will always sort in order of most similar to least similar.
    /// </summary>
    public string? SortBySimilarity { get; set; }

    /// <summary>
    /// Defaults to plan_group_name. If sort_by_similarity is passed, that sort will takes precedence over this property.
    /// </summary>
    public PayerPlanGroupSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to ascending order if not provided.
    /// </summary>
    public SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
