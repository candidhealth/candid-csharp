using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<SchemaGetMultiResponse>
    > GetMultiAsyncCore(
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
                    Method = HttpMethod.Get,
                    Path = "/api/custom-schemas/v1",
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
                var responseData = JsonUtils.Deserialize<SchemaGetMultiResponse>(responseBody)!;
                return new WithRawResponse<SchemaGetMultiResponse>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Schema>> GetAsyncCore(
        string schemaId,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/custom-schemas/v1/{0}",
                        ValueConvert.ToPathParameterString(schemaId)
                    ),
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
                var responseData = JsonUtils.Deserialize<Schema>(responseBody)!;
                return new WithRawResponse<Schema>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Schema>> CreateAsyncCore(
        SchemaCreate request,
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
                    Path = "/api/custom-schemas/v1",
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
                var responseData = JsonUtils.Deserialize<Schema>(responseBody)!;
                return new WithRawResponse<Schema>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Schema>> UpdateAsyncCore(
        string schemaId,
        SchemaUpdate request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/custom-schemas/v1/{0}",
                        ValueConvert.ToPathParameterString(schemaId)
                    ),
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
                var responseData = JsonUtils.Deserialize<Schema>(responseBody)!;
                return new WithRawResponse<Schema>()
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

    /// <summary>
    /// Returns all custom schemas.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.GetMultiAsync();
    /// </code></example>
    public WithRawResponseTask<SchemaGetMultiResponse> GetMultiAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<SchemaGetMultiResponse>(
            GetMultiAsyncCore(options, cancellationToken)
        );
    }

    /// <summary>
    /// Return a custom schema with a given ID.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.GetAsync("ec096b13-f80a-471d-aaeb-54b021c9d582");
    /// </code></example>
    public WithRawResponseTask<Schema> GetAsync(
        string schemaId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Schema>(GetAsyncCore(schemaId, options, cancellationToken));
    }

    /// <summary>
    /// Create custom schema with a set of typed keys. Schema keys can be referenced as inputs in user-configurable rules in the Rules
    /// Engine, and key-value pairs can be attached to claims via the Encounters API.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.CreateAsync(
    ///     new SchemaCreate
    ///     {
    ///         Name = "General Medicine",
    ///         Description = "Values associated with a generic visit",
    ///         Fields = new List&lt;SchemaField&gt;()
    ///         {
    ///             new SchemaField { Key = "provider_category", Type = Primitive.String },
    ///             new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
    ///             new SchemaField { Key = "bmi", Type = Primitive.Double },
    ///             new SchemaField { Key = "age", Type = Primitive.Integer },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Schema> CreateAsync(
        SchemaCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Schema>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update the name, description, or keys on a preexisting schema.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.UpdateAsync(
    ///     "ec096b13-f80a-471d-aaeb-54b021c9d582",
    ///     new SchemaUpdate
    ///     {
    ///         Name = "General Medicine and Health",
    ///         Description = "Values collected during all visits",
    ///         FieldsToAdd = new List&lt;SchemaField&gt;()
    ///         {
    ///             new SchemaField { Key = "visit_type", Type = Primitive.String },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Schema> UpdateAsync(
        string schemaId,
        SchemaUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Schema>(
            UpdateAsyncCore(schemaId, request, options, cancellationToken)
        );
    }
}
