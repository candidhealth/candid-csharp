using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Exports.V3;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class ExportNotYetAvailableError(string body)
    : CandidApiException("ExportNotYetAvailableError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new string Body { get; } = body;
}
