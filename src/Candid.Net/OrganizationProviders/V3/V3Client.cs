using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;

namespace Candid.Net.OrganizationProviders.V3;

public partial class V3Client : IV3Client
{
    private readonly RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<OrganizationProviderV2>
    > GetAsyncCore(
        string organizationProviderId,
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
                        "/api/organization-providers/v3/{0}",
                        ValueConvert.ToPathParameterString(organizationProviderId)
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
                var responseData = JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
                return new WithRawResponse<OrganizationProviderV2>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<OrganizationProviderPageV2>
    > GetMultiAsyncCore(
        GetAllOrganizationProvidersRequestV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 9)
            .Add("limit", request.Limit)
            .Add("search_term", request.SearchTerm)
            .Add("npi", request.Npi)
            .Add("is_rendering", request.IsRendering)
            .Add("is_billing", request.IsBilling)
            .Add("organization_provider_ids", request.OrganizationProviderIds)
            .Add("page_token", request.PageToken)
            .Add("sort", request.Sort)
            .Add("organization_id", request.OrganizationId)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
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
                    Path = "/api/organization-providers/v3",
                    QueryString = _queryString,
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
                var responseData = JsonUtils.Deserialize<OrganizationProviderPageV2>(responseBody)!;
                return new WithRawResponse<OrganizationProviderPageV2>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<OrganizationProviderV2>
    > CreateAsyncCore(
        OrganizationProviderCreateV2 request,
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
                    Path = "/api/organization-providers/v3",
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
                var responseData = JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
                return new WithRawResponse<OrganizationProviderV2>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<OrganizationProviderV2>
    > UpdateAsyncCore(
        string organizationProviderId,
        OrganizationProviderUpdateV2 request,
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
                        "/api/organization-providers/v3/{0}",
                        ValueConvert.ToPathParameterString(organizationProviderId)
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
                var responseData = JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
                return new WithRawResponse<OrganizationProviderV2>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<string>
    > UploadAttachmentAsyncCore(
        string organizationProviderId,
        UploadProviderAttachmentRequest request,
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
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Put,
            Path = string.Format(
                "/api/organization-providers/v3/{0}/attachments",
                ValueConvert.ToPathParameterString(organizationProviderId)
            ),
            Headers = _headers,
            Options = options,
        };
        multipartFormRequest_.AddFileParameterPart("attachment_file", request.AttachmentFile);
        multipartFormRequest_.AddJsonPart("file_type", request.FileType);
        var response = await _client
            .SendRequestAsync(multipartFormRequest_, cancellationToken)
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<IEnumerable<ProviderAttachment>>
    > ListAttachmentsAsyncCore(
        string organizationProviderId,
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
                        "/api/organization-providers/v3/{0}/attachments",
                        ValueConvert.ToPathParameterString(organizationProviderId)
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
                var responseData = JsonUtils.Deserialize<IEnumerable<ProviderAttachment>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<ProviderAttachment>>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ProviderAttachmentResponse>
    > DownloadAttachmentAsyncCore(
        DownloadProviderAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("attachment_id", request.AttachmentId)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
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
                    Path = "/api/organization-providers/v3/attachments/download",
                    QueryString = _queryString,
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
                var responseData = JsonUtils.Deserialize<ProviderAttachmentResponse>(responseBody)!;
                return new WithRawResponse<ProviderAttachmentResponse>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
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
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
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
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    private async global::System.Threading.Tasks.Task<RawResponse> DeleteAttachmentAsyncCore(
        string attachmentId,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/organization-providers/v3/attachments/{0}",
                        ValueConvert.ToPathParameterString(attachmentId)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return new global::Candid.Net.RawResponse()
            {
                StatusCode = response.Raw.StatusCode,
                Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
            };
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.GetAsync("965A563A-0285-4910-9569-E3739C0F6EAB");
    /// </code></example>
    public WithRawResponseTask<OrganizationProviderV2> GetAsync(
        string organizationProviderId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationProviderV2>(
            GetAsyncCore(organizationProviderId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.GetMultiAsync(
    ///     new GetAllOrganizationProvidersRequestV2
    ///     {
    ///         Limit = 100,
    ///         SearchTerm = "john",
    ///         Npi = "1234567890",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         Sort = OrganizationProviderSortOptions.ProviderNameAsc,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationProviderPageV2> GetMultiAsync(
        GetAllOrganizationProvidersRequestV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationProviderPageV2>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.CreateAsync(
    ///     new OrganizationProviderCreateV2
    ///     {
    ///         Npi = "npi",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         ProviderType = ProviderType.Individual,
    ///         LicenseType = global::Candid.Net.OrganizationProviders.V2.LicenseType.Md,
    ///         Qualifications = new List&lt;IdentifierCreate&gt;()
    ///         {
    ///             new IdentifierCreate
    ///             {
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new IdentifierValue(
    ///                     new IdentifierValue.MedicareProviderIdentifier(
    ///                         new MedicareProviderIdentifier
    ///                         {
    ///                             State = State.Aa,
    ///                             ProviderNumber = "provider_number",
    ///                         }
    ///                     )
    ///                 ),
    ///             },
    ///             new IdentifierCreate
    ///             {
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new IdentifierValue(
    ///                     new IdentifierValue.MedicareProviderIdentifier(
    ///                         new MedicareProviderIdentifier
    ///                         {
    ///                             State = State.Aa,
    ///                             ProviderNumber = "provider_number",
    ///                         }
    ///                     )
    ///                 ),
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationProviderV2> CreateAsync(
        OrganizationProviderCreateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationProviderV2>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new OrganizationProviderUpdateV2()
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationProviderV2> UpdateAsync(
        string organizationProviderId,
        OrganizationProviderUpdateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationProviderV2>(
            UpdateAsyncCore(organizationProviderId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Uploads a file to the provider. Accepted file types are W9, PECOS_RECORD, and BANK_LETTER_OR_VOIDED_CHECK.
    /// Only one file per type is allowed per provider — uploading when a file of the same type already exists returns a 409.
    /// </summary>
    public WithRawResponseTask<string> UploadAttachmentAsync(
        string organizationProviderId,
        UploadProviderAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            UploadAttachmentAsyncCore(organizationProviderId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.ListAttachmentsAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<IEnumerable<ProviderAttachment>> ListAttachmentsAsync(
        string organizationProviderId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<ProviderAttachment>>(
            ListAttachmentsAsyncCore(organizationProviderId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.DownloadAttachmentAsync(
    ///     new DownloadProviderAttachmentRequest { AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" }
    /// );
    /// </code></example>
    public WithRawResponseTask<ProviderAttachmentResponse> DownloadAttachmentAsync(
        DownloadProviderAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ProviderAttachmentResponse>(
            DownloadAttachmentAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.DeleteAttachmentAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask DeleteAttachmentAsync(
        string attachmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask(
            DeleteAttachmentAsyncCore(attachmentId, options, cancellationToken)
        );
    }
}
