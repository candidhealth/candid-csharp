using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all custom schemas.
    /// </summary>
    WithRawResponseTask<SchemaGetMultiResponse> GetMultiAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a custom schema with a given ID.
    /// </summary>
    WithRawResponseTask<Schema> GetAsync(
        string schemaId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create custom schema with a set of typed keys. Schema keys can be referenced as inputs in user-configurable rules in the Rules
    /// Engine, and key-value pairs can be attached to claims via the Encounters API.
    /// </summary>
    WithRawResponseTask<Schema> CreateAsync(
        SchemaCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the name, description, or keys on a preexisting schema.
    /// </summary>
    WithRawResponseTask<Schema> UpdateAsync(
        string schemaId,
        SchemaUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
