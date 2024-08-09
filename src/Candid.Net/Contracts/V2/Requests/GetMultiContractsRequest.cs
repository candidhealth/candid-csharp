using Candid.Net;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record GetMultiContractsRequest
{
    public string? PageToken { get; set; }

    /// <summary>
    /// Max number of contracts returned. Defaults to 1000. Max is 1000.
    /// </summary>
    public int? Limit { get; set; }

    public string? ContractingProviderId { get; set; }

    public IEnumerable<string> RenderingProviderIds { get; set; } = new List<string>();

    /// <summary>
    /// Filter to contracts that include any of the included payer names.
    /// </summary>
    public IEnumerable<string> PayerNames { get; set; } = new List<string>();

    public IEnumerable<State> States { get; set; } = new List<State>();

    /// <summary>
    /// The status of the contract. Defaults to `pending`
    /// </summary>
    public ContractStatus? ContractStatus { get; set; }
}
