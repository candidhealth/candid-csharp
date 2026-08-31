using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.EnterpriseConfig.V1;

public partial interface IV1Client
{
    WithRawResponseTask<EnterprisePermissions> GetAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
