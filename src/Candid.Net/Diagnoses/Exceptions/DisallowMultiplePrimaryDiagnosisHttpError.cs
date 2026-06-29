using global::Candid.Net.Core;

namespace Candid.Net.Diagnoses;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class DisallowMultiplePrimaryDiagnosisHttpError(
    DisallowMultiplePrimaryDiagnosisError body,
    global::Candid.Net.RawResponse? rawResponse = null
)
    : CandidApiException(
        "DisallowMultiplePrimaryDiagnosisHttpError",
        422,
        body,
        rawResponse: rawResponse
    )
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new DisallowMultiplePrimaryDiagnosisError Body => body;
}
