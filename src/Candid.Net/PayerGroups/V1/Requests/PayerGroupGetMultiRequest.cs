using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PayerGroups.V1;

[Serializable]
public record PayerGroupGetMultiRequest
{
    [JsonIgnore]
    public string? Name { get; set; }

    [JsonIgnore]
    public IEnumerable<string> PayerGroupId { get; set; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<string> PayerPlanGroupId { get; set; } = new List<string>();

    /// <summary>
    /// If provided, only returns payer groups that have at least this many active (non-deactivated) payer plans.
    /// </summary>
    [JsonIgnore]
    public int? MinPayerPlanCount { get; set; }

    /// <summary>
    /// If true, archived payer groups are included in the results. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeArchived { get; set; }

    /// <summary>
    /// Defaults to 100. Cannot exceed 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Sort direction. Defaults to ascending order if not provided.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
