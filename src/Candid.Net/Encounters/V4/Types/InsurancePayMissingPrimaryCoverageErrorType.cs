using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record InsurancePayMissingPrimaryCoverageErrorType
{
    [JsonPropertyName("patient_id")]
    public required string PatientId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
