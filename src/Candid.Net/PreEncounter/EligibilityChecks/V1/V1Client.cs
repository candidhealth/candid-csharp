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
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.EligibilityChecks.V1.PostAsync(
    ///     new EligibilityRequest
    ///     {
    ///         PayerId = "string",
    ///         Provider = new IndividualProvider
    ///         {
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             Npi = "string",
    ///         },
    ///         Subscriber = new MemberInfo
    ///         {
    ///             MemberId = "string",
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///         },
    ///         Dependent = new MemberInfo
    ///         {
    ///             MemberId = "string",
    ///             FirstName = "string",
    ///             LastName = "string",
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///         },
    ///         Encounter = new Candid.Net.PreEncounter.EligibilityChecks.V1.Encounter
    ///         {
    ///             DateOfService = new DateOnly(2023, 1, 15),
    ///             ServiceTypeCodes = new List&lt;string&gt;() { "string" },
    ///         },
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
}
