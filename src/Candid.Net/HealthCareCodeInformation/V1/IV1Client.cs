using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

public partial interface IV1Client
{
    WithRawResponseTask<HealthCareCodeInformationGetAllResponse> UpdateAsync(
        string encounterId,
        HealthCareCodeInformationUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<HealthCareCodeInformationGetAllResponse> GetAllForEncounterAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
