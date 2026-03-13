using Candid.Net.Auth.Default;

namespace Candid.Net.Core;

public partial class OAuthTokenProvider
{
    private const double BufferInMinutes = 2;

    private DefaultClient _client;

    private string? _accessToken;

    private DateTime? _expiresAt;

    private string _clientId;

    private string _clientSecret;

    public OAuthTokenProvider(string clientId, string clientSecret, DefaultClient client)
    {
        _clientId = clientId;
        _clientSecret = clientSecret;
        _client = client;
    }

    public async global::System.Threading.Tasks.Task<string> GetAccessTokenAsync()
    {
        if (_accessToken == null || DateTime.UtcNow >= _expiresAt)
        {
            var tokenResponse = await _client
                .GetTokenAsync(
                    new AuthGetTokenRequest { ClientId = _clientId, ClientSecret = _clientSecret }
                )
                .ConfigureAwait(false);
            _accessToken = tokenResponse.AccessToken;
            _expiresAt = DateTime
                .UtcNow.AddSeconds(tokenResponse.ExpiresIn)
                .AddMinutes(-BufferInMinutes);
        }
        return $"Bearer {_accessToken}";
    }
}
