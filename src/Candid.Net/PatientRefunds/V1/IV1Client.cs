using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientRefunds.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all patient refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    WithRawResponseTask<PatientRefundsPage> GetMultiAsync(
        GetMultiPatientRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created patient refund by its `patient_refund_id`.
    /// </summary>
    WithRawResponseTask<PatientRefund> GetAsync(
        string patientRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new patient refund record and returns the newly created PatientRefund object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    WithRawResponseTask<PatientRefund> CreateAsync(
        PatientRefundCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the patient refund record matching the provided patient_refund_id.
    /// </summary>
    WithRawResponseTask<PatientRefund> UpdateAsync(
        string patientRefundId,
        PatientRefundUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the patient refund record matching the provided patient_refund_id.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string patientRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
