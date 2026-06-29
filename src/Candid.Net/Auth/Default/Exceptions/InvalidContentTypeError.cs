using global::Candid.Net.Core;

namespace Candid.Net.Auth.Default;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InvalidContentTypeError(
    InvalidContentTypeErrorType body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("InvalidContentTypeError", 415, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new InvalidContentTypeErrorType Body => body;
}
