using Candid.Net.Core;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
        Patients = new PatientsClient(_client);
    }

    public PatientsClient Patients { get; }
}
