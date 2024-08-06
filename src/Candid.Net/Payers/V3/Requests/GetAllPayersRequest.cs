namespace Candid.Net.Payers.V3;

public record GetAllPayersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    public string? SearchTerm { get; set; }

    public string? PageToken { get; set; }
}
