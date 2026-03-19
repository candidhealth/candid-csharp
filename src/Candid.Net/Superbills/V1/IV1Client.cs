using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Superbills.V1;

public partial interface IV1Client
{
    WithRawResponseTask<SuperbillResponse> CreateSuperbillAsync(
        CreateSuperbillRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
