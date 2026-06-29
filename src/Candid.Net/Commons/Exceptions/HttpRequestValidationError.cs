using global::Candid.Net.Core;

namespace Candid.Net.Commons;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class HttpRequestValidationError(
    RequestValidationError body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("HttpRequestValidationError", 422, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new RequestValidationError Body => body;
}
