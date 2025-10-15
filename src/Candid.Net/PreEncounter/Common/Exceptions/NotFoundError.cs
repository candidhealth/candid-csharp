using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotFoundError(ErrorBase4Xx body) : CandidApiException("NotFoundError", 404, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ErrorBase4Xx Body => body;
}
