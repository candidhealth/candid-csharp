using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.MedicationDispense.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.MedicationDispense.V1.CreateAsync(
    ///     new MedicationDispenseCreate
    ///     {
    ///         MedicationDispenseExternalId = "medication_dispense_external_id",
    ///         PatientExternalId = "patient_external_id",
    ///         ProcedureCode = "procedure_code",
    ///         Quantity = "quantity",
    ///         Units = ServiceLineUnits.Mj,
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<global::Candid.Net.Encounters.V4.Encounter> CreateAsync(
        MedicationDispenseCreate request,
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
                    Path = "/api/medication-dispense/v1",
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
                return JsonUtils.Deserialize<global::Candid.Net.Encounters.V4.Encounter>(
                    responseBody
                )!;
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
