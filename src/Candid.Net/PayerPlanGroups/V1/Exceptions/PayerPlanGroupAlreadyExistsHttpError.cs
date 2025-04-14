using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class PayerPlanGroupAlreadyExistsHttpError(PayerPlanGroupAlreadyExistsError body)
    : CandidApiException("PayerPlanGroupAlreadyExistsHttpError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new PayerPlanGroupAlreadyExistsError Body => body;
}
