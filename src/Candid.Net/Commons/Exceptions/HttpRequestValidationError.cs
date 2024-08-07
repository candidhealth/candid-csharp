using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class HttpRequestValidationError(RequestValidationError body)
    : CandidApiException("HttpRequestValidationError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new RequestValidationError Body { get; } = body;
}