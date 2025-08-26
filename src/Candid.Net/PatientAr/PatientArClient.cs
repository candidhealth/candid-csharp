using Candid.Net.Core;
using Candid.Net.PatientAr.V1;

#nullable enable

namespace Candid.Net.PatientAr;

public partial class PatientArClient
{
    private RawClient _client;

    internal PatientArClient(RawClient client)
    {
        _client = client;
        V1 = new V1Client(_client);
    }

    public V1Client V1 { get; }
}
