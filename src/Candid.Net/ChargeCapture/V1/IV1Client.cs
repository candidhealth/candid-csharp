using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

public partial interface IV1Client
{
    WithRawResponseTask<ChargeCapture> CreateAsync(
        CreateChargeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a Charge Capture from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// At encounter creation time, information from the provided patient and appointment objects will be populated
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///   - Patient
    ///   - Referring Provider
    ///   - Subscriber Primary
    ///   - Subscriber Secondary
    ///   - Referral Number
    ///   - Responsible Party
    ///   - Guarantor
    ///
    /// Note that these fields should not be populated in the ChargeCaptureData property of this endpoint, as they will be overwritten at encounter creation time.
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    /// </summary>
    WithRawResponseTask<ChargeCapture> CreateFromPreEncounterPatientAsync(
        CreateChargeCaptureFromPreEncounterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<IEnumerable<ChargeCapturePostBilledChange>> UpdatePostBilledChangesAsync(
        ChargeCapturePostBilledChangeUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ChargeCapture> UpdateAsync(
        string chargeCaptureId,
        ChargeCaptureUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ChargeCapture> GetAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ChargeCapturePage> GetAllAsync(
        GetAllChargeCapturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
