using Candid.Net;
using Candid.Net.Contracts.V2;

#nullable enable

namespace Candid.Net.Contracts.V2;

public record GetMultiContractsRequest
{
    public string? PageToken { get; init; }

    /// <summary>
    /// Max number of contracts returned. Defaults to 1000. Max is 1000.
    /// </summary>
    public int? Limit { get; init; }

    public Guid? ContractingProviderId { get; init; }

    public Guid? RenderingProviderIds { get; init; }

    /// <summary>
    /// Filter to contracts that include any of the included payer names.
    /// </summary>
    public string? PayerNames { get; init; }

    public State? States { get; init; }

    /// <summary>
    /// The status of the contract. Defaults to `pending`
    /// </summary>
    public ContractStatus? ContractStatus { get; init; }
}
