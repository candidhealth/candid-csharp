using Candid.Net.Core;

namespace Candid.Net;

public class CandidClient(string clientId, string clientSecret, ClientOptions? clientOptions = null)
    : Candid(clientId, clientSecret, clientOptions);