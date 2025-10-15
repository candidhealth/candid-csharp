using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[Serializable]
public record GetMultiContractsRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of contracts returned. Defaults to 1000. Max is 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? ContractingProviderId { get; set; }

    [JsonIgnore]
    public IEnumerable<string> RenderingProviderIds { get; set; } = new List<string>();

    /// <summary>
    /// Filter to contracts that include any of the included payer names.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> PayerNames { get; set; } = new List<string>();

    [JsonIgnore]
    public IEnumerable<State> States { get; set; } = new List<State>();

    /// <summary>
    /// The status of the contract. Defaults to `pending`
    /// </summary>
    [JsonIgnore]
    public ContractStatus? ContractStatus { get; set; }

    /// <summary>
    /// Potentially sort by a contract related attribute.  Defaults to created_at
    /// </summary>
    [JsonIgnore]
    public ContractSortField? Sort { get; set; }

    /// <summary>
    /// Direction of sort, defaulting to desc
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
