using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Eligibility.V2;

public partial interface IV2Client
{
    /// <summary>
    /// &lt;Tip&gt;Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
    /// For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.&lt;/Tip&gt;
    ///
    /// **Availity has transitioned their GET endpoint to a POST endpoint. Candid has updated their pass-through integration to enable backwards compatibility for the GET endpoint so that customers do not have to immediately update their integrations.**
    ///
    /// **Candid recommends integrations with the [POST endpoint](https://docs.joincandidhealth.com/api-reference/eligibility/v-2/submit-eligibility-check-availity-post) to ensure the best possible integration experience. Given the transition, Availity’s documentation will be out of sync with this endpoint.**
    ///
    /// If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint
    ///
    /// This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:
    ///
    /// - [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
    /// - [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)
    ///
    /// A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)
    /// * Note Availity requires a free developer account to access this documentation.
    ///
    /// Check connection status of Availity API and partners here:
    /// - [Availity Trading Partner Connection Status](https://www.availity.com/status/)
    /// </summary>
    WithRawResponseTask<object> SubmitEligibilityCheckAvailityAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// &lt;Tip&gt;Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
    /// For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.&lt;/Tip&gt;
    ///
    /// If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint
    ///
    /// This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:
    ///
    /// - [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
    /// - [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)
    ///
    /// A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)
    /// * Note Availity requires a free developer account to access this documentation.
    ///
    /// Check connection status of Availity API and partners here:
    /// - [Availity Trading Partner Connection Status](https://www.availity.com/status/)
    /// </summary>
    WithRawResponseTask<object> SubmitEligibilityCheckAvailityPostAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
