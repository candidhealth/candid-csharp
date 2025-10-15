using Candid.Net.Core;

namespace Candid.Net.Commons;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class EntityConflictError(EntityConflictErrorMessage body)
    : CandidApiException("EntityConflictError", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EntityConflictErrorMessage Body => body;
}
