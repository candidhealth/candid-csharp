using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class ExpectedNetworkStatusCheckError(ExpectedNetworkStatusCheckErrorMessage body)
    : CandidClientApiException("ExpectedNetworkStatusCheckError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ExpectedNetworkStatusCheckErrorMessage Body { get; } = body;
}
