using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Guarantor.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Creates a new guarantor and returns the newly created Guarantor object.
    /// </summary>
    WithRawResponseTask<Guarantor> CreateAsync(
        string encounterId,
        GuarantorCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a guarantor by its `guarantor_id`.
    /// </summary>
    WithRawResponseTask<Guarantor> GetAsync(
        string guarantorId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a guarantor by its `guarantor_id`.
    /// </summary>
    WithRawResponseTask<Guarantor> UpdateAsync(
        string guarantorId,
        GuarantorUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
