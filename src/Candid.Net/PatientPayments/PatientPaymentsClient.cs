using Candid.Net.Core;

namespace Candid.Net.PatientPayments;

public partial class PatientPaymentsClient
{
    private RawClient _client;

    internal PatientPaymentsClient(RawClient client)
    {
        _client = client;
        V4 = new global::Candid.Net.PatientPayments.V4.V4Client(_client);
    }

    public global::Candid.Net.PatientPayments.V4.V4Client V4 { get; }
}
