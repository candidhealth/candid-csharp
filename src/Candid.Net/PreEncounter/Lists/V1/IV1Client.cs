using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Gets patients with dependent objects for patients that match the query parameters.
    /// </summary>
    WithRawResponseTask<PatientListPage> GetPatientListAsync(
        PatientListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for appointments that match the query parameters.
    /// </summary>
    WithRawResponseTask<AppointmentListPage> GetAppointmentListAsync(
        AppointmentsGetListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
