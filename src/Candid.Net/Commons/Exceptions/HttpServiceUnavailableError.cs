using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class HttpServiceUnavailableError(HttpServiceUnavailableErrorMessage body)
    : CandidApiException("HttpServiceUnavailableError", 503, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new HttpServiceUnavailableErrorMessage Body => body;
}
