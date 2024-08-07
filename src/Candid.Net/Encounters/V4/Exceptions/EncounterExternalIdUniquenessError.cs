using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class EncounterExternalIdUniquenessError(EncounterExternalIdUniquenessErrorType body)
    : CandidApiException("EncounterExternalIdUniquenessError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EncounterExternalIdUniquenessErrorType Body { get; } = body;
}