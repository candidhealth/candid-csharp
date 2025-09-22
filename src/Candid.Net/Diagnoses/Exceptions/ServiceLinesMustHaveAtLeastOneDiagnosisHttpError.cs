using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Diagnoses;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class ServiceLinesMustHaveAtLeastOneDiagnosisHttpError(
    ServiceLinesMustHaveAtLeastOneDiagnosisError body
) : CandidApiException("ServiceLinesMustHaveAtLeastOneDiagnosisHttpError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ServiceLinesMustHaveAtLeastOneDiagnosisError Body => body;
}
