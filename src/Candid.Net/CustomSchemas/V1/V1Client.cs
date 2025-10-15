using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all custom schemas.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.GetMultiAsync();
    /// </code></example>
    public async System.Threading.Tasks.Task<SchemaGetMultiResponse> GetMultiAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/custom-schemas/v1",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<SchemaGetMultiResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Return a custom schema with a given ID.
    /// </summary>
    /// <example><code>
    /// await client.CustomSchemas.V1.GetAsync("ec096b13-f80a-471d-aaeb-54b021c9d582");
    /// </code></example>
    public async System.Threading.Tasks.Task<Schema> GetAsync(
        string schemaId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Schema>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public async System.Threading.Tasks.Task<Schema> CreateAsync(
        SchemaCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/custom-schemas/v1",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Schema>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public async System.Threading.Tasks.Task<Schema> UpdateAsync(
        string schemaId,
        SchemaUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Schema>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
