using global::Candid.Net.Core;

namespace Candid.Net.Dashboarding;

public partial class DashboardingClient : IDashboardingClient
{
    private readonly RawClient _client;

    internal DashboardingClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.Dashboarding.V1.V1Client(_client);
    }

    public global::Candid.Net.Dashboarding.V1.IV1Client V1 { get; }
}
