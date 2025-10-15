using Candid.Net.Core;

namespace Candid.Net.Diagnoses;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class DiagnosisNotFoundHttpError(DiagnosisNotFoundError body)
    : CandidApiException("DiagnosisNotFoundHttpError", 404, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new DiagnosisNotFoundError Body => body;
}
