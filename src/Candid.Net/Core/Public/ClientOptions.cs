using System;
using System.Net.Http;

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
    /// The timeout for the request.
    /// </summary>
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// The http headers sent with the request.
    /// </summary>
    internal Headers Headers { get; init; } = new();
}
