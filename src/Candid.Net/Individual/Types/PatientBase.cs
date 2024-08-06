using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record PatientBase
{
    /// <summary>
    /// The ID used to identify this individual in your system. For example, your internal patient ID or an EHR patient ID.
    /// </summary>
    [JsonPropertyName("external_id")]
    public required string ExternalId { get; set; }

    /// <summary>
    /// Box 3 on the CMS-1500 claim form. The date format should be in ISO 8601 date; formatted YYYY-MM-DD (i.e. 2012-02-01)
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateOnly DateOfBirth { get; set; }

    /// <summary>
    /// Box 5 on the CMS-1500 claim form.
    /// </summary>
    [JsonPropertyName("address")]
    public required StreetAddressShortZip Address { get; set; }
}
