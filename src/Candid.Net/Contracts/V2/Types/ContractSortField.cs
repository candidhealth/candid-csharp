using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(EnumSerializer<ContractSortField>))]
public enum ContractSortField
{
    [EnumMember(Value = "created_at")]
    CreatedAt,

    [EnumMember(Value = "payer_name")]
    PayerName,

    [EnumMember(Value = "payer_id")]
    PayerId,

    [EnumMember(Value = "billing_provider_name")]
    BillingProviderName,

    [EnumMember(Value = "effective_date")]
    EffectiveDate,

    [EnumMember(Value = "contract_status")]
    ContractStatus,
}
