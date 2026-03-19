namespace Candid.Net.Contracts;

public partial interface IContractsClient
{
    public global::Candid.Net.Contracts.V2.IV2Client V2 { get; }
    public global::Candid.Net.Contracts.V3.IV3Client V3 { get; }
}
