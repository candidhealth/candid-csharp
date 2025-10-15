using Candid.Net.Core;

namespace Candid.Net.Exports.V3;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ExportDateTooEarlyError(string body)
    : CandidApiException("ExportDateTooEarlyError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new string Body => body;
}
