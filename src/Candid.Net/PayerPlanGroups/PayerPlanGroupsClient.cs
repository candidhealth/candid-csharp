using Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups;

public partial class PayerPlanGroupsClient
{
    private RawClient _client;

    internal PayerPlanGroupsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PayerPlanGroups.V1.V1Client(_client);
    }

    public global::Candid.Net.PayerPlanGroups.V1.V1Client V1 { get; }
}
