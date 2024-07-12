using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public class PreEncounterClient
{
    private RawClient _client;

    public PreEncounterClient(RawClient client)
    {
        _client = client;
        Common = new CommonClient(_client);
        Coverages = new CoveragesClient(_client);
        Patients = new PatientsClient(_client);
    }

    public CommonClient Common { get; }

    public CoveragesClient Coverages { get; }

    public PatientsClient Patients { get; }
}
