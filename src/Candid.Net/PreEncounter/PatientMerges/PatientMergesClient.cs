using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.PatientMerges;

public partial class PatientMergesClient : IPatientMergesClient
{
    private readonly RawClient _client;

    internal PatientMergesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.PatientMerges.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.PatientMerges.V1.IV1Client V1 { get; }
}
