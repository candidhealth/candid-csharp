using Candid.Net.Core;
using Candid.Net.Guarantor.V1;

#nullable enable

namespace Candid.Net.Guarantor.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class EncounterHasExistingGuarantorError(EncounterHasExistingGuarantorErrorType body)
    : CandidApiException("EncounterHasExistingGuarantorError", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new EncounterHasExistingGuarantorErrorType Body { get; } = body;
}
