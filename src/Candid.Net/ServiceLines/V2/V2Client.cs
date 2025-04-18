using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.ServiceLines.V2.CreateAsync(
    ///     new ServiceLineCreateStandalone
    ///     {
    ///         Modifiers = new List&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///         ChargeAmountCents = 1,
    ///         DiagnosisIdZero = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdOne = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdTwo = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdThree = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DenialReason = new ServiceLineDenialReason
    ///         {
    ///             Reason = DenialReasonContent.AuthorizationRequired,
    ///         },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         ProcedureCode = "string",
    ///         Quantity = "string",
    ///         Units = ServiceLineUnits.Mj,
    ///         ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         Description = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         EndDateOfService = new DateOnly(2023, 1, 15),
    ///         DrugIdentification = new DrugIdentification
    ///         {
    ///             ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
    ///             NationalDrugCode = "string",
    ///             NationalDrugUnitCount = "string",
    ///             MeasurementUnitCode = MeasurementUnitCode.Milliliters,
    ///             LinkSequenceNumber = "string",
    ///             PharmacyPrescriptionNumber = "string",
    ///             ConversionFormula = "string",
    ///             DrugDescription = "string",
    ///         },
    ///         OrderingProvider = new OrderingProvider
    ///         {
    ///             Npi = "string",
    ///             TaxonomyCode = "string",
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 Address1 = "123 Main St",
    ///                 Address2 = "Apt 1",
    ///                 City = "New York",
    ///                 State = State.Ny,
    ///                 ZipCode = "10001",
    ///                 ZipPlusFourCode = "1234",
    ///             },
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             OrganizationName = "string",
    ///         },
    ///         TestResults = new List&lt;TestResult&gt;()
    ///         {
    ///             new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
    ///         },
    ///         HasEpsdtIndicator = true,
    ///         HasFamilyPlanningIndicator = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ServiceLine> CreateAsync(
        ServiceLineCreateStandalone request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/service-lines/v2",
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
                return JsonUtils.Deserialize<ServiceLine>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ServiceLines.V2.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ServiceLineUpdate
    ///     {
    ///         EditReason = "string",
    ///         Modifiers = new List&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///         ChargeAmountCents = 1,
    ///         DiagnosisIdZero = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdOne = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdTwo = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DiagnosisIdThree = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         DrugIdentification = new DrugIdentification
    ///         {
    ///             ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
    ///             NationalDrugCode = "string",
    ///             NationalDrugUnitCount = "string",
    ///             MeasurementUnitCode = MeasurementUnitCode.Milliliters,
    ///             LinkSequenceNumber = "string",
    ///             PharmacyPrescriptionNumber = "string",
    ///             ConversionFormula = "string",
    ///             DrugDescription = "string",
    ///         },
    ///         DenialReason = new ServiceLineDenialReason
    ///         {
    ///             Reason = DenialReasonContent.AuthorizationRequired,
    ///         },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         Units = ServiceLineUnits.Mj,
    ///         ProcedureCode = "string",
    ///         Quantity = "string",
    ///         Description = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         EndDateOfService = new DateOnly(2023, 1, 15),
    ///         TestResults = new List&lt;TestResult&gt;()
    ///         {
    ///             new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
    ///         },
    ///         HasEpsdtIndicator = true,
    ///         HasFamilyPlanningIndicator = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ServiceLine> UpdateAsync(
        string serviceLineId,
        ServiceLineUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/service-lines/v2/{serviceLineId}",
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
                return JsonUtils.Deserialize<ServiceLine>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ServiceLines.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/service-lines/v2/{serviceLineId}",
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
