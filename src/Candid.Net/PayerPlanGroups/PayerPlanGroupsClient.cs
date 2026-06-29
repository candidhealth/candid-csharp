using global::Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups;

public partial class PayerPlanGroupsClient : IPayerPlanGroupsClient
{
    private readonly RawClient _client;

    internal PayerPlanGroupsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PayerPlanGroups.V1.V1Client(_client);
    }

    public global::Candid.Net.PayerPlanGroups.V1.IV1Client V1 { get; }
}
