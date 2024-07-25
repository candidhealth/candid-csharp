using Candid.Net.Core;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Patients;

public class PatientsClient
{
    private RawClient _client;

    public PatientsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
