using global::Candid.Net.Core;

namespace Candid.Net.Views.Dynamic;

public partial class DynamicClient : IDynamicClient
{
    private readonly RawClient _client;

    internal DynamicClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Views.Dynamic.V1.V1Client(_client);
    }

    public global::Candid.Net.Views.Dynamic.V1.IV1Client V1 { get; }
}
