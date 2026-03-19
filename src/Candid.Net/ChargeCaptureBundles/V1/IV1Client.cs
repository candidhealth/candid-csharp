using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

public partial interface IV1Client
{
    WithRawResponseTask<ChargeCaptureClaimCreation> GetAsync(
        string chargeCaptureClaimCreationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ChargeCaptureClaimCreationSummary> GetSummaryAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task ResolveChargeCreationErrorAsync(
        string chargeCaptureBundleErrorId,
        ChargeCaptureBundleErrorResolution request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ChargeCaptureClaimCreationPage> GetAllAsync(
        GetAllChargeCaptureClaimCreationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
