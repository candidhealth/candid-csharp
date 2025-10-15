using Candid.Net.Core;

namespace Candid.Net.PatientRefunds;

public partial class PatientRefundsClient
{
    private RawClient _client;

    internal PatientRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PatientRefunds.V1.V1Client(_client);
    }

    public Candid.Net.PatientRefunds.V1.V1Client V1 { get; }
}
