using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

public partial interface IV3Client
{
    WithRawResponseTask<ContractWithProvidersUnion> GetAsync(
        string contractId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractsPage> GetMultiAsync(
        GetMultiContractsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new contract within the user's current organization
    /// </summary>
    WithRawResponseTask<ContractWithProvidersUnion> CreateAsync(
        ContractCreateUnion request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string contractId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractWithProvidersUnion> UpdateAsync(
        string contractId,
        ContractUpdateUnion request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractServiceFacility> CreateContractServiceFacilityAsync(
        string contractId,
        ContractServiceFacilityCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ContractServiceFacility> UpdateContractServiceFacilityAsync(
        string contractId,
        string contractServiceFacilityId,
        ContractServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
