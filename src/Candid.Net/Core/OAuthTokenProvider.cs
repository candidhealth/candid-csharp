using Candid.Net.Auth.V2;

namespace Candid.Net.Core;

using System;
using System.Threading.Tasks;

public sealed class OAuthTokenProvider
{
    private const double BufferInMinutes = 2;

    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly V2Client _authClient;

    private string? _accessToken;
    private DateTime _expiresAt;

    public OAuthTokenProvider(string clientId, string clientSecret, V2Client authClient)
    {
        _clientId = clientId;
        _clientSecret = clientSecret;
        _authClient = authClient;
        _expiresAt = DateTime.UtcNow;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        if (_accessToken == null || DateTime.UtcNow >= _expiresAt)
        {
            var tokenResponse = await FetchTokenAsync();
            _accessToken = tokenResponse.AccessToken;
            _expiresAt = DateTime
                .UtcNow.AddSeconds(tokenResponse.ExpiresIn)
                .AddMinutes(-BufferInMinutes);
        }

        return $"Bearer {_accessToken}";
    }

    private async Task<AuthGetTokenResponse> FetchTokenAsync()
    {
        var request = new AuthGetTokenRequest
        {
            ClientId = _clientId,
            ClientSecret = _clientSecret
        };
        return await _authClient.GetTokenAsync(request);
    }
}
