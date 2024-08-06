namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public record GetExternalPaymentAccountConfigsRequest
{
    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }
}
