using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients;

public partial class PatientsClient
{
    private RawClient _client;

    internal PatientsClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Patients.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Patients.V1.V1Client V1 { get; }
}
