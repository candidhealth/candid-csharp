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

    WithRawResponseTask DeleteAsync(
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

    WithRawResponseTask<ContractProvidersPage> GetContractProvidersAsync(
        string contractId,
        GetContractProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns rendering providers linked to a contract with their credentialing spans, scoped to the contract's contracting provider and payer. Providers with no matching spans are included with an empty list.
    /// </summary>
    WithRawResponseTask<ContractProviderCredentialingPage> GetContractProviderCredentialingSpansAsync(
        string contractId,
        GetContractProviderCredentialingSpansRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Appends a list of rendering provider IDs to the contract. Provider IDs already on the contract are silently ignored.
    /// </summary>
    WithRawResponseTask<AddContractProvidersResponse> AddContractProvidersAsync(
        string contractId,
        AddContractProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the specified rendering provider IDs from the contract. Returns a 404 if any of the provided IDs are not currently in the contract.
    /// </summary>
    WithRawResponseTask<ContractProviderCount> RemoveContractProvidersAsync(
        string contractId,
        RemoveContractProvidersRequest request,
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
