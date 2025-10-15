using Candid.Net.Core;

namespace Candid.Net.CustomSchemas;

public partial class CustomSchemasClient
{
    private RawClient _client;

    internal CustomSchemasClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.CustomSchemas.V1.V1Client(_client);
    }

    public global::Candid.Net.CustomSchemas.V1.V1Client V1 { get; }
}
