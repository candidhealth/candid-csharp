using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class VersionConflictError(VersionConflictErrorBody body)
    : CandidApiException("VersionConflictError", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new VersionConflictErrorBody Body => body;
}
