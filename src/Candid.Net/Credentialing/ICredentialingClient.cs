namespace Candid.Net.Credentialing;

public partial interface ICredentialingClient
{
    public global::Candid.Net.Credentialing.V2.IV2Client V2 { get; }
    public global::Candid.Net.Credentialing.V3.IV3Client V3 { get; }
}
