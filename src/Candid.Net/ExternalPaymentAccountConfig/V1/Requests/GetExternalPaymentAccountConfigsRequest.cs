namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record GetExternalPaymentAccountConfigsRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; init; }

    public string? PageToken { get; init; }
}
