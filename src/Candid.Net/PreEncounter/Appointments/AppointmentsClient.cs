using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments;

public partial class AppointmentsClient : IAppointmentsClient
{
    private readonly RawClient _client;

    internal AppointmentsClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Appointments.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Appointments.V1.IV1Client V1 { get; }
}
