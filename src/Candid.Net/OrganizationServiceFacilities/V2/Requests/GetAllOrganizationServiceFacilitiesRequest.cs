using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[Serializable]
public record GetAllOrganizationServiceFacilitiesRequest
{
    /// <summary>
    /// Limit the number of results returned. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Filter to a name or a part of a name.
    /// </summary>
    [JsonIgnore]
    public string? Name { get; set; }

    /// <summary>
    /// Filter to the provided organization service facility IDs.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> OrganizationServiceFacilityIds { get; set; } = new List<string>();

    /// <summary>
    /// Filter by one or more external_ids.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ExternalIds { get; set; } = new List<string>();

    /// <summary>
    /// Filter by Place of Service (POS) code.
    /// </summary>
    [JsonIgnore]
    public FacilityTypeCode? PlaceOfServiceCode { get; set; }

    /// <summary>
    /// The page token to continue paging through a previous request.
    /// </summary>
    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
