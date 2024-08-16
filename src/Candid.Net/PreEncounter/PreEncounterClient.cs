using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages;
using Candid.Net.PreEncounter.Patients;

#nullable enable

namespace Candid.Net.PreEncounter;

public partial class PreEncounterClient
{
    private RawClient _client;

    internal PreEncounterClient(RawClient client)
    {
        _client = client;
        Coverages = new CoveragesClient(_client);
        Patients = new PatientsClient(_client);
        Common = new CommonClient(_client);
    }

    public CoveragesClient Coverages { get; }

    public PatientsClient Patients { get; }

    public CommonClient Common { get; }
}
