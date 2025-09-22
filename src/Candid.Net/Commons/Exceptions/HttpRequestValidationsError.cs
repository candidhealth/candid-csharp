using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class HttpRequestValidationsError(IEnumerable<RequestValidationError> body)
    : CandidApiException("HttpRequestValidationsError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new IEnumerable<RequestValidationError> Body => body;
}
