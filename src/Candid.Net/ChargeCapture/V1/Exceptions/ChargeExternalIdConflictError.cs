using Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ChargeExternalIdConflictError(ChargeExternalIdConflictErrorMessage body)
    : CandidApiException("ChargeExternalIdConflictError", 409, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ChargeExternalIdConflictErrorMessage Body => body;
}
