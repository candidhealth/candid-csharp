using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record Encounter
{
    /// <summary>
    /// Defaults to the current date if not provided.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public DateOnly? DateOfService { get; set; }

    /// <summary>
    /// Defaults to HealthBenefitPlanCoverage (30) if not provided.
    /// &lt;Note&gt;Not all payers support multiple service type codes, so it is recommended to only include a single code per request.&lt;/Note&gt;
    /// </summary>
    [JsonPropertyName("service_type_codes")]
    public IEnumerable<string>? ServiceTypeCodes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
