using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.MetadataSchemas.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Gets a custom metadata schema by MetadataSchemaId.
    /// </summary>
    WithRawResponseTask<MetadataSchema> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets all custom metadata schemas for the organization, ordered by name. Defaults to page size of 100.
    /// </summary>
    WithRawResponseTask<MetadataSchemaPage> GetAllAsync(
        GetAllMetadataSchemasRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new custom metadata schema. Schema names must be unique within an organization.
    /// </summary>
    WithRawResponseTask<MetadataSchema> CreateAsync(
        MutableMetadataSchema request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a custom metadata schema. Updates are additive only: new fields may be added but existing fields may not be removed or have their type changed, and ENUM field value lists may be extended but not shrunk. The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask<MetadataSchema> UpdateAsync(
        string id,
        string version,
        MutableMetadataSchema request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets a custom metadata schema as deactivated. The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Removes the deactivated flag for a custom metadata schema. The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask ReactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
