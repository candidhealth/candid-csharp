using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Events.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Scans the last 30 days of events. All results are sorted by created date, descending.
    /// </summary>
    WithRawResponseTask<EventScanPage> ScanAsync(
        GetEventScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Event> GetAsync(
        string eventId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
