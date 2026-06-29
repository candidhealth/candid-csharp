using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Sends real-time eligibility checks to payers through Stedi.
    /// </summary>
    WithRawResponseTask<EligibilityCheck> PostAsync(
        EligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a batch of eligibility checks to payers through Stedi.
    /// </summary>
    WithRawResponseTask<BatchEligibilityResponse> BatchAsync(
        IEnumerable<EligibilityRequest> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Polls the status of a batch eligibility check.
    /// </summary>
    WithRawResponseTask<EligibilityCheckPage> PollBatchAsync(
        string batchId,
        BatchEligibilityPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Searches for payers that match the query parameters.
    /// </summary>
    WithRawResponseTask<PayerSearchResponse> PayerSearchAsync(
        PayerSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Gets recommendation for eligibility checks based on filters. This endpoint will retrieve all the latest eligibility recommendations for each
    /// eligibility recommendation type for the given filters. If you want to get a specific recommendation type, you can use the `type` query parameter.
    /// </summary>
    WithRawResponseTask<IEnumerable<EligibilityRecommendation>> RecommendationAsync(
        EligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an eligibiilty recommendation based on the request.
    /// </summary>
    WithRawResponseTask<EligibilityRecommendation> CreateRecommendationAsync(
        PostEligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Submit user feedback on an eligibility recommendation. The path must contain the next version number to prevent race conditions. For example, if the current version of the recommendation is n, you will need to send a request to this endpoint with `/{recommendation_id}/{n+1}/vote` to update the vote.
    /// </summary>
    WithRawResponseTask<EligibilityRecommendation> VoteRecommendationAsync(
        string recommendationId,
        string version,
        Vote request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<EligibilityCheckPage> GetMultiAsync(
        EligibilityChecksGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends an insurance discovery check to find potential coverage matches for a patient through Stedi.
    /// Given patient demographics, this endpoint discovers what insurance coverages exist for the patient.
    /// </summary>
    WithRawResponseTask<InsuranceDiscoveryResponse> InsuranceDiscoveryAsync(
        InsuranceDiscoveryRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sends a coordination of benefits check through Stedi to determine whether a patient has
    /// coverage overlap across multiple payers and, if so, which payer is primary.
    /// Medicare and Medicare Advantage plans are not supported.
    /// </summary>
    WithRawResponseTask<CoordinationOfBenefitsResponse> CoordinationOfBenefitsAsync(
        CoordinationOfBenefitsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
