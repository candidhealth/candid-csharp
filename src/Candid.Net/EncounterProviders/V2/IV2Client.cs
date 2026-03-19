using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.EncounterProviders.V2;

public partial interface IV2Client
{
    WithRawResponseTask<EncounterProvider> UpdateReferringProviderAsync(
        string encounterId,
        ReferringProviderUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> UpdateInitialReferringProviderAsync(
        string encounterId,
        InitialReferringProviderUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> UpdateSupervisingProviderAsync(
        string encounterId,
        SupervisingProviderUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> UpdateOrderingProviderAsync(
        string serviceLineId,
        OrderingProviderUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> CreateReferringProviderAsync(
        string encounterId,
        ReferringProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> CreateInitialReferringProviderAsync(
        string encounterId,
        InitialReferringProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> CreateSupervisingProviderAsync(
        string encounterId,
        SupervisingProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EncounterProvider> CreateOrderingProviderAsync(
        string serviceLineId,
        OrderingProvider request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteReferringProviderAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteInitialReferringProviderAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteSupervisingProviderAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteOrderingProviderAsync(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
