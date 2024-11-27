using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(EnumSerializer<Explanation>))]
public enum Explanation
{
    [EnumMember(Value = "Payer Routing and/or Billing Provider Routing Failed")]
    RoutingFailed,

    [EnumMember(Value = "No Effective Contract with Payer")]
    PayerMatchFailed,

    [EnumMember(Value = "No Effective Contract with Billing Provider")]
    BillingProviderMatchFailed,

    [EnumMember(Value = "No Effective Contract with Covered Geography")]
    CoveredGeographyMatchFailed,

    [EnumMember(Value = "No Effective Contract with Line of Business")]
    LineOfBusinessMatchFailed,

    [EnumMember(Value = "No Effective Contract with Insurance Type")]
    InsuranceTypeMatchFailed,

    [EnumMember(Value = "No Effective Contract with Rendering Provider")]
    RenderingProviderMatchFailed,

    [EnumMember(Value = "Rendering Provider Not Credentialed")]
    RenderingProviderCredentialingCheckFailed,
}
