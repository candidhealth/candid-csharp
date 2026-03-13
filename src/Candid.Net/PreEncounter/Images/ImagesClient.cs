using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images;

public partial class ImagesClient : IImagesClient
{
    private readonly RawClient _client;

    internal ImagesClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PreEncounter.Images.V1.V1Client(_client);
    }

    public global::Candid.Net.PreEncounter.Images.V1.IV1Client V1 { get; }
}
