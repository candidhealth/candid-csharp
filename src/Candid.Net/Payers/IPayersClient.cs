namespace Candid.Net.Payers;

public partial interface IPayersClient
{
    public global::Candid.Net.Payers.V3.IV3Client V3 { get; }
    public global::Candid.Net.Payers.V4.IV4Client V4 { get; }
}
