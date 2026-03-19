using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders;

public partial class OrganizationProvidersClient
{
    private RawClient _client;

    internal OrganizationProvidersClient(RawClient client)
    {
        _client = client;
        V3 = new global::Candid.Net.OrganizationProviders.V3.V3Client(_client);
    }

    public global::Candid.Net.OrganizationProviders.V3.V3Client V3 { get; }
}
