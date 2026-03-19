using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Payers.V3;

public partial interface IV3Client
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
