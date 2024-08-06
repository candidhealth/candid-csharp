using Candid.Net.Core;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class ExpectedNetworkStatusCheckError(ExpectedNetworkStatusCheckErrorMessage body)
    : CandidApiException("ExpectedNetworkStatusCheckError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ExpectedNetworkStatusCheckErrorMessage Body { get; } = body;
}
