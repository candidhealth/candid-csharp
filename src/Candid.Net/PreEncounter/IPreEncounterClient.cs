using Candid.Net.PreEncounter.Appointments;
using Candid.Net.PreEncounter.Coverages;
using Candid.Net.PreEncounter.EligibilityChecks;
using Candid.Net.PreEncounter.Images;
using Candid.Net.PreEncounter.Lists;
using Candid.Net.PreEncounter.Notes;
using Candid.Net.PreEncounter.Patients;

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
