using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

public partial interface IV3Client
{
    /// <summary>
    /// Gets the rate that matches a service line.  No result means no rate exists matching the service line's dimensions.
    /// </summary>
    WithRawResponseTask<MatchResult?> GetMatchAsync(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Tests a service line against a rate to see if it matches.
    /// </summary>
    WithRawResponseTask<MatchTestResult> TestMatchAsync(
        string serviceLineId,
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a list of dimensions with their rates. The rates returned will always be the most recent versions of those rates.
    /// </summary>
    WithRawResponseTask<RatesPage> GetMultiAsync(
        GetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets unique values for a dimension based on other selection criteria. The response is a list of dimensions with your criteria and the unique values populated. This API is useful for driving pivots on dimension values.
    /// </summary>
    WithRawResponseTask<DimensionsPage> GetUniqueValuesForDimensionAsync(
        GetUniqueDimensionValuesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets every version of a rate.
    /// </summary>
    WithRawResponseTask<IEnumerable<Rate>> GetRateHistoryAsync(
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Uploads a new fee schedule.
    ///
    /// Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.
    ///
    /// If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will
    /// be returned.
    ///
    /// Use the dry run flag to discover already existing rates and to run validations.  If validations for any rate fail, no rates will
    /// be saved to the system.
    /// </summary>
    WithRawResponseTask<IEnumerable<Rate>> UploadFeeScheduleAsync(
        FeeScheduleUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Soft deletes a rate from the system.  Only the most recent version of a rate can be deleted.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteRateAsync(
        string rateId,
        int version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets the default payer threshold
    /// </summary>
    WithRawResponseTask<PayerThreshold> GetPayerThresholdsDefaultAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets a list of payers and thresholds by their uuids
    /// </summary>
    WithRawResponseTask<PayerThresholdsPage> GetPayerThresholdsAsync(
        PayerThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets the threshold information for a payer
    /// </summary>
    WithRawResponseTask<PayerThreshold> SetPayerThresholdAsync(
        string payerUuid,
        PayerThreshold request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Hard deletes rates from the system that match the provided dimensions.  This is a destructive operation and cannot be undone.  If an empty dimensions object is provided, all rates will be hard deleted.  The maximum number of rates this API will delete at a time is 10000.  Returns the number of rates deleted and if that number is the maximum, the caller should call this API again to continue deleting rates.
    /// </summary>
    WithRawResponseTask<int> HardDeleteRatesAsync(
        OptionalDimensions request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Hard deletes specific rates from the system by their IDs. This is a destructive operation and cannot be undone. Limited to 100 rate IDs maximum per request. For bulk deletion of more than 100 rates, use the hard_delete_rates endpoint with dimension filters. Returns the number of rates deleted.
    /// </summary>
    WithRawResponseTask<int> HardDeleteRatesByIdsAsync(
        HardDeleteRatesByIdsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
