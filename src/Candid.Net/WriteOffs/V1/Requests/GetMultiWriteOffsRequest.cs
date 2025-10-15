using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Financials;

namespace Candid.Net.WriteOffs.V1;

[Serializable]
public record GetMultiWriteOffsRequest
{
    /// <summary>
    /// Defaults to 100. The value must be greater than 0 and less than 1000.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    [JsonIgnore]
    public string? PayerUuid { get; set; }

    [JsonIgnore]
    public string? ServiceLineId { get; set; }

    [JsonIgnore]
    public string? ClaimId { get; set; }

    [JsonIgnore]
    public string? BillingProviderId { get; set; }

    /// <summary>
    /// Defaults to write_off_timestamp
    /// </summary>
    [JsonIgnore]
    public WriteOffSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order if not provided.
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Filters the returned values to include only the provided account types.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<AccountType> AccountTypes { get; set; } = new List<AccountType>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
