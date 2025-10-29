using Candid.Net.Core;

namespace Candid.Net.EncounterSupplementalInformation;

public partial class EncounterSupplementalInformationClient
{
    private RawClient _client;

    internal EncounterSupplementalInformationClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.EncounterSupplementalInformation.V1.V1Client(_client);
    }

    public global::Candid.Net.EncounterSupplementalInformation.V1.V1Client V1 { get; }
}
