using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Contracts.V4;

public partial interface IV4Client
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

    /// <summary>
    /// Deprecated. This endpoint is a temporary holdover from Contracts V3 and will be removed in a future release.
    /// Use the dedicated service facility provider endpoints to manage providers
    /// (GET/POST/DELETE /api/contracts/v4/{contract_id}/service-facilities/{contract_service_facility_id}/providers).
    /// </summary>
    WithRawResponseTask<ContractServiceFacility> UpdateContractServiceFacilityAsync(
        string contractId,
        string contractServiceFacilityId,
        ContractServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of providers associated with a contract service facility.
    /// </summary>
    WithRawResponseTask<ContractProvidersPage> GetContractServiceFacilityProvidersAsync(
        string contractId,
        string contractServiceFacilityId,
        GetContractServiceFacilityProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Appends provider IDs to the contract service facility. Provider IDs already on the facility are silently ignored.
    /// </summary>
    WithRawResponseTask<AddContractServiceFacilityProvidersResponse> AddContractServiceFacilityProvidersAsync(
        string contractId,
        string contractServiceFacilityId,
        AddContractServiceFacilityProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the specified provider IDs from the contract service facility. Returns a 404 if any of the provided IDs are not currently associated.
    /// </summary>
    WithRawResponseTask<ContractServiceFacilityProviderCount> RemoveContractServiceFacilityProvidersAsync(
        string contractId,
        string contractServiceFacilityId,
        RemoveContractServiceFacilityProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
