using global::Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ContractIsLinkedToFeeScheduleHttpError(
    ContractIsLinkedToFeeScheduleError body,
    global::Candid.Net.RawResponse? rawResponse = null
)
    : CandidApiException(
        "ContractIsLinkedToFeeScheduleHttpError",
        422,
        body,
        rawResponse: rawResponse
    )
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ContractIsLinkedToFeeScheduleError Body => body;
}
