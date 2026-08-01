using global::Candid.Net.Core;

namespace Candid.Net.Users.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class M2MUserFailedToCreateHttpError(
    M2MUserFailedToCreateError body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("M2MUserFailedToCreateHttpError", 500, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new M2MUserFailedToCreateError Body => body;
}
