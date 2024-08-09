using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class EncounterPatientControlNumberUniquenessError(
    EncounterPatientControlNumberUniquenessErrorType body
) : CandidApiException("EncounterPatientControlNumberUniquenessError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EncounterPatientControlNumberUniquenessErrorType Body { get; } = body;
}
