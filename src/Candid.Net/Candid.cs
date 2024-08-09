using Candid.Net.Core;

namespace Candid.Net;

public class Candid(
    string clientId,
    string clientSecret,
    ClientOptions? clientOptions = null
) : CandidClient(clientId, clientSecret, clientOptions);
