using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;

#nullable enable

namespace Candid.Net.CustomSchemas;

public partial class CustomSchemasClient
{
    private RawClient _client;

    internal CustomSchemasClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
