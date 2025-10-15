using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class InvalidFiltersError(InvalidFiltersErrorType body)
    : CandidApiException("InvalidFiltersError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new InvalidFiltersErrorType Body => body;
}
