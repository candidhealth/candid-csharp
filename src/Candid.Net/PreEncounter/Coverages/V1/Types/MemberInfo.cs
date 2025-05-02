using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record MemberInfo
{
    /// <summary>
    /// Stedi requires that you supply at least one of these fields in the request: memberId, dateOfBirth, or lastName.
    /// However, each payer has different requirements, so you should supply as many of the fields necessary for each payer
    /// to identify the subscriber/dependent in their system.
    /// </summary>
    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }

    /// <summary>
    /// Stedi requires that you supply at least one of these fields in the request: memberId, dateOfBirth, or lastName.
    /// However, each payer has different requirements, so you should supply as many of the fields necessary for each payer
    /// to identify the subscriber/dependent in their system.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
