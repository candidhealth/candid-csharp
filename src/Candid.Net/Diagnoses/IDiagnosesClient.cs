using global::Candid.Net;
using global::Candid.Net.Core;

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
    WithRawResponseTask DeleteAsync(
        string diagnosisId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
