using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Computes the expected network status for a given rendering provider.
    /// This endpoint is not available to all customers. Reach out to the Candid sales team
    /// to discuss enabling this endpoint if it is not available for your organization.
    /// </summary>
    /// <example><code>
    /// await client.ExpectedNetworkStatus.V2.ComputeForRenderingProviderAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ExpectedNetworkStatusRequestV2
    ///     {
    ///         ServiceType = ServiceType.NewPatientVideoAppt,
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         SubscriberInformation = new ExpectedNetworkStatusSubscriberInformation
    ///         {
    ///             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             MemberId = "member_id",
    ///             InsuranceType = new InsuranceType
    ///             {
    ///                 LineOfBusiness = LineOfBusiness.Medicare,
    ///                 InsuranceTypeCodes = new InsuranceTypeCodes(
    ///                     new global::Candid.Net.ExpectedNetworkStatus.V2.InsuranceTypeCodes.InsuranceTypeCode(
    ///                         global::Candid.Net.Commons.InsuranceTypeCode.C01
    ///                     )
    ///                 ),
    ///             },
    ///         },
    ///         PatientAddress = new StreetAddressShortZip
    ///         {
    ///             Address1 = "address1",
    ///             City = "city",
    ///             State = State.Aa,
    ///             ZipCode = "zip_code",
    ///         },
    ///         BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         OrganizationServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ExpectedNetworkStatusResponseV2> ComputeForRenderingProviderAsync(
        string renderingProviderId,
        ExpectedNetworkStatusRequestV2 request,
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
                    Path = string.Format(
                        "/api/expected-network-status/v2/compute/{0}",
                        ValueConvert.ToPathParameterString(renderingProviderId)
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
                return JsonUtils.Deserialize<ExpectedNetworkStatusResponseV2>(responseBody)!;
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
    /// Computes all the in network providers for a given set of inputs.
    /// This endpoint is not available to all customers. Reach out to the Candid sales team
    /// to discuss enabling this endpoint if it is not available for your organization.
    /// </summary>
    /// <example><code>
    /// await client.ExpectedNetworkStatus.V2.ComputeAllInNetworkProvidersAsync(
    ///     new ComputeAllInNetworkProvidersRequest
    ///     {
    ///         ServiceType = ServiceType.NewPatientVideoAppt,
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         SubscriberInformation = new ExpectedNetworkStatusSubscriberInformation
    ///         {
    ///             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             MemberId = "member_id",
    ///             InsuranceType = new InsuranceType
    ///             {
    ///                 LineOfBusiness = LineOfBusiness.Medicare,
    ///                 InsuranceTypeCodes = new InsuranceTypeCodes(
    ///                     new global::Candid.Net.ExpectedNetworkStatus.V2.InsuranceTypeCodes.InsuranceTypeCode(
    ///                         global::Candid.Net.Commons.InsuranceTypeCode.C01
    ///                     )
    ///                 ),
    ///             },
    ///         },
    ///         PatientAddress = new StreetAddressShortZip
    ///         {
    ///             Address1 = "address1",
    ///             City = "city",
    ///             State = State.Aa,
    ///             ZipCode = "zip_code",
    ///         },
    ///         BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         OrganizationServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ComputeAllInNetworkProvidersResponse> ComputeAllInNetworkProvidersAsync(
        ComputeAllInNetworkProvidersRequest request,
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
                    Path = "/api/expected-network-status/v2/compute",
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
                return JsonUtils.Deserialize<ComputeAllInNetworkProvidersResponse>(responseBody)!;
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
