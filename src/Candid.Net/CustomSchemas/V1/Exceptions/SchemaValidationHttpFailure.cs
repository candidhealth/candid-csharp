using Candid.Net.Core;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class SchemaValidationHttpFailure(SchemaValidationFailure body)
    : CandidApiException("SchemaValidationHttpFailure", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new SchemaValidationFailure Body => body;
}
