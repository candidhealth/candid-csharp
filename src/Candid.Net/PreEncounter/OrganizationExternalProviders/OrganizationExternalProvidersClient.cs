using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.OrganizationExternalProviders;

public partial class OrganizationExternalProvidersClient : IOrganizationExternalProvidersClient
{
    private readonly RawClient _client;

    internal OrganizationExternalProvidersClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.OrganizationExternalProviders.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.OrganizationExternalProviders.V1.IV1Client V1 { get; }
}
