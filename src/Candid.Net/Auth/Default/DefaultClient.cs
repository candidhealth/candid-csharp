using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.Auth.Default;

public partial class DefaultClient
{
    private RawClient _client;

    internal DefaultClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// &lt;Callout intent="info"&gt;
    /// Candid Health SDKs automatically handle authentication workflows after configuring them with the `client_id` and
    /// `client_secret`.
    /// &lt;/Callout&gt;
    ///
    /// Candid Health utilizes the [OAuth 2.0 bearer token authentication scheme](https://developer.mozilla.org/en-US/docs/Web/HTTP/Authentication) in our auth flow. You obtain the bearer token for all
    /// subsequent API requests via the `/auth/v2/token` endpoint defined below, which requires you to provide your `client_id` and `client_secret`. Your `client_id` and `client_secret` can be [generated](https://support.joincandidhealth.com/hc/en-us/articles/23065219476244--Generating-Candid-API-Keys) from the "Users & Credentials" tab by your org admin.
    ///
    /// The `/auth/v2/token` endpoint accepts both `Content-Type: application/json` and `Content-Type: application/x-www-form-urlencoded`. The request body should contain the `client_id` and `client_secret` as follows:
    ///
    /// ```json
    /// {
    ///   "client_id": "YOUR_CLIENT_ID",
    ///   "client_secret": "YOUR_CLIENT_SECRET"
    /// }
    /// ```
    /// or as URL-encoded form data:
    ///
    /// ```
    /// client_id=YOUR_CLIENT_ID&client_secret=YOUR_CLIENT_SECRET
    /// ```
    ///
    /// The bearer token is a signed [JWT](https://jwt.io/). The public key for the JWT can be found [here](https://candidhealth.auth0.com/pem) for any verification workflows.
    ///
    /// The bearer token should be provided in the `Authorization` header for all subsequent API calls.
    ///
    /// &lt;Callout intent="warning"&gt;
    /// The bearer token expires 5 hours after it has been created. After it has expired, the client will receive an "HTTP 401
    /// Unauthorized" error, at which point the client should generate a new token. It is important that tokens be reused between
    /// requests; if the client attempts to generate a token too often, it will be rate-limited and will receive an `HTTP 429 Too Many Requests` error.
    /// &lt;/Callout&gt;
    /// </summary>
    /// <example><code>
    /// await client.Auth.Default.GetTokenAsync(
    ///     new AuthGetTokenRequest { ClientId = "YOUR_CLIENT_ID", ClientSecret = "YOUR_CLIENT_SECRET" }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<AuthGetTokenResponse> GetTokenAsync(
        AuthGetTokenRequest request,
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
                    Path = "/api/auth/v2/token",
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
                return JsonUtils.Deserialize<AuthGetTokenResponse>(responseBody)!;
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
