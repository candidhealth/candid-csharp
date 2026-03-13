using Candid.Net.Auth;
using Candid.Net.BillingNotes;
using Candid.Net.ChargeCapture;
using Candid.Net.ChargeCaptureBundles;
using Candid.Net.Contracts;
using Candid.Net.Credentialing;
using Candid.Net.CustomSchemas;
using Candid.Net.Diagnoses;
using Candid.Net.Eligibility;
using Candid.Net.EncounterAttachments;
using Candid.Net.EncounterProviders;
using Candid.Net.Encounters;
using Candid.Net.EncounterSupplementalInformation;
using Candid.Net.Events;
using Candid.Net.Exports;
using Candid.Net.ExternalPaymentAccountConfig;
using Candid.Net.FeeSchedules;
using Candid.Net.Guarantor;
using Candid.Net.HealthCareCodeInformation;
using Candid.Net.ImportInvoice;
using Candid.Net.InsuranceAdjudications;
using Candid.Net.InsuranceRefunds;
using Candid.Net.MedicationDispense;
using Candid.Net.NonInsurancePayerPayments;
using Candid.Net.NonInsurancePayerRefunds;
using Candid.Net.NonInsurancePayers;
using Candid.Net.OrganizationProviders;
using Candid.Net.OrganizationServiceFacilities;
using Candid.Net.PatientAr;
using Candid.Net.PatientPayments;
using Candid.Net.PatientRefunds;
using Candid.Net.PayerPlanGroups;
using Candid.Net.Payers;
using Candid.Net.PreEncounter;
using Candid.Net.ServiceLines;
using Candid.Net.Superbills;
using Candid.Net.Tasks;
using Candid.Net.WriteOffs;

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
