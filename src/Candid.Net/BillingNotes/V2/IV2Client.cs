using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.BillingNotes.V2;

public partial interface IV2Client
{
    WithRawResponseTask<BillingNote> CreateAsync(
        StandaloneBillingNoteCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string billingNoteId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<BillingNote> UpdateAsync(
        string billingNoteId,
        BillingNoteUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
