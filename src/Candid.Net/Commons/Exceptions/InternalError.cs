using global::Candid.Net.Core;

namespace Candid.Net.Commons;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InternalError(
    InternalErrorMessage body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("InternalError", 500, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new InternalErrorMessage Body => body;
}
