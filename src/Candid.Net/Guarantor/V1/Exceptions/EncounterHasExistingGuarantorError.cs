using global::Candid.Net.Core;

namespace Candid.Net.Guarantor.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class EncounterHasExistingGuarantorError(
    EncounterHasExistingGuarantorErrorType body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("EncounterHasExistingGuarantorError", 409, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EncounterHasExistingGuarantorErrorType Body => body;
}
