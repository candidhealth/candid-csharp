using Candid.Net.Core;
using Candid.Net.PreEncounter.Images.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Images;

public partial class ImagesClient
{
    private RawClient _client;

    internal ImagesClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
