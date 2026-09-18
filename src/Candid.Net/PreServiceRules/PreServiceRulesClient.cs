using global::Candid.Net.Core;

namespace Candid.Net.PreServiceRules;

public partial class PreServiceRulesClient : IPreServiceRulesClient
{
    private readonly RawClient _client;

    internal PreServiceRulesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreServiceRules.V1.V1Client(_client);
    }

    public global::Candid.Net.PreServiceRules.V1.IV1Client V1 { get; }
}
