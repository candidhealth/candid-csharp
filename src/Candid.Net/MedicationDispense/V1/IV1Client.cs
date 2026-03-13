using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.MedicationDispense.V1;

public partial interface IV1Client
{
    WithRawResponseTask<global::Candid.Net.Encounters.V4.Encounter> CreateAsync(
        MedicationDispenseCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
