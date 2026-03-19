using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Adds an image.  VersionConflictError is returned if a front or back of this coverage already exists.
    /// </summary>
    WithRawResponseTask<Image> CreateAsync(
        MutableImage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets an image by imageId.
    /// </summary>
    WithRawResponseTask<Image> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an Image.  The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask<Image> UpdateAsync(
        string id,
        string version,
        MutableImage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets an Image as deactivated.  The path must contain the most recent version to prevent races.
    /// </summary>
    global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for images that match the query parameters.
    /// </summary>
    WithRawResponseTask<IEnumerable<Image>> GetMultiAsync(
        ImageGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
