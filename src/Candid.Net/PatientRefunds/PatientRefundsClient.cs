using Candid.Net.Core;
using Candid.Net.PatientRefunds.V1;

#nullable enable

namespace Candid.Net.PatientRefunds;

public class PatientRefundsClient
{
    private RawClient _client;

    public PatientRefundsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
