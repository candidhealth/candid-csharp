using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Invoices.V2;

[JsonConverter(typeof(StringEnumSerializer<InvoiceDestination>))]
public enum InvoiceDestination
{
    [EnumMember(Value = "STRIPE")]
    Stripe,

    [EnumMember(Value = "CEDAR")]
    Cedar,

    [EnumMember(Value = "HEALTHIE")]
    Healthie,

    [EnumMember(Value = "COLLECTLY")]
    Collectly,

    [EnumMember(Value = "THIRD_PARTY_PAYERS")]
    ThirdPartyPayers
}
