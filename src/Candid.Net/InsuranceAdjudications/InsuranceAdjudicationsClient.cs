using Candid.Net.Core;
using Candid.Net.InsuranceAdjudications.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications;

public class InsuranceAdjudicationsClient
{
    private RawClient _client;

    public InsuranceAdjudicationsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
