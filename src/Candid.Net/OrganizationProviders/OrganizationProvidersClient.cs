using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V2;
using Candid.Net.OrganizationProviders.V3;

#nullable enable

namespace Candid.Net.OrganizationProviders;

public partial class OrganizationProvidersClient
{
    private RawClient _client;

    internal OrganizationProvidersClient(RawClient client)
    {
        _client = client;
        V2 = new V2Client(_client);
        V3 = new V3Client(_client);
    }

    public V2Client V2 { get; }

    public V3Client V3 { get; }
}
