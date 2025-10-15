using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ExpectedNetworkStatusCheckError(ExpectedNetworkStatusCheckErrorMessage body)
    : CandidApiException("ExpectedNetworkStatusCheckError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ExpectedNetworkStatusCheckErrorMessage Body => body;
}
