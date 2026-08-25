using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.MetadataSchemas;

public partial class MetadataSchemasClient : IMetadataSchemasClient
{
    private readonly RawClient _client;

    internal MetadataSchemasClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.MetadataSchemas.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.MetadataSchemas.V1.IV1Client V1 { get; }
}
