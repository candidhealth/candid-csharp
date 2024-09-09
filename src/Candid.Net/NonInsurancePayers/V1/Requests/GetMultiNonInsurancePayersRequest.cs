namespace Candid.Net.NonInsurancePayers.V1;

public record GetMultiNonInsurancePayersRequest
{
    public string? Name { get; set; }

    public string? Category { get; set; }

    public bool? Enabled { get; set; }

    public NonInsurancePayerSortField? Sort { get; set; }

    public SortDirection? SortDirection { get; set; }

    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }
}
