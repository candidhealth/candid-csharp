using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients;

public partial class PatientsClient : IPatientsClient
{
    private readonly RawClient _client;

    internal PatientsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Patients.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Patients.V1.IV1Client V1 { get; }
}
