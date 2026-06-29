using global::Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class SchemaValidationHttpFailure(
    SchemaValidationFailure body,
    global::Candid.Net.RawResponse? rawResponse = null
) : CandidApiException("SchemaValidationHttpFailure", 422, body, rawResponse: rawResponse)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new SchemaValidationFailure Body => body;
}
