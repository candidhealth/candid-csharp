using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Payers.V4;

public partial interface IV4Client
{
    WithRawResponseTask<Payer> GetAsync(
        string payerUuid,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<PayerPage> GetAllAsync(
        GetAllPayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
