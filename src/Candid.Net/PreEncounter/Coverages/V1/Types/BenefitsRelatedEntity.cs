using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public record BenefitsRelatedEntity
{
    [JsonPropertyName("entityIdentifier")]
    public string? EntityIdentifier { get; set; }

    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    [JsonPropertyName("entityName")]
    public string? EntityName { get; set; }

    [JsonPropertyName("contactInformation")]
    public IEnumerable<RelatedEntityContact>? ContactInformation { get; set; }

    [JsonPropertyName("serviceTypeCodes")]
    public IEnumerable<ServiceTypeCode>? ServiceTypeCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
