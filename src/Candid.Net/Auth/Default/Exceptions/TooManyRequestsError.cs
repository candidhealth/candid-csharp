using Candid.Net.Core;

namespace Candid.Net.Auth.Default;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class TooManyRequestsError(TooManyRequestsErrorType body)
    : CandidApiException("TooManyRequestsError", 429, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new TooManyRequestsErrorType Body => body;
}
