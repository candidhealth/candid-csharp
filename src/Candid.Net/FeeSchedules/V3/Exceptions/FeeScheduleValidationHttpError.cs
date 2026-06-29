using global::Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class FeeScheduleValidationHttpError(
    IEnumerable<RateUploadWithPossibleErrors> body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("FeeScheduleValidationHttpError", 422, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new IEnumerable<RateUploadWithPossibleErrors> Body => body;
}
