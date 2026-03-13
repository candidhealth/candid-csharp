using Candid.Net.Core;

namespace Candid.Net.PatientAr;

public partial class PatientArClient : IPatientArClient
{
    private readonly RawClient _client;

    internal PatientArClient(RawClient client)
    {
        _client = client;
        V1 = new global::Candid.Net.PatientAr.V1.V1Client(_client);
    }

    public global::Candid.Net.PatientAr.V1.IV1Client V1 { get; }
}
