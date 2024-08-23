using Candid.Net.Core;
using Candid.Net.PreEncounter.Appointments.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments;

public partial class AppointmentsClient
{
    private RawClient _client;

    internal AppointmentsClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
