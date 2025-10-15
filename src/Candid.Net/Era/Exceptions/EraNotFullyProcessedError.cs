using Candid.Net.Core;

namespace Candid.Net.Era;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class EraNotFullyProcessedError(EraNotFullyProcessedErrorMessage body)
    : CandidApiException("EraNotFullyProcessedError", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EraNotFullyProcessedErrorMessage Body => body;
}
