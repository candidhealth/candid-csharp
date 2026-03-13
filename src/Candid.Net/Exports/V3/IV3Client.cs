using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Exports.V3;

public partial interface IV3Client
{
    /// <summary>
    /// &lt;Warning&gt;
    /// API-based exports are in the process of being deprecated in favor of Candid Data Share and are not being offered to new customers.
    /// Please see the [Candid Data Share docs](https://docs.joincandidhealth.com/introduction/candid-data-share) for more information.
    /// &lt;/Warning&gt;
    ///
    /// Retrieve CSV-formatted reports on claim submissions and outcomes. This endpoint returns Export objects that contain an
    /// authenticated URL to a customer's reports with a 2min TTL. The schema for the CSV export can be found [here](https://app.joincandidhealth.com/files/exports_schema.csv).
    ///
    /// **Schema changes:** Changing column order, removing columns, or changing the name of a column is considered a
    /// [Breaking Change](../../../api-principles/breaking-changes). Adding new columns to the end of the Exports file is not considered a
    /// Breaking Change and happens periodically. For this reason, it is important that any downstream automation or processes built on top
    /// of Candid Health's export files be resilient to the addition of new columns at the end of the file.
    ///
    /// **SLA guarantees:** Files for a given date are guaranteed to be available after 3 business days. For example, Friday's file will be
    /// available by Wednesday at the latest. If file generation is still in progress upon request before 3 business days have passed, the
    /// caller will receive a 422 response. If the file has already been generated, it will be served. Historic files should be available
    /// up to 90 days in the past by default. Please email our [Support team](mailto:support@joincandidhealth.com) with any data requests
    /// outside of these stated guarantees.
    /// </summary>
    WithRawResponseTask<GetExportsResponse> GetExportsAsync(
        GetExportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
