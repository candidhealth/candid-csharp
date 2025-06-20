using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public partial class YesNoIndicatorClient
{
    private RawClient _client;

    internal YesNoIndicatorClient(RawClient client)
    {
        _client = client;
    }
}
