using global::Candid.Net.Views.Dynamic;

namespace Candid.Net.Views;

public partial interface IViewsClient
{
    public IDynamicClient Dynamic { get; }
}
