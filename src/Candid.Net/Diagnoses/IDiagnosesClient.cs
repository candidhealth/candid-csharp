using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Diagnoses;

public partial interface IDiagnosesClient
{
    /// <summary>
    /// Creates a new diagnosis for an encounter
    /// </summary>
    WithRawResponseTask<Diagnosis> CreateAsync(
        StandaloneDiagnosisCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the diagnosis record matching the provided `diagnosis_id`
    /// </summary>
    WithRawResponseTask<Diagnosis> UpdateAsync(
        string diagnosisId,
        DiagnosisUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the diagnosis record associated with the provided `diagnosis_id`
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string diagnosisId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
