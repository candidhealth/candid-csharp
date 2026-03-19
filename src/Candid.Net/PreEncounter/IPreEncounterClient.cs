using global::Candid.Net.PreEncounter.Appointments;
using global::Candid.Net.PreEncounter.Coverages;
using global::Candid.Net.PreEncounter.EligibilityChecks;
using global::Candid.Net.PreEncounter.Images;
using global::Candid.Net.PreEncounter.Lists;
using global::Candid.Net.PreEncounter.Notes;
using global::Candid.Net.PreEncounter.Patients;

namespace Candid.Net.PreEncounter;

public partial interface IPreEncounterClient
{
    public IAppointmentsClient Appointments { get; }
    public ICoveragesClient Coverages { get; }
    public IEligibilityChecksClient EligibilityChecks { get; }
    public IImagesClient Images { get; }
    public IListsClient Lists { get; }
    public INotesClient Notes { get; }
    public IPatientsClient Patients { get; }
    public global::Candid.Net.PreEncounter.Tags.ITagsClient Tags { get; }
}
