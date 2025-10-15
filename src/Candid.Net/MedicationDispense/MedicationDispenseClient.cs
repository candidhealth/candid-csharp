using Candid.Net.Core;

namespace Candid.Net.MedicationDispense;

public partial class MedicationDispenseClient
{
    private RawClient _client;

    internal MedicationDispenseClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.MedicationDispense.V1.V1Client(_client);
    }

    public Candid.Net.MedicationDispense.V1.V1Client V1 { get; }
}
