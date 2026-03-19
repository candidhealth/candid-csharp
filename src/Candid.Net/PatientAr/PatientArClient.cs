using Candid.Net.Core;

namespace Candid.Net.PatientAr;

public partial class PatientArClient
{
    private RawClient _client;

    internal PatientArClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PatientAr.V1.V1Client(_client);
    }

    public global::Candid.Net.PatientAr.V1.V1Client V1 { get; }
}
