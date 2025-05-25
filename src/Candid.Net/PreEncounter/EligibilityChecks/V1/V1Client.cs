using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Sends real-time eligibility checks to payers through Stedi.
    /// &lt;Warning&gt;Please only send one concurrent request to this endpoint. Batch requests must be made in succession, otherwise, it will cause this service to fail. A batch endpoint is in development - please reach out to the Candid team for more information.&lt;/Warning&gt;
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.EligibilityChecks.V1.PostAsync(
    ///     new EligibilityRequest
    ///     {
    ///         PayerId = "payer_id",
    ///         Provider = new IndividualProvider { Npi = "npi" },
    ///         Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<EligibilityCheck> PostAsync(
        EligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/eligibility-checks/v1",
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
                return JsonUtils.Deserialize<EligibilityCheck>(responseBody)!;
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
    /// Sends a batch of eligibility checks to payers through Stedi.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.EligibilityChecks.V1.BatchAsync(
    ///     new List&lt;EligibilityRequest&gt;()
    ///     {
    ///         new EligibilityRequest
    ///         {
    ///             PayerId = "payer_id",
    ///             Provider = new IndividualProvider { Npi = "npi" },
    ///             Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///         },
    ///         new EligibilityRequest
    ///         {
    ///             PayerId = "payer_id",
    ///             Provider = new IndividualProvider { Npi = "npi" },
    ///             Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<BatchEligibilityResponse> BatchAsync(
        IEnumerable<EligibilityRequest> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/eligibility-checks/v1/batch",
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
                return JsonUtils.Deserialize<BatchEligibilityResponse>(responseBody)!;
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
    /// Polls the status of a batch eligibility check.
    /// &lt;Note&gt;Batch eligibility checks are not yet available. Please reach out to the Candid team for more information.&lt;/Note&gt;
    /// path-parameters:
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.EligibilityChecks.V1.PollBatchAsync("batch_id");
    /// </code>
    /// </example>
    public async Task<EligibilityCheckPage> PollBatchAsync(
        string batchId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/eligibility-checks/v1/batch/{batchId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<EligibilityCheckPage>(responseBody)!;
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
