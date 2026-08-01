using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Users.V2;

public partial interface IV2Client
{
    /// <summary>
    /// Provisions a machine-to-machine (M2M) API user. Requires `organization_id`.
    /// </summary>
    WithRawResponseTask<M2MUserResponse> CreateM2MUserV2Async(
        M2MUserCreateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
