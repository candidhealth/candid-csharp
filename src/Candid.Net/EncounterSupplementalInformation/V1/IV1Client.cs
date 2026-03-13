using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.EncounterSupplementalInformation.V1;

public partial interface IV1Client
{
    WithRawResponseTask<IEnumerable<SupplementalInformation>> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SupplementalInformation> CreateAsync(
        string encounterId,
        CreateSupplementalInformationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<SupplementalInformation> UpdateAsync(
        string encounterId,
        string supplementalInformationId,
        UpdateSupplementalInformationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string encounterId,
        string supplementalInformationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
