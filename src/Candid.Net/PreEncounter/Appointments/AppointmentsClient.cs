using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments;

public partial class AppointmentsClient
{
    private RawClient _client;

    internal AppointmentsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Appointments.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Appointments.V1.V1Client V1 { get; }
}
