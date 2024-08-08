using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class NotFoundError(NotFoundErrorBody body)
    : CandidClientApiException("NotFoundError", 404, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new NotFoundErrorBody Body { get; } = body;
}
