namespace Candid.Net.Payers.V3;

public record GetAllPayersRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; init; }

    public string? SearchTerm { get; init; }

    public string? PageToken { get; init; }
}
