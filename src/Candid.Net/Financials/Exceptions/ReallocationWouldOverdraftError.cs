using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ReallocationWouldOverdraftError(ReallocationWouldOverdraftErrorContent body)
    : CandidApiException("ReallocationWouldOverdraftError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ReallocationWouldOverdraftErrorContent Body => body;
}
