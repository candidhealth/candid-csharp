using Candid.Net.Core;
using Candid.Net.PatientPayments.V4;

#nullable enable

namespace Candid.Net.PatientPayments;

public partial class PatientPaymentsClient
{
    private RawClient _client;

    internal PatientPaymentsClient(RawClient client)
    {
        _client = client;
        V4 = new V4Client(_client);
    }

    public V4Client V4 { get; }
}
