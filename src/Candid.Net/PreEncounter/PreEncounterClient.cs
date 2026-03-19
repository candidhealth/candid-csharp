using global::Candid.Net.Core;
using global::Candid.Net.PreEncounter.Appointments;
using global::Candid.Net.PreEncounter.Coverages;
using global::Candid.Net.PreEncounter.EligibilityChecks;
using global::Candid.Net.PreEncounter.Images;
using global::Candid.Net.PreEncounter.Lists;
using global::Candid.Net.PreEncounter.Notes;
using global::Candid.Net.PreEncounter.Patients;

namespace Candid.Net.PreEncounter;

public partial class PreEncounterClient : IPreEncounterClient
{
    private readonly RawClient _client;

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
        Tags = new global::Candid.Net.PreEncounter.Tags.TagsClient(_client);
    }

    public IAppointmentsClient Appointments { get; }

    public ICoveragesClient Coverages { get; }

    public IEligibilityChecksClient EligibilityChecks { get; }

    public IImagesClient Images { get; }

    public IListsClient Lists { get; }

    public INotesClient Notes { get; }

    public IPatientsClient Patients { get; }

    public global::Candid.Net.PreEncounter.Tags.ITagsClient Tags { get; }
}
