using Candid.Net.Core;

namespace Candid.Net.InsuranceAdjudications;

public partial class InsuranceAdjudicationsClient
{
    private RawClient _client;

    internal InsuranceAdjudicationsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.InsuranceAdjudications.V1.V1Client(_client);
    }

    public Candid.Net.InsuranceAdjudications.V1.V1Client V1 { get; }
}
