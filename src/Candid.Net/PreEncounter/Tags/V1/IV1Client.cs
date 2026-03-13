using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Tags.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Gets a tag by TagId.
    /// </summary>
    WithRawResponseTask<Tag> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets all tags. Defaults to page size of 1000.
    /// </summary>
    WithRawResponseTask<TagPage> GetAllAsync(
        GetAllTagsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a new tag if it does not already exist, otherwise, returns the existing tag.
    /// </summary>
    WithRawResponseTask<Tag> CreateAsync(
        MutableTag request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a tag. The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask<Tag> UpdateAsync(
        string id,
        string version,
        MutableTag request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets a tag as deactivated.  The path must contain the most recent version to prevent races.
    /// </summary>
    global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
