using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Adds an appointment.  VersionConflictError is returned when the placer_appointment_id is already in use.
    /// </summary>
    WithRawResponseTask<Appointment> CreateAsync(
        MutableAppointment request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets all Visits within a given time range. The return list is ordered by start_time ascending.
    ///
    /// **IMPORTANT:** This endpoint requires a date filter on `appointment.startTimestamp` to ensure acceptable query performance.
    /// Without date filtering, the query can take 50+ seconds on large datasets due to grouping and aggregation operations.
    ///
    /// Example filters:
    /// - `appointment.startTimestamp|gt|2024-01-01` - appointments after January 1, 2024
    /// - `appointment.startTimestamp|eq|2024-12-08` - appointments on December 8, 2024
    /// - `appointment.startTimestamp|lt|2024-12-31` - appointments before December 31, 2024
    ///
    /// You can combine the date filter with other filters using commas:
    /// - `appointment.startTimestamp|gt|2024-01-01,appointment.status|eq|PENDING`
    /// </summary>
    WithRawResponseTask<VisitsPage> GetVisitsAsync(
        VisitsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets an appointment.
    /// </summary>
    WithRawResponseTask<Appointment> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets an appointment along with it's full history.  The return list is ordered by version ascending.
    /// </summary>
    WithRawResponseTask<IEnumerable<Appointment>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates an appointment. The path must contain the next version number to prevent race conditions. For example, if the current version of the appointment is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the appointment. Updating historic versions is not supported.
    /// </summary>
    WithRawResponseTask<Appointment> UpdateAsync(
        string id,
        string version,
        MutableAppointment request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Scans up to 100 appointment updates.  The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    /// </summary>
    WithRawResponseTask<IEnumerable<Appointment>> ScanAsync(
        AppointmentScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets an appointment as deactivated.  The path must contain the most recent version to prevent race conditions.  Deactivating historic versions is not supported. Subsequent updates via PUT to the appointment will "reactivate" the appointment and set the deactivated flag to false.
    /// </summary>
    global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
