using global::Candid.Net.Core;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[Serializable]
public record GetExternalConsolidatedRemitTransactionsRequest
{
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <summary>
    /// Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Retrieve only transactions sourced from any of the given ERA payments (matches the transaction's remit_id).
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> EraPaymentId { get; set; } = new List<string>();

    /// <summary>
    /// Retrieve only the given transaction(s), regardless of type.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TransactionId { get; set; } = new List<string>();

    /// <summary>
    /// Retrieve only transactions of the given type(s). Defaults to both.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<TransactionType> TransactionType { get; set; } = new List<TransactionType>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
