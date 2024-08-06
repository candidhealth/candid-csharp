namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdGetRequest
{
    public IEnumerable<string> PayerUuids { get; set; } = new List<string>();
}
