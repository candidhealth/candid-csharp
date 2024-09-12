using Candid.Net.Core;
using Candid.Net.MedicationDispense.V1;

#nullable enable

namespace Candid.Net.MedicationDispense;

public partial class MedicationDispenseClient
{
    private RawClient _client;

    internal MedicationDispenseClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
