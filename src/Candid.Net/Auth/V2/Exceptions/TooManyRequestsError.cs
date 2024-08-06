using Candid.Net.Auth.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Auth.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class TooManyRequestsError(TooManyRequestsErrorType body)
    : CandidApiException("TooManyRequestsError", 429, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new TooManyRequestsErrorType Body { get; } = body;
}
