using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class PotentialDuplicatePatients(PotentialDuplicatePatientsErrorBody body)
    : CandidApiException("PotentialDuplicatePatients", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new PotentialDuplicatePatientsErrorBody Body => body;
}
