using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

public partial interface IV1Client
{
    WithRawResponseTask<IEnumerable<EncounterAttachment>> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments. Deprecated: Use create-v2 instead.
    /// </summary>
    WithRawResponseTask<string> CreateAsync(
        string encounterId,
        CreateAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments.
    /// </summary>
    WithRawResponseTask<string> CreateWithDescriptionAsync(
        string encounterId,
        CreateAttachmentV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a file using an external identifier. For Charge Capture, the file will be associated with the Encounter at Encounter creation time.
    ///
    /// Note: Attachments created via this endpoint are not searchable via the get endpoint until they are associated with an encounter.
    /// </summary>
    WithRawResponseTask<string> CreateWithChargeCaptureExternalIdAsync(
        CreateExternalAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns all attachments associated with the given charge capture external ID.
    /// </summary>
    WithRawResponseTask<IEnumerable<ChargeCaptureAttachment>> GetByChargeCaptureExternalIdAsync(
        string chargeCaptureExternalId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes an attachment associated with the given charge capture external ID.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteByChargeCaptureExternalIdAsync(
        string chargeCaptureExternalId,
        DeleteExternalAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string encounterId,
        DeleteAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
