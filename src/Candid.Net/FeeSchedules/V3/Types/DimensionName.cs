using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

[JsonConverter(typeof(EnumSerializer<DimensionName>))]
public enum DimensionName
{
    [EnumMember(Value = "payer_uuid")]
    PayerUuid,

    [EnumMember(Value = "organization_billing_provider_id")]
    OrganizationBillingProviderId,

    [EnumMember(Value = "cpt_code")]
    CptCode,
}
