using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EncounterSummaries.V1;

namespace Candid.Net.Views.Dynamic.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Resolves a dynamic view to the EncounterSummaries currently present in this view.
    /// Body parameters can include sorting controls.
    /// </summary>
    WithRawResponseTask<EncounterSummaryPage> ResolveAsync(
        string claimDynamicViewId,
        ResolveDynamicView request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
