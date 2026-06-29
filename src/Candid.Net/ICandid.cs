using global::Candid.Net.Auth;
using global::Candid.Net.BillingNotes;
using global::Candid.Net.ChargeCapture;
using global::Candid.Net.ChargeCaptureBundles;
using global::Candid.Net.Contracts;
using global::Candid.Net.Credentialing;
using global::Candid.Net.CustomSchemas;
using global::Candid.Net.Diagnoses;
using global::Candid.Net.Eligibility;
using global::Candid.Net.EncounterAttachments;
using global::Candid.Net.EncounterProviders;
using global::Candid.Net.Encounters;
using global::Candid.Net.EncounterSupplementalInformation;
using global::Candid.Net.Events;
using global::Candid.Net.Exports;
using global::Candid.Net.ExternalPaymentAccountConfig;
using global::Candid.Net.FeeSchedules;
using global::Candid.Net.Guarantor;
using global::Candid.Net.HealthCareCodeInformation;
using global::Candid.Net.ImportInvoice;
using global::Candid.Net.InsuranceAdjudications;
using global::Candid.Net.InsuranceRefunds;
using global::Candid.Net.MedicationDispense;
using global::Candid.Net.NonInsurancePayerPayments;
using global::Candid.Net.NonInsurancePayerRefunds;
using global::Candid.Net.NonInsurancePayers;
using global::Candid.Net.OrganizationProviders;
using global::Candid.Net.OrganizationServiceFacilities;
using global::Candid.Net.PatientAr;
using global::Candid.Net.PatientPayments;
using global::Candid.Net.PatientRefunds;
using global::Candid.Net.PayerPlanGroups;
using global::Candid.Net.Payers;
using global::Candid.Net.PreEncounter;
using global::Candid.Net.ServiceLines;
using global::Candid.Net.Superbills;
using global::Candid.Net.Tasks;
using global::Candid.Net.WriteOffs;

namespace Candid.Net;

public partial interface ICandid
{
    public IAuthClient Auth { get; }
    public IBillingNotesClient BillingNotes { get; }
    public IChargeCaptureBundlesClient ChargeCaptureBundles { get; }
    public IChargeCaptureClient ChargeCapture { get; }
    public IContractsClient Contracts { get; }
    public ICredentialingClient Credentialing { get; }
    public ICustomSchemasClient CustomSchemas { get; }
    public IEligibilityClient Eligibility { get; }
    public IEncounterAttachmentsClient EncounterAttachments { get; }
    public IEncounterProvidersClient EncounterProviders { get; }
    public IEncounterSupplementalInformationClient EncounterSupplementalInformation { get; }
    public IEncountersClient Encounters { get; }
    public IEventsClient Events { get; }
    public IExportsClient Exports { get; }
    public IExternalPaymentAccountConfigClient ExternalPaymentAccountConfig { get; }
    public IFeeSchedulesClient FeeSchedules { get; }
    public IGuarantorClient Guarantor { get; }
    public IHealthCareCodeInformationClient HealthCareCodeInformation { get; }
    public IImportInvoiceClient ImportInvoice { get; }
    public IInsuranceAdjudicationsClient InsuranceAdjudications { get; }
    public IInsuranceRefundsClient InsuranceRefunds { get; }
    public IMedicationDispenseClient MedicationDispense { get; }
    public INonInsurancePayerPaymentsClient NonInsurancePayerPayments { get; }
    public INonInsurancePayerRefundsClient NonInsurancePayerRefunds { get; }
    public INonInsurancePayersClient NonInsurancePayers { get; }
    public IOrganizationProvidersClient OrganizationProviders { get; }
    public IOrganizationServiceFacilitiesClient OrganizationServiceFacilities { get; }
    public IPatientArClient PatientAr { get; }
    public IPatientPaymentsClient PatientPayments { get; }
    public IPatientRefundsClient PatientRefunds { get; }
    public IPayerPlanGroupsClient PayerPlanGroups { get; }
    public IPayersClient Payers { get; }
    public IServiceLinesClient ServiceLines { get; }
    public ISuperbillsClient Superbills { get; }
    public ITasksClient Tasks { get; }
    public IWriteOffsClient WriteOffs { get; }
    public IPreEncounterClient PreEncounter { get; }
    public IDiagnosesClient Diagnoses { get; }
}
