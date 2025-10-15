using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments;
using Candid.Net.PreEncounter.Coverages;
using Candid.Net.PreEncounter.EligibilityChecks;
using Candid.Net.PreEncounter.Images;
using Candid.Net.PreEncounter.Lists;
using Candid.Net.PreEncounter.Notes;
using Candid.Net.PreEncounter.Patients;

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
        Images = new ImagesClient(_client);
        Lists = new ListsClient(_client);
        Notes = new NotesClient(_client);
        Patients = new PatientsClient(_client);
        Tags = new Candid.Net.PreEncounter.Tags.TagsClient(_client);
    }

    public AppointmentsClient Appointments { get; }

    public CoveragesClient Coverages { get; }

    public EligibilityChecksClient EligibilityChecks { get; }

    public ImagesClient Images { get; }

    public ListsClient Lists { get; }

    public NotesClient Notes { get; }

    public PatientsClient Patients { get; }

    public Candid.Net.PreEncounter.Tags.TagsClient Tags { get; }
}
