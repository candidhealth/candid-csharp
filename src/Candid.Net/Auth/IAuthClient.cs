using global::Candid.Net.Auth.Default;

namespace Candid.Net.Auth;

public partial interface IAuthClient
{
    public IDefaultClient Default { get; }
}
