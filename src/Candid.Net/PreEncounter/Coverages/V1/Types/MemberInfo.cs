using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record MemberInfo
{
    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
