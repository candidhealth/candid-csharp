using System.Net.Http;
using Candid.Net.BillingNotes.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.BillingNotes.V2;

public class V2Client
{
    private RawClient _client;

    public V2Client(RawClient client)
    {
        _client = client;
    }

    public async Task<BillingNote> CreateAsync(StandaloneBillingNoteCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/billing_notes/v2",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<BillingNote>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
