using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Tasks;

[JsonConverter(typeof(StringEnumSerializer<TaskCategory>))]
public enum TaskCategory
{
    [EnumMember(Value = "other")]
    Other,

    [EnumMember(Value = "provider_credentialing")]
    ProviderCredentialing,

    [EnumMember(Value = "authorization_required")]
    AuthorizationRequired,

    [EnumMember(Value = "inactive_coverage")]
    InactiveCoverage,

    [EnumMember(Value = "unknown_eligibility_or_patient_not_found")]
    UnknownEligibilityOrPatientNotFound,

    [EnumMember(Value = "incorrect_member_id")]
    IncorrectMemberId,

    [EnumMember(Value = "documentation_addendum_request")]
    DocumentationAddendumRequest,

    [EnumMember(Value = "coordination_of_benefits")]
    CoordinationOfBenefits,

    [EnumMember(Value = "missing_or_incorrect_gender")]
    MissingOrIncorrectGender,

    [EnumMember(Value = "incorrect_date_of_birth")]
    IncorrectDateOfBirth,

    [EnumMember(Value = "incorrect_payer")]
    IncorrectPayer,

    [EnumMember(Value = "incorrect_name")]
    IncorrectName,

    [EnumMember(Value = "invalid_diagnosis_code")]
    InvalidDiagnosisCode,

    [EnumMember(Value = "non_covered_diagnosis_codes")]
    NonCoveredDiagnosisCodes,

    [EnumMember(Value = "information_requested_from_patient")]
    InformationRequestedFromPatient,

    [EnumMember(Value = "incorrect_rendering_provider_info")]
    IncorrectRenderingProviderInfo,

    [EnumMember(Value = "missing_or_incorrect_modifier")]
    MissingOrIncorrectModifier,

    [EnumMember(Value = "coding_frequency_error")]
    CodingFrequencyError,

    [EnumMember(Value = "incorrect_patient_address")]
    IncorrectPatientAddress,

    [EnumMember(Value = "multiple_em_claims")]
    MultipleEmClaims,

    [EnumMember(Value = "missing_or_incorrect_charge_amount")]
    MissingOrIncorrectChargeAmount,

    [EnumMember(Value = "medical_records_request")]
    MedicalRecordsRequest,

    [EnumMember(Value = "provider_enrollment_or_contracting")]
    ProviderEnrollmentOrContracting,

    [EnumMember(Value = "missing_or_incorrect_group_number")]
    MissingOrIncorrectGroupNumber,

    [EnumMember(Value = "missing_diagnosis_codes")]
    MissingDiagnosisCodes,

    [EnumMember(Value = "missing_patient_authorization")]
    MissingPatientAuthorization,

    [EnumMember(Value = "incorrect_billing_provider_info")]
    IncorrectBillingProviderInfo,

    [EnumMember(Value = "incorrect_procedure_code")]
    IncorrectProcedureCode,

    [EnumMember(Value = "incorrect_quantity")]
    IncorrectQuantity,

    [EnumMember(Value = "incorrect_place_of_service_code")]
    IncorrectPlaceOfServiceCode,

    [EnumMember(Value = "incorrect_service_facility_info")]
    IncorrectServiceFacilityInfo,

    [EnumMember(Value = "incorrect_date_of_service")]
    IncorrectDateOfService,

    [EnumMember(Value = "missing_or_incorrect_ndc")]
    MissingOrIncorrectNdc,

    [EnumMember(Value = "patient_collections")]
    PatientCollections,

    [EnumMember(Value = "submit_to_secondary")]
    SubmitToSecondary,

    [EnumMember(Value = "transient_server_error")]
    TransientServerError,

    [EnumMember(Value = "missing_remittance_enrollment")]
    MissingRemittanceEnrollment,

    [EnumMember(Value = "missing_claims_enrollment")]
    MissingClaimsEnrollment,

    [EnumMember(Value = "held_by_customer")]
    HeldByCustomer,

    [EnumMember(Value = "pending_manual_remit_posting")]
    PendingManualRemitPosting,

    [EnumMember(Value = "incorrect_referring_provider_info")]
    IncorrectReferringProviderInfo
}
