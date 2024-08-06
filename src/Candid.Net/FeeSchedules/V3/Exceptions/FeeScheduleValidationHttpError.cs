using Candid.Net.Core;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class FeeScheduleValidationHttpError(IEnumerable<RateUploadWithPossibleErrors> body)
    : CandidApiException("FeeScheduleValidationHttpError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new IEnumerable<RateUploadWithPossibleErrors> Body { get; } = body;
}
