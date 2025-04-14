using Candid.Net.Core;
using Candid.Net.PayerPlanGroups.V1;

#nullable enable

namespace Candid.Net.PayerPlanGroups;

public partial class PayerPlanGroupsClient
{
    private RawClient _client;

    internal PayerPlanGroupsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
