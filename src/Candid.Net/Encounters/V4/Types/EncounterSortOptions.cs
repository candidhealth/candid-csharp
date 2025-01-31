using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<EncounterSortOptions>))]
public enum EncounterSortOptions
{
    [EnumMember(Value = "created_at:asc")]
    CreatedAtAsc,

    [EnumMember(Value = "created_at:desc")]
    CreatedAtDesc,

    [EnumMember(Value = "date_of_service:asc")]
    DateOfServiceAsc,

    [EnumMember(Value = "date_of_service:desc")]
    DateOfServiceDesc,
}
