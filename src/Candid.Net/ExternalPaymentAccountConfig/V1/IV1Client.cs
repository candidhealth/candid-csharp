using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public partial interface IV1Client
{
    WithRawResponseTask<ExternalPaymentAccountConfigPage> GetMultiAsync(
        GetExternalPaymentAccountConfigsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
