using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class EntityNotFoundError(EntityNotFoundErrorMessage body)
    : CandidApiException("EntityNotFoundError", 404, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EntityNotFoundErrorMessage Body { get; } = body;
}
