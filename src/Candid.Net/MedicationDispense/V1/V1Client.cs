using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.MedicationDispense.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.MedicationDispense.V1.CreateAsync(
    ///     new MedicationDispenseCreate
    ///     {
    ///         MedicationDispenseExternalId = "string",
    ///         PatientExternalId = "string",
    ///         ProcedureCode = "string",
    ///         Quantity = "string",
    ///         Units = ServiceLineUnits.Mj,
    ///         DateOfService = new DateOnly(2023, 1, 15),
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
    ///         Description = "string",
    ///         Modifiers = new List&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Encounters.V4.Encounter> CreateAsync(
        MedicationDispenseCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/medication-dispense/v1",
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
                return JsonUtils.Deserialize<Encounters.V4.Encounter>(responseBody)!;
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
