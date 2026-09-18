using global::Candid.Net.Core;
using global::Candid.Net.Views.Dynamic;

namespace Candid.Net.Views;

public partial class ViewsClient : IViewsClient
{
    private readonly RawClient _client;

    internal ViewsClient(RawClient client)
    {
        _client = client;
        Dynamic = new DynamicClient(_client);
    }

    public IDynamicClient Dynamic { get; }
}
