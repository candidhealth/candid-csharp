using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images;

public partial class ImagesClient
{
    private RawClient _client;

    internal ImagesClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PreEncounter.Images.V1.V1Client(_client);
    }

    public Candid.Net.PreEncounter.Images.V1.V1Client V1 { get; }
}
