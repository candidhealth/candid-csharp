using Candid.Net.Core;

namespace Candid.Net.Auth.Default;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InvalidContentTypeError(InvalidContentTypeErrorType body)
    : CandidApiException("InvalidContentTypeError", 415, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new InvalidContentTypeErrorType Body => body;
}
