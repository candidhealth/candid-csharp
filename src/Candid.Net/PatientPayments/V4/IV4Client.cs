using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PatientPayments.V4;

public partial interface IV4Client
{
    /// <summary>
    /// Returns all patient payments satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    WithRawResponseTask<PatientPaymentsPage> GetMultiAsync(
        GetMultiPatientPaymentsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created patient payment by its `patient_payment_id`.
    /// </summary>
    WithRawResponseTask<PatientPayment> GetAsync(
        string patientPaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new patient payment record and returns the newly created PatientPayment object.
    /// The allocations can describe whether the payment is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    WithRawResponseTask<PatientPayment> CreateAsync(
        PatientPaymentCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the patient payment record matching the provided patient_payment_id.
    /// </summary>
    WithRawResponseTask<PatientPayment> UpdateAsync(
        string patientPaymentId,
        PatientPaymentUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the patient payment record matching the provided patient_payment_id.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string patientPaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
