using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Commons;

[JsonConverter(typeof(RejectionReason.RejectionReasonSerializer))]
[Serializable]
public readonly record struct RejectionReason : IStringEnum
{
    public static readonly RejectionReason DuplicateClaim = new(Values.DuplicateClaim);

    public static readonly RejectionReason ExceedsTimelyFiling = new(Values.ExceedsTimelyFiling);

    public static readonly RejectionReason InvalidOrMissingModifier = new(
        Values.InvalidOrMissingModifier
    );

    public static readonly RejectionReason InvalidOrMissingDiagnosisCode = new(
        Values.InvalidOrMissingDiagnosisCode
    );

    public static readonly RejectionReason InvalidOrMissingPlaceOfService = new(
        Values.InvalidOrMissingPlaceOfService
    );

    public static readonly RejectionReason InvalidOrMissingProcedureCode = new(
        Values.InvalidOrMissingProcedureCode
    );

    public static readonly RejectionReason InvalidOrMissingNdc = new(Values.InvalidOrMissingNdc);

    public static readonly RejectionReason InvalidOrMissingDateOfService = new(
        Values.InvalidOrMissingDateOfService
    );

    public static readonly RejectionReason OtherInvalidClaimOrServiceLineInformation = new(
        Values.OtherInvalidClaimOrServiceLineInformation
    );

    public static readonly RejectionReason MultipleCodingIssues = new(Values.MultipleCodingIssues);

    public static readonly RejectionReason IncorrectOrMissingInsuranceInformation = new(
        Values.IncorrectOrMissingInsuranceInformation
    );

    public static readonly RejectionReason IncorrectOrMissingPatientDemographic = new(
        Values.IncorrectOrMissingPatientDemographic
    );

    public static readonly RejectionReason NoActiveCoverage = new(Values.NoActiveCoverage);

    public static readonly RejectionReason CoordinationOfBenefits = new(
        Values.CoordinationOfBenefits
    );

    public static readonly RejectionReason OtherPatientInformation = new(
        Values.OtherPatientInformation
    );

    public static readonly RejectionReason IncorrectPayer = new(Values.IncorrectPayer);

    public static readonly RejectionReason MissingPayerAddress = new(Values.MissingPayerAddress);

    public static readonly RejectionReason OtherPayerInformation = new(
        Values.OtherPayerInformation
    );

    public static readonly RejectionReason IncorrectOrMissingTaxonomyCode = new(
        Values.IncorrectOrMissingTaxonomyCode
    );

    public static readonly RejectionReason IncorrectOrMissingNationalProviderIdentifier = new(
        Values.IncorrectOrMissingNationalProviderIdentifier
    );

    public static readonly RejectionReason NoEffectiveEnrollment = new(
        Values.NoEffectiveEnrollment
    );

    public static readonly RejectionReason OtherProviderInformation = new(
        Values.OtherProviderInformation
    );

    public static readonly RejectionReason AdmitOrDischargeDate = new(Values.AdmitOrDischargeDate);

    public static readonly RejectionReason DoiOrDateOfOnset = new(Values.DoiOrDateOfOnset);

    public static readonly RejectionReason OtherDrugRelated = new(Values.OtherDrugRelated);

    public static readonly RejectionReason CobInformation = new(Values.CobInformation);

    public static readonly RejectionReason QuantityOrUnits = new(Values.QuantityOrUnits);

    public static readonly RejectionReason CptDescription = new(Values.CptDescription);

    public static readonly RejectionReason InvalidCorrectedOrVoidedClaim = new(
        Values.InvalidCorrectedOrVoidedClaim
    );

    public static readonly RejectionReason IncorrectOrInvalidMemberId = new(
        Values.IncorrectOrInvalidMemberId
    );

    public static readonly RejectionReason IncorrectPatientOrSubscriberDob = new(
        Values.IncorrectPatientOrSubscriberDob
    );

    public static readonly RejectionReason IncorrectPatientOrSubscriberGender = new(
        Values.IncorrectPatientOrSubscriberGender
    );

    public static readonly RejectionReason IncorrectPatientOrSubscriberAddress = new(
        Values.IncorrectPatientOrSubscriberAddress
    );

    public static readonly RejectionReason IncorrectPatientOrSubscriberName = new(
        Values.IncorrectPatientOrSubscriberName
    );

    public static readonly RejectionReason IncorrectInsurancePlanType = new(
        Values.IncorrectInsurancePlanType
    );

    public static readonly RejectionReason IncorrectInsuranceType = new(
        Values.IncorrectInsuranceType
    );

    public static readonly RejectionReason InvalidPayerId = new(Values.InvalidPayerId);

    public static readonly RejectionReason ServiceFacility = new(Values.ServiceFacility);

    public static readonly RejectionReason Clia = new(Values.Clia);

    public static readonly RejectionReason IncorrectOrMissingOtherProviderTaxonomy = new(
        Values.IncorrectOrMissingOtherProviderTaxonomy
    );

    public static readonly RejectionReason IncorrectOrMissingRenderingTaxonomy = new(
        Values.IncorrectOrMissingRenderingTaxonomy
    );

    public static readonly RejectionReason IncorrectOrMissingBillingTaxonomy = new(
        Values.IncorrectOrMissingBillingTaxonomy
    );

    public static readonly RejectionReason IncorrectOrMissingOtherProviderNpi = new(
        Values.IncorrectOrMissingOtherProviderNpi
    );

    public static readonly RejectionReason IncorrectOrMissingRenderingNpi = new(
        Values.IncorrectOrMissingRenderingNpi
    );

    public static readonly RejectionReason IncorrectOrMissingBillingNpi = new(
        Values.IncorrectOrMissingBillingNpi
    );

    public static readonly RejectionReason IncorrectOrInvalidTin = new(
        Values.IncorrectOrInvalidTin
    );

    public static readonly RejectionReason IncorrectOrMissingOtherProviderId = new(
        Values.IncorrectOrMissingOtherProviderId
    );

    public static readonly RejectionReason IncorrectOrMissingProviderAddress = new(
        Values.IncorrectOrMissingProviderAddress
    );

    public static readonly RejectionReason Unknown = new(Values.Unknown);

    public RejectionReason(string value)
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
    public static RejectionReason FromCustom(string value)
    {
        return new RejectionReason(value);
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

    public static bool operator ==(RejectionReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RejectionReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RejectionReason value) => value.Value;

    public static explicit operator RejectionReason(string value) => new(value);

    internal class RejectionReasonSerializer : JsonConverter<RejectionReason>
    {
        public override RejectionReason Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new RejectionReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RejectionReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RejectionReason ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new RejectionReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RejectionReason value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DuplicateClaim = "DUPLICATE_CLAIM";

        public const string ExceedsTimelyFiling = "EXCEEDS_TIMELY_FILING";

        public const string InvalidOrMissingModifier = "INVALID_OR_MISSING_MODIFIER";

        public const string InvalidOrMissingDiagnosisCode = "INVALID_OR_MISSING_DIAGNOSIS_CODE";

        public const string InvalidOrMissingPlaceOfService = "INVALID_OR_MISSING_PLACE_OF_SERVICE";

        public const string InvalidOrMissingProcedureCode = "INVALID_OR_MISSING_PROCEDURE_CODE";

        public const string InvalidOrMissingNdc = "INVALID_OR_MISSING_NDC";

        public const string InvalidOrMissingDateOfService = "INVALID_OR_MISSING_DATE_OF_SERVICE";

        public const string OtherInvalidClaimOrServiceLineInformation =
            "OTHER_INVALID_CLAIM_OR_SERVICE_LINE_INFORMATION";

        public const string MultipleCodingIssues = "MULTIPLE_CODING_ISSUES";

        public const string IncorrectOrMissingInsuranceInformation =
            "INCORRECT_OR_MISSING_INSURANCE_INFORMATION";

        public const string IncorrectOrMissingPatientDemographic =
            "INCORRECT_OR_MISSING_PATIENT_DEMOGRAPHIC";

        public const string NoActiveCoverage = "NO_ACTIVE_COVERAGE";

        public const string CoordinationOfBenefits = "COORDINATION_OF_BENEFITS";

        public const string OtherPatientInformation = "OTHER_PATIENT_INFORMATION";

        public const string IncorrectPayer = "INCORRECT_PAYER";

        public const string MissingPayerAddress = "MISSING_PAYER_ADDRESS";

        public const string OtherPayerInformation = "OTHER_PAYER_INFORMATION";

        public const string IncorrectOrMissingTaxonomyCode = "INCORRECT_OR_MISSING_TAXONOMY_CODE";

        public const string IncorrectOrMissingNationalProviderIdentifier =
            "INCORRECT_OR_MISSING_NATIONAL_PROVIDER_IDENTIFIER";

        public const string NoEffectiveEnrollment = "NO_EFFECTIVE_ENROLLMENT";

        public const string OtherProviderInformation = "OTHER_PROVIDER_INFORMATION";

        public const string AdmitOrDischargeDate = "ADMIT_OR_DISCHARGE_DATE";

        public const string DoiOrDateOfOnset = "DOI_OR_DATE_OF_ONSET";

        public const string OtherDrugRelated = "OTHER_DRUG_RELATED";

        public const string CobInformation = "COB_INFORMATION";

        public const string QuantityOrUnits = "QUANTITY_OR_UNITS";

        public const string CptDescription = "CPT_DESCRIPTION";

        public const string InvalidCorrectedOrVoidedClaim = "INVALID_CORRECTED_OR_VOIDED_CLAIM";

        public const string IncorrectOrInvalidMemberId = "INCORRECT_OR_INVALID_MEMBER_ID";

        public const string IncorrectPatientOrSubscriberDob = "INCORRECT_PATIENT_OR_SUBSCRIBER_DOB";

        public const string IncorrectPatientOrSubscriberGender =
            "INCORRECT_PATIENT_OR_SUBSCRIBER_GENDER";

        public const string IncorrectPatientOrSubscriberAddress =
            "INCORRECT_PATIENT_OR_SUBSCRIBER_ADDRESS";

        public const string IncorrectPatientOrSubscriberName =
            "INCORRECT_PATIENT_OR_SUBSCRIBER_NAME";

        public const string IncorrectInsurancePlanType = "INCORRECT_INSURANCE_PLAN_TYPE";

        public const string IncorrectInsuranceType = "INCORRECT_INSURANCE_TYPE";

        public const string InvalidPayerId = "INVALID_PAYER_ID";

        public const string ServiceFacility = "SERVICE_FACILITY";

        public const string Clia = "CLIA";

        public const string IncorrectOrMissingOtherProviderTaxonomy =
            "INCORRECT_OR_MISSING_OTHER_PROVIDER_TAXONOMY";

        public const string IncorrectOrMissingRenderingTaxonomy =
            "INCORRECT_OR_MISSING_RENDERING_TAXONOMY";

        public const string IncorrectOrMissingBillingTaxonomy =
            "INCORRECT_OR_MISSING_BILLING_TAXONOMY";

        public const string IncorrectOrMissingOtherProviderNpi =
            "INCORRECT_OR_MISSING_OTHER_PROVIDER_NPI";

        public const string IncorrectOrMissingRenderingNpi = "INCORRECT_OR_MISSING_RENDERING_NPI";

        public const string IncorrectOrMissingBillingNpi = "INCORRECT_OR_MISSING_BILLING_NPI";

        public const string IncorrectOrInvalidTin = "INCORRECT_OR_INVALID_TIN";

        public const string IncorrectOrMissingOtherProviderId =
            "INCORRECT_OR_MISSING_OTHER_PROVIDER_ID";

        public const string IncorrectOrMissingProviderAddress =
            "INCORRECT_OR_MISSING_PROVIDER_ADDRESS";

        public const string Unknown = "UNKNOWN";
    }
}
