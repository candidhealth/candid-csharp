using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves a previously created insurance adjudication by its `insurance_adjudication_id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsuranceAdjudications.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<InsuranceAdjudication> GetAsync(
        string insuranceAdjudicationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/insurance-adjudications/v1/{insuranceAdjudicationId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsuranceAdjudication>(responseBody)!;
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
    /// Creates a new insurance adjudication record and returns the newly created InsuranceAdjudication object.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsuranceAdjudications.V1.CreateAsync(
    ///     new InsuranceAdjudicationCreate
    ///     {
    ///         PayerIdentifier = new PayerInfo { PayerId = "payer_id", PayerName = "payer_name" },
    ///         Payee = new Payee { PayeeName = "payee_name", PayeeIdentifier = "payee_identifier" },
    ///         CheckDate = new DateOnly(2023, 1, 15),
    ///         Claims = new Dictionary&lt;string, IEnumerable&lt;ClaimAdjudicationCreate&gt;&gt;()
    ///         {
    ///             {
    ///                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 new List&lt;ClaimAdjudicationCreate&gt;()
    ///                 {
    ///                     new ClaimAdjudicationCreate
    ///                     {
    ///                         ClaimStatusCode = ClaimStatusCodeCreate.ProcessedAsPrimary,
    ///                         ServiceLines = new Dictionary&lt;
    ///                             string,
    ///                             IEnumerable&lt;ServiceLineAdjudicationCreate&gt;
    ///                         &gt;()
    ///                         {
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                                 new List&lt;ServiceLineAdjudicationCreate&gt;()
    ///                                 {
    ///                                     new ServiceLineAdjudicationCreate
    ///                                     {
    ///                                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                                         {
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                         },
    ///                                         Rarcs = new List&lt;RemittanceAdviceRemarkCode&gt;()
    ///                                         {
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                         },
    ///                                     },
    ///                                     new ServiceLineAdjudicationCreate
    ///                                     {
    ///                                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                                         {
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                         },
    ///                                         Rarcs = new List&lt;RemittanceAdviceRemarkCode&gt;()
    ///                                         {
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                         },
    ///                                     },
    ///                                 }
    ///                             },
    ///                         },
    ///                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                         {
    ///                             new ClaimAdjustmentReasonCode
    ///                             {
    ///                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                 ReasonCode = Carc.Carc1,
    ///                                 AmountCents = 1,
    ///                             },
    ///                             new ClaimAdjustmentReasonCode
    ///                             {
    ///                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                 ReasonCode = Carc.Carc1,
    ///                                 AmountCents = 1,
    ///                             },
    ///                         },
    ///                     },
    ///                     new ClaimAdjudicationCreate
    ///                     {
    ///                         ClaimStatusCode = ClaimStatusCodeCreate.ProcessedAsPrimary,
    ///                         ServiceLines = new Dictionary&lt;
    ///                             string,
    ///                             IEnumerable&lt;ServiceLineAdjudicationCreate&gt;
    ///                         &gt;()
    ///                         {
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                                 new List&lt;ServiceLineAdjudicationCreate&gt;()
    ///                                 {
    ///                                     new ServiceLineAdjudicationCreate
    ///                                     {
    ///                                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                                         {
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                         },
    ///                                         Rarcs = new List&lt;RemittanceAdviceRemarkCode&gt;()
    ///                                         {
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                         },
    ///                                     },
    ///                                     new ServiceLineAdjudicationCreate
    ///                                     {
    ///                                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                                         {
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                             new ClaimAdjustmentReasonCode
    ///                                             {
    ///                                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                                 ReasonCode = Carc.Carc1,
    ///                                                 AmountCents = 1,
    ///                                             },
    ///                                         },
    ///                                         Rarcs = new List&lt;RemittanceAdviceRemarkCode&gt;()
    ///                                         {
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                             new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
    ///                                         },
    ///                                     },
    ///                                 }
    ///                             },
    ///                         },
    ///                         Carcs = new List&lt;ClaimAdjustmentReasonCode&gt;()
    ///                         {
    ///                             new ClaimAdjustmentReasonCode
    ///                             {
    ///                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                 ReasonCode = Carc.Carc1,
    ///                                 AmountCents = 1,
    ///                             },
    ///                             new ClaimAdjustmentReasonCode
    ///                             {
    ///                                 GroupCode = ClaimAdjustmentGroupCodes.Co,
    ///                                 ReasonCode = Carc.Carc1,
    ///                                 AmountCents = 1,
    ///                             },
    ///                         },
    ///                     },
    ///                 }
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<InsuranceAdjudication> CreateAsync(
        InsuranceAdjudicationCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/insurance-adjudications/v1",
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
                return JsonUtils.Deserialize<InsuranceAdjudication>(responseBody)!;
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
    /// Deletes the insurance adjudication record matching the provided insurance_adjudication_id.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsuranceAdjudications.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string insuranceAdjudicationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/insurance-adjudications/v1/{insuranceAdjudicationId}",
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
