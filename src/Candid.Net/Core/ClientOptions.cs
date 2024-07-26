using System.Net.Http;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Core;

public partial class ClientOptions
{
    /// <summary>
    /// The Environment for the API.
    /// </summary>
    public CandidEnvironment Environment { get; init; } = CandidEnvironment.PRODUCTION;

    /// <summary>
    /// The http client used to make requests.
    /// </summary>
    public HttpClient HttpClient { get; init; } = new HttpClient();

    /// <summary>
    /// The http client used to make requests.
    /// </summary>
    public int MaxRetries { get; init; } = 2;

    /// <summary>
    /// The timeout for the request in seconds.
    /// </summary>
    public int TimeoutInSeconds { get; init; } = 30;
}
