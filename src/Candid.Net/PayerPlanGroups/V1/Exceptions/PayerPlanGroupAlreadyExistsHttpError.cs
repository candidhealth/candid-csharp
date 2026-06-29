using global::Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class PayerPlanGroupAlreadyExistsHttpError(
    PayerPlanGroupAlreadyExistsError body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("PayerPlanGroupAlreadyExistsHttpError", 422, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new PayerPlanGroupAlreadyExistsError Body => body;
}
