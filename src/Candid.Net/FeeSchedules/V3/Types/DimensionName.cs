using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.FeeSchedules.V3;

#nullable enable

namespace Candid.Net.FeeSchedules.V3;

[JsonConverter(typeof(StringEnumSerializer<DimensionName>))]
public enum DimensionName
{
    [EnumMember(Value = "payer_uuid")]
    PayerUuid,

    [EnumMember(Value = "organization_billing_provider_id")]
    OrganizationBillingProviderId,

    [EnumMember(Value = "cpt_code")]
    CptCode
}
