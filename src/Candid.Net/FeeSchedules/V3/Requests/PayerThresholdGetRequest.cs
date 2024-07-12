namespace Candid.Net.FeeSchedules.V3;

public record PayerThresholdGetRequest
{
    public required Guid PayerUuids { get; init; }
}
