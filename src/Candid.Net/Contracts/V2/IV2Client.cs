using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

public partial interface IV2Client
{
    /// <summary>
    /// This API provides access to Professional Contracts. For Professional and Institutional Contracts use Contracts V3.
    /// </summary>
    WithRawResponseTask<ContractWithProviders> GetAsync(
        string contractId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This API provides access to Professional Contracts. For Professional and Institutional Contracts use Contracts V3.
    /// </summary>
    WithRawResponseTask<ContractsPage> GetMultiAsync(
        GetMultiContractsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new contract within the user's current organization
    /// </summary>
    WithRawResponseTask<ContractWithProviders> CreateAsync(
        ContractCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string contractId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractWithProviders> UpdateAsync(
        string contractId,
        ContractUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
