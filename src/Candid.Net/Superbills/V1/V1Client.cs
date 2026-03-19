using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Superbills.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<SuperbillResponse>
    > CreateSuperbillAsyncCore(
        CreateSuperbillRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/superbill/v1",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<SuperbillResponse>(responseBody)!;
                return new WithRawResponse<SuperbillResponse>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.Superbills.V1.CreateSuperbillAsync(
    ///     new CreateSuperbillRequest
    ///     {
    ///         PatientExternalId = "patient_external_id",
    ///         DateRangeMin = new DateOnly(2023, 1, 15),
    ///         DateRangeMax = new DateOnly(2023, 1, 15),
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<SuperbillResponse> CreateSuperbillAsync(
        CreateSuperbillRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SuperbillResponse>(
            CreateSuperbillAsyncCore(request, options, cancellationToken)
        );
    }
}
