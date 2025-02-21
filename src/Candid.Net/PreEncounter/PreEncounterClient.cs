using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments;
using Candid.Net.PreEncounter.Coverages;
using Candid.Net.PreEncounter.EligibilityChecks;
using Candid.Net.PreEncounter.Lists;
using Candid.Net.PreEncounter.Notes;
using Candid.Net.PreEncounter.Patients;
using Candid.Net.PreEncounter.Tags;

#nullable enable

namespace Candid.Net.PreEncounter;

public partial class PreEncounterClient
{
    private RawClient _client;

    internal PreEncounterClient(RawClient client)
    {
        _client = client;
        Appointments = new AppointmentsClient(_client);
        Coverages = new CoveragesClient(_client);
        EligibilityChecks = new EligibilityChecksClient(_client);
        Lists = new ListsClient(_client);
        Notes = new NotesClient(_client);
        Patients = new PatientsClient(_client);
        Tags = new TagsClient(_client);
        Common = new CommonClient(_client);
    }

    public AppointmentsClient Appointments { get; }

    public CoveragesClient Coverages { get; }

    public EligibilityChecksClient EligibilityChecks { get; }

    public ListsClient Lists { get; }

    public NotesClient Notes { get; }

    public PatientsClient Patients { get; }

    public TagsClient Tags { get; }

    public CommonClient Common { get; }
}
