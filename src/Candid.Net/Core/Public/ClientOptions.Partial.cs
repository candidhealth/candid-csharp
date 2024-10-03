namespace Candid.Net.Core;

#nullable enable

public partial class ClientOptions
{
    public ClientOptions Clone()
    {
        return new ClientOptions
        {
            Environment = Environment,
            HttpClient = HttpClient,
            MaxRetries = MaxRetries,
            Timeout = Timeout,
            Headers = new Headers(new Dictionary<string, HeaderValue>(Headers))
        };
    }
}
