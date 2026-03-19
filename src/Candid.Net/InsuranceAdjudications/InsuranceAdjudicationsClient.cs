using global::Candid.Net.Core;

namespace Candid.Net.InsuranceAdjudications;

public partial class InsuranceAdjudicationsClient : IInsuranceAdjudicationsClient
{
    private readonly RawClient _client;

    internal InsuranceAdjudicationsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.InsuranceAdjudications.V1.V1Client(_client);
    }

    public global::Candid.Net.InsuranceAdjudications.V1.IV1Client V1 { get; }
}
