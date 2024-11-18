using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class InvalidMrnError(InvalidMrnErrorBody body)
    : CandidApiException("InvalidMrnError", 400, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new InvalidMrnErrorBody Body => body;
}
