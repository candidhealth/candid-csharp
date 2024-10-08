using Candid.Net.Auth.V2;

#nullable enable

namespace Candid.Net.Core;

public partial class OAuthTokenProvider
{
    private const double BufferInMinutes = 2;

    private string? _accessToken;

    private DateTime? _expiresAt;

    private string _clientId;

    private string _clientSecret;

    private V2Client _client;

    public OAuthTokenProvider(string clientId, string clientSecret, V2Client client)
    {
        _clientId = clientId;
        _clientSecret = clientSecret;
        _client = client;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        if (_accessToken == null || DateTime.UtcNow >= _expiresAt)
        {
            var tokenResponse = await _client.GetTokenAsync(
                new AuthGetTokenRequest { ClientId = _clientId, ClientSecret = _clientSecret }
            );
            _accessToken = tokenResponse.AccessToken;
            _expiresAt = DateTime
                .UtcNow.AddSeconds(tokenResponse.ExpiresIn)
                .AddMinutes(-BufferInMinutes);
        }
        return $"Bearer {_accessToken}";
    }
}
