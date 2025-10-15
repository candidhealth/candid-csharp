using Candid.Net.Core;

namespace Candid.Net.PatientAr;

public partial class PatientArClient
{
    private RawClient _client;

    internal PatientArClient(RawClient client)
    {
        _client = client;
        V1 = new Candid.Net.PatientAr.V1.V1Client(_client);
    }

    public Candid.Net.PatientAr.V1.V1Client V1 { get; }
}
