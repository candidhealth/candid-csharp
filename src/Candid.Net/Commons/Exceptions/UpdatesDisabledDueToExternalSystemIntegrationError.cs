using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class UpdatesDisabledDueToExternalSystemIntegrationError(
    UpdatesDisabledDueToExternalSystemIntegrationErrorMessage body
) : CandidApiException("UpdatesDisabledDueToExternalSystemIntegrationError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new UpdatesDisabledDueToExternalSystemIntegrationErrorMessage Body => body;
}
