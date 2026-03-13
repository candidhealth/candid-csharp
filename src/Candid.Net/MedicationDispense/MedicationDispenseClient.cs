using Candid.Net.Core;

namespace Candid.Net.MedicationDispense;

public partial class MedicationDispenseClient : IMedicationDispenseClient
{
    private readonly RawClient _client;

    internal MedicationDispenseClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.MedicationDispense.V1.V1Client(_client);
    }

    public global::Candid.Net.MedicationDispense.V1.IV1Client V1 { get; }
}
