namespace Candid.Net.PreEncounter.Patients.V1;

public record CreatePatientRequest
{
    public bool? SkipDuplicateCheck { get; set; }

    public required MutablePatient Body { get; set; }
}
