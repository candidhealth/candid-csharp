using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Tasks.Commons;

[JsonConverter(typeof(StringEnumSerializer<TaskCategory>))]
[Serializable]
public readonly record struct TaskCategory : IStringEnum
{
    public static readonly TaskCategory Other = new(Values.Other);

    public static readonly TaskCategory ProviderCredentialing = new(Values.ProviderCredentialing);

    public static readonly TaskCategory AuthorizationRequired = new(Values.AuthorizationRequired);

    public static readonly TaskCategory InactiveCoverage = new(Values.InactiveCoverage);

    public static readonly TaskCategory UnknownEligibilityOrPatientNotFound = new(
        Values.UnknownEligibilityOrPatientNotFound
    );

    public static readonly TaskCategory IncorrectMemberId = new(Values.IncorrectMemberId);

    public static readonly TaskCategory DocumentationAddendumRequest = new(
        Values.DocumentationAddendumRequest
    );

    public static readonly TaskCategory CoordinationOfBenefits = new(Values.CoordinationOfBenefits);

    public static readonly TaskCategory MissingOrIncorrectGender = new(
        Values.MissingOrIncorrectGender
    );

    public static readonly TaskCategory IncorrectDateOfBirth = new(Values.IncorrectDateOfBirth);

    public static readonly TaskCategory IncorrectPayer = new(Values.IncorrectPayer);

    public static readonly TaskCategory IncorrectName = new(Values.IncorrectName);

    public static readonly TaskCategory InvalidDiagnosisCode = new(Values.InvalidDiagnosisCode);

    public static readonly TaskCategory NonCoveredDiagnosisCodes = new(
        Values.NonCoveredDiagnosisCodes
    );

    public static readonly TaskCategory InformationRequestedFromPatient = new(
        Values.InformationRequestedFromPatient
    );

    public static readonly TaskCategory IncorrectRenderingProviderInfo = new(
        Values.IncorrectRenderingProviderInfo
    );

    public static readonly TaskCategory MissingOrIncorrectModifier = new(
        Values.MissingOrIncorrectModifier
    );

    public static readonly TaskCategory CodingFrequencyError = new(Values.CodingFrequencyError);

    public static readonly TaskCategory IncorrectPatientAddress = new(
        Values.IncorrectPatientAddress
    );

    public static readonly TaskCategory MultipleEmClaims = new(Values.MultipleEmClaims);

    public static readonly TaskCategory MissingOrIncorrectChargeAmount = new(
        Values.MissingOrIncorrectChargeAmount
    );

    public static readonly TaskCategory MedicalRecordsRequest = new(Values.MedicalRecordsRequest);

    public static readonly TaskCategory ProviderEnrollmentOrContracting = new(
        Values.ProviderEnrollmentOrContracting
    );

    public static readonly TaskCategory MissingOrIncorrectGroupNumber = new(
        Values.MissingOrIncorrectGroupNumber
    );

    public static readonly TaskCategory MissingDiagnosisCodes = new(Values.MissingDiagnosisCodes);

    public static readonly TaskCategory MissingPatientAuthorization = new(
        Values.MissingPatientAuthorization
    );

    public static readonly TaskCategory IncorrectBillingProviderInfo = new(
        Values.IncorrectBillingProviderInfo
    );

    public static readonly TaskCategory IncorrectProcedureCode = new(Values.IncorrectProcedureCode);

    public static readonly TaskCategory IncorrectQuantity = new(Values.IncorrectQuantity);

    public static readonly TaskCategory IncorrectPlaceOfServiceCode = new(
        Values.IncorrectPlaceOfServiceCode
    );

    public static readonly TaskCategory IncorrectServiceFacilityInfo = new(
        Values.IncorrectServiceFacilityInfo
    );

    public static readonly TaskCategory IncorrectDateOfService = new(Values.IncorrectDateOfService);

    public static readonly TaskCategory MissingOrIncorrectNdc = new(Values.MissingOrIncorrectNdc);

    public static readonly TaskCategory PatientCollections = new(Values.PatientCollections);

    public static readonly TaskCategory SubmitToSecondary = new(Values.SubmitToSecondary);

    public static readonly TaskCategory TransientServerError = new(Values.TransientServerError);

    public static readonly TaskCategory MissingRemittanceEnrollment = new(
        Values.MissingRemittanceEnrollment
    );

    public static readonly TaskCategory MissingClaimsEnrollment = new(
        Values.MissingClaimsEnrollment
    );

    public static readonly TaskCategory HeldByCustomer = new(Values.HeldByCustomer);

    public static readonly TaskCategory PendingManualRemitPosting = new(
        Values.PendingManualRemitPosting
    );

    public static readonly TaskCategory IncorrectReferringProviderInfo = new(
        Values.IncorrectReferringProviderInfo
    );

    public static readonly TaskCategory PayerConfigurationError = new(
        Values.PayerConfigurationError
    );

    public TaskCategory(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static TaskCategory FromCustom(string value)
    {
        return new TaskCategory(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(TaskCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaskCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaskCategory value) => value.Value;

    public static explicit operator TaskCategory(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Other = "other";

        public const string ProviderCredentialing = "provider_credentialing";

        public const string AuthorizationRequired = "authorization_required";

        public const string InactiveCoverage = "inactive_coverage";

        public const string UnknownEligibilityOrPatientNotFound =
            "unknown_eligibility_or_patient_not_found";

        public const string IncorrectMemberId = "incorrect_member_id";

        public const string DocumentationAddendumRequest = "documentation_addendum_request";

        public const string CoordinationOfBenefits = "coordination_of_benefits";

        public const string MissingOrIncorrectGender = "missing_or_incorrect_gender";

        public const string IncorrectDateOfBirth = "incorrect_date_of_birth";

        public const string IncorrectPayer = "incorrect_payer";

        public const string IncorrectName = "incorrect_name";

        public const string InvalidDiagnosisCode = "invalid_diagnosis_code";

        public const string NonCoveredDiagnosisCodes = "non_covered_diagnosis_codes";

        public const string InformationRequestedFromPatient = "information_requested_from_patient";

        public const string IncorrectRenderingProviderInfo = "incorrect_rendering_provider_info";

        public const string MissingOrIncorrectModifier = "missing_or_incorrect_modifier";

        public const string CodingFrequencyError = "coding_frequency_error";

        public const string IncorrectPatientAddress = "incorrect_patient_address";

        public const string MultipleEmClaims = "multiple_em_claims";

        public const string MissingOrIncorrectChargeAmount = "missing_or_incorrect_charge_amount";

        public const string MedicalRecordsRequest = "medical_records_request";

        public const string ProviderEnrollmentOrContracting = "provider_enrollment_or_contracting";

        public const string MissingOrIncorrectGroupNumber = "missing_or_incorrect_group_number";

        public const string MissingDiagnosisCodes = "missing_diagnosis_codes";

        public const string MissingPatientAuthorization = "missing_patient_authorization";

        public const string IncorrectBillingProviderInfo = "incorrect_billing_provider_info";

        public const string IncorrectProcedureCode = "incorrect_procedure_code";

        public const string IncorrectQuantity = "incorrect_quantity";

        public const string IncorrectPlaceOfServiceCode = "incorrect_place_of_service_code";

        public const string IncorrectServiceFacilityInfo = "incorrect_service_facility_info";

        public const string IncorrectDateOfService = "incorrect_date_of_service";

        public const string MissingOrIncorrectNdc = "missing_or_incorrect_ndc";

        public const string PatientCollections = "patient_collections";

        public const string SubmitToSecondary = "submit_to_secondary";

        public const string TransientServerError = "transient_server_error";

        public const string MissingRemittanceEnrollment = "missing_remittance_enrollment";

        public const string MissingClaimsEnrollment = "missing_claims_enrollment";

        public const string HeldByCustomer = "held_by_customer";

        public const string PendingManualRemitPosting = "pending_manual_remit_posting";

        public const string IncorrectReferringProviderInfo = "incorrect_referring_provider_info";

        public const string PayerConfigurationError = "payer_configuration_error";
    }
}
