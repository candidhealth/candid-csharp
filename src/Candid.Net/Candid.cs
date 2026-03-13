using Candid.Net.Auth;
using Candid.Net.Auth.Default;
using Candid.Net.BillingNotes;
using Candid.Net.ChargeCapture;
using Candid.Net.ChargeCaptureBundles;
using Candid.Net.Contracts;
using Candid.Net.Core;
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

public partial class Candid : ICandid
{
    private readonly RawClient _client;

    public Candid(string clientId, string clientSecret, ClientOptions? clientOptions = null)
    {
        clientOptions ??= new ClientOptions();
        var platformHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Candid.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Candid.Net/1.20.3" },
            }
        );
        foreach (var header in platformHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var clientOptionsWithAuth = clientOptions.Clone();
        var tokenProvider = new OAuthTokenProvider(
            clientId,
            clientSecret,
            new DefaultClient(new RawClient(clientOptions))
        );
        clientOptionsWithAuth.Headers["Authorization"] =
            new Func<global::System.Threading.Tasks.ValueTask<string>>(async () =>
                await tokenProvider.GetAccessTokenAsync().ConfigureAwait(false)
            );
        _client = new RawClient(clientOptionsWithAuth);
        Auth = new AuthClient(_client);
        BillingNotes = new BillingNotesClient(_client);
        ChargeCaptureBundles = new ChargeCaptureBundlesClient(_client);
        ChargeCapture = new ChargeCaptureClient(_client);
        Contracts = new ContractsClient(_client);
        Credentialing = new CredentialingClient(_client);
        CustomSchemas = new CustomSchemasClient(_client);
        Eligibility = new EligibilityClient(_client);
        EncounterAttachments = new EncounterAttachmentsClient(_client);
        EncounterProviders = new EncounterProvidersClient(_client);
        EncounterSupplementalInformation = new EncounterSupplementalInformationClient(_client);
        Encounters = new EncountersClient(_client);
        Events = new EventsClient(_client);
        Exports = new ExportsClient(_client);
        ExternalPaymentAccountConfig = new ExternalPaymentAccountConfigClient(_client);
        FeeSchedules = new FeeSchedulesClient(_client);
        Guarantor = new GuarantorClient(_client);
        HealthCareCodeInformation = new HealthCareCodeInformationClient(_client);
        ImportInvoice = new ImportInvoiceClient(_client);
        InsuranceAdjudications = new InsuranceAdjudicationsClient(_client);
        InsuranceRefunds = new InsuranceRefundsClient(_client);
        MedicationDispense = new MedicationDispenseClient(_client);
        NonInsurancePayerPayments = new NonInsurancePayerPaymentsClient(_client);
        NonInsurancePayerRefunds = new NonInsurancePayerRefundsClient(_client);
        NonInsurancePayers = new NonInsurancePayersClient(_client);
        OrganizationProviders = new OrganizationProvidersClient(_client);
        OrganizationServiceFacilities = new OrganizationServiceFacilitiesClient(_client);
        PatientAr = new PatientArClient(_client);
        PatientPayments = new PatientPaymentsClient(_client);
        PatientRefunds = new PatientRefundsClient(_client);
        PayerPlanGroups = new PayerPlanGroupsClient(_client);
        Payers = new PayersClient(_client);
        ServiceLines = new ServiceLinesClient(_client);
        Superbills = new SuperbillsClient(_client);
        Tasks = new TasksClient(_client);
        WriteOffs = new WriteOffsClient(_client);
        PreEncounter = new PreEncounterClient(_client);
        Diagnoses = new DiagnosesClient(_client);
    }

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
