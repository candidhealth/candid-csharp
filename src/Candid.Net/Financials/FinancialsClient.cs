using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Financials;

public partial class FinancialsClient
{
    private RawClient _client;

    internal FinancialsClient(RawClient client)
    {
        _client = client;
    }
}
