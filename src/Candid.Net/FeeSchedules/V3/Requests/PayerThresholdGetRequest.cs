namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdGetRequest
{
    public required string PayerUuids { get; init; }
}
