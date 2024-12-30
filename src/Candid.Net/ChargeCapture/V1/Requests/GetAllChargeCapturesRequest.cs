using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public record GetAllChargeCapturesRequest
{
    /// <summary>
    /// Maximum number of entities per page, defaults to 100.
    /// </summary>
    public int? Limit { get; set; }

    public string? PageToken { get; set; }

    /// <summary>
    /// The patient ID from the external EMR platform for the patient
    /// </summary>
    public string? PatientExternalId { get; set; }

    /// <summary>
    /// the status of the charge captures
    /// </summary>
    public ChargeCaptureStatus? Status { get; set; }

    /// <summary>
    /// A client-specified unique ID to associate with this encounter;
    /// for example, your internal encounter ID or a Dr. Chrono encounter ID.
    /// This field should not contain PHI.
    /// </summary>
    public string? ExternalId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
