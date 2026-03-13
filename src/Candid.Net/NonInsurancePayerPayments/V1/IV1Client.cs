using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerPayments.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all non-insurance payer payments
    /// </summary>
    WithRawResponseTask<NonInsurancePayerPaymentsPage> GetMultiAsync(
        GetMultiNonInsurancePayerPaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created non-insurance payer payment by its `non_insurance_payer_payment_id`.
    /// </summary>
    WithRawResponseTask<NonInsurancePayerPayment> GetAsync(
        string nonInsurancePayerPaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayerPayment> CreateAsync(
        NonInsurancePayerPaymentCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayerPayment> UpdateAsync(
        string nonInsurancePayerPaymentId,
        UpdateNonInsurancePayerPaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the non-insurance payer payment record matching the provided `non_insurance_payer_payment_id`.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerPaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
