using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Eligibility.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// This API is a wrapper around Change Healthcare's eligibility API. Below are some helpful documentation links:
    ///
    /// - [Change Healthcare - Guides: Contents of the Eligibility Request Body](https://developers.changehealthcare.com/eligibilityandclaims/docs/contents-of-the-eligibility-request-body)
    /// - [Change Healthcare - Guides: Use "Bare Minimum" Eligibility Requests](https://developers.changehealthcare.com/eligibilityandclaims/docs/use-bare-minimum-eligibility-requests)
    /// - [Change Healthcare - Guides: Contents of the Eligibility Response](https://developers.changehealthcare.com/eligibilityandclaims/docs/contents-of-the-eligibility-response)
    /// - [Change Healthcare - Guides: Eligibility JSON-to-EDI API Contents](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-json-to-edi-api-contents)
    /// - [Change Healthcare - Guides: Eligibility Error Messages](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-error-messages)
    /// - [Change Healthcare - Guides: FAQ](https://developers.changehealthcare.com/eligibilityandclaims/docs/frequently-asked-questions)
    /// - [Change Healthcare - Guides: Eligibility FAQs](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-api-requests)
    /// - [Change Healthcare - Guides: Sandbox API Values and Test Responses](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-sandbox-api-values-and-test-responses)
    /// - [Change Healthcare - Guides: Sandbox Predefined Fields and Values](https://developers.changehealthcare.com/eligibilityandclaims/docs/sandbox-predefined-fields-and-values)
    /// - [Change Healthcare - Guides: Using Test Payers in the Sandbox](https://developers.changehealthcare.com/eligibilityandclaims/docs/use-the-test-payers-in-the-sandbox-api)
    ///
    /// A schema of the response object can be found here: [Change Healthcare Docs](https://developers.changehealthcare.com/eligibilityandclaims/reference/medicaleligibility)
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Eligibility.V2.SubmitEligibilityCheckAsync(
    ///     new Dictionary&lt;object, object?&gt;() { { "key", "value" } }
    /// );
    /// </code>
    /// </example>
    public async Task<object> SubmitEligibilityCheckAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/eligibility/v2",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
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
    ///
    /// - Note Availity requires a free developer account to access this documentation.
    ///
    /// Check connection status of Availity API and partners here:
    ///
    /// - [Availity Trading Partner Connection Status](https://www.availity.com/status/)
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Eligibility.V2.SubmitEligibilityCheckAvailityAsync();
    /// </code>
    /// </example>
    public async Task<object> SubmitEligibilityCheckAvailityAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/eligibility/v2/availity",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint
    ///
    /// This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:
    ///
    /// - [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
    /// - [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)
    ///
    /// A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)
    ///
    /// - Note Availity requires a free developer account to access this documentation.
    ///
    /// Check connection status of Availity API and partners here:
    ///
    /// - [Availity Trading Partner Connection Status](https://www.availity.com/status/)
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Eligibility.V2.SubmitEligibilityCheckAvailityPostAsync(
    ///     new Dictionary&lt;object, object?&gt;() { { "key", "value" } }
    /// );
    /// </code>
    /// </example>
    public async Task<object> SubmitEligibilityCheckAvailityPostAsync(
        object request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/eligibility/v2/availity",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
