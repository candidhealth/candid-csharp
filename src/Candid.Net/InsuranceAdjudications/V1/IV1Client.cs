using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.InsuranceAdjudications.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Retrieves a previously created insurance adjudication by its `insurance_adjudication_id`.
    /// </summary>
    WithRawResponseTask<InsuranceAdjudication> GetAsync(
        string insuranceAdjudicationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
