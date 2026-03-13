using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation;

public partial class HealthCareCodeInformationClient : IHealthCareCodeInformationClient
{
    private readonly RawClient _client;

    internal HealthCareCodeInformationClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.HealthCareCodeInformation.V1.V1Client(_client);
    }

    public global::Candid.Net.HealthCareCodeInformation.V1.IV1Client V1 { get; }
}
