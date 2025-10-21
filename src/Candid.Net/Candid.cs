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
using Candid.Net.ExpectedNetworkStatus;
using Candid.Net.Exports;
using Candid.Net.ExternalPaymentAccountConfig;
using Candid.Net.FeeSchedules;
using Candid.Net.Guarantor;
using Candid.Net.HealthCareCodeInformation;
using Candid.Net.ImportInvoice;
using Candid.Net.InsuranceAdjudications;
using Candid.Net.InsurancePayments;
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
using Candid.Net.ServiceFacility;
using Candid.Net.ServiceLines;
using Candid.Net.Superbills;
using Candid.Net.Tasks;
using Candid.Net.WriteOffs;

namespace Candid.Net;

public partial class Candid
{
    private readonly RawClient _client;

    public Candid(string clientId, string clientSecret, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Candid.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Candid.Net/1.12.0" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var tokenProvider = new OAuthTokenProvider(
            clientId,
            clientSecret,
            new DefaultClient(new RawClient(clientOptions.Clone()))
        );
        clientOptions.Headers["Authorization"] = new Func<string>(() =>
            tokenProvider.GetAccessTokenAsync().Result
        );
        _client = new RawClient(clientOptions);
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
        Encounters = new EncountersClient(_client);
        ExpectedNetworkStatus = new ExpectedNetworkStatusClient(_client);
        Exports = new ExportsClient(_client);
        ExternalPaymentAccountConfig = new ExternalPaymentAccountConfigClient(_client);
        FeeSchedules = new FeeSchedulesClient(_client);
        Guarantor = new GuarantorClient(_client);
        HealthCareCodeInformation = new HealthCareCodeInformationClient(_client);
        ImportInvoice = new ImportInvoiceClient(_client);
        InsuranceAdjudications = new InsuranceAdjudicationsClient(_client);
        InsurancePayments = new InsurancePaymentsClient(_client);
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
        ServiceFacility = new ServiceFacilityClient(_client);
    }

    public AuthClient Auth { get; }

    public BillingNotesClient BillingNotes { get; }

    public ChargeCaptureBundlesClient ChargeCaptureBundles { get; }

    public ChargeCaptureClient ChargeCapture { get; }

    public ContractsClient Contracts { get; }

    public CredentialingClient Credentialing { get; }

    public CustomSchemasClient CustomSchemas { get; }

    public EligibilityClient Eligibility { get; }

    public EncounterAttachmentsClient EncounterAttachments { get; }

    public EncounterProvidersClient EncounterProviders { get; }

    public EncountersClient Encounters { get; }

    public ExpectedNetworkStatusClient ExpectedNetworkStatus { get; }

    public ExportsClient Exports { get; }

    public ExternalPaymentAccountConfigClient ExternalPaymentAccountConfig { get; }

    public FeeSchedulesClient FeeSchedules { get; }

    public GuarantorClient Guarantor { get; }

    public HealthCareCodeInformationClient HealthCareCodeInformation { get; }

    public ImportInvoiceClient ImportInvoice { get; }

    public InsuranceAdjudicationsClient InsuranceAdjudications { get; }

    public InsurancePaymentsClient InsurancePayments { get; }

    public InsuranceRefundsClient InsuranceRefunds { get; }

    public MedicationDispenseClient MedicationDispense { get; }

    public NonInsurancePayerPaymentsClient NonInsurancePayerPayments { get; }

    public NonInsurancePayerRefundsClient NonInsurancePayerRefunds { get; }

    public NonInsurancePayersClient NonInsurancePayers { get; }

    public OrganizationProvidersClient OrganizationProviders { get; }

    public OrganizationServiceFacilitiesClient OrganizationServiceFacilities { get; }

    public PatientArClient PatientAr { get; }

    public PatientPaymentsClient PatientPayments { get; }

    public PatientRefundsClient PatientRefunds { get; }

    public PayerPlanGroupsClient PayerPlanGroups { get; }

    public PayersClient Payers { get; }

    public ServiceLinesClient ServiceLines { get; }

    public SuperbillsClient Superbills { get; }

    public TasksClient Tasks { get; }

    public WriteOffsClient WriteOffs { get; }

    public PreEncounterClient PreEncounter { get; }

    public DiagnosesClient Diagnoses { get; }

    public ServiceFacilityClient ServiceFacility { get; }
}
