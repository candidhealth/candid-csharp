using Candid.Net.Core;
using Candid.Net.HealthCareCodeInformation.V1;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation;

public partial class HealthCareCodeInformationClient
{
    private RawClient _client;

    internal HealthCareCodeInformationClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
