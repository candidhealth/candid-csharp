using Candid.Net.Auth;
using Candid.Net.Auth.V2;
using Candid.Net.BillingNotes;
using Candid.Net.ChargeCapture;
using Candid.Net.ChargeCaptureBundles;
using Candid.Net.ClaimSubmission;
using Candid.Net.Contracts;
using Candid.Net.Core;
using Candid.Net.Credentialing;
using Candid.Net.CustomSchemas;
using Candid.Net.Eligibility;
using Candid.Net.EncounterProviders;
using Candid.Net.Encounters;
using Candid.Net.ExpectedNetworkStatus;
using Candid.Net.Exports;
using Candid.Net.ExternalPaymentAccountConfig;
using Candid.Net.FeeSchedules;
using Candid.Net.Guarantor;
using Candid.Net.ImportInvoice;
using Candid.Net.InsuranceAdjudications;
using Candid.Net.InsurancePayments;
using Candid.Net.InsuranceRefunds;
using Candid.Net.Invoices;
using Candid.Net.MedicationDispense;
using Candid.Net.NonInsurancePayerPayments;
using Candid.Net.NonInsurancePayerRefunds;
using Candid.Net.NonInsurancePayers;
using Candid.Net.OrganizationProviders;
using Candid.Net.OrganizationServiceFacilities;
using Candid.Net.PatientPayments;
using Candid.Net.PatientRefunds;
using Candid.Net.Payers;
using Candid.Net.PreEncounter;
using Candid.Net.ServiceLines;
using Candid.Net.Tasks;
using Candid.Net.WriteOffs;

#nullable enable

namespace Candid.Net;

public partial class Candid
{
    private RawClient _client;

    public Candid(string clientId, string clientSecret, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Candid.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Candid.Net/0.40.3" },
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
            new V2Client(new RawClient(clientOptions.Clone()))
        );
        clientOptions.Headers["Authorization"] = new Func<string>(
            () => tokenProvider.GetAccessTokenAsync().Result
        );
        _client = new RawClient(clientOptions);
        Auth = new AuthClient(_client);
        BillingNotes = new BillingNotesClient(_client);
        ChargeCaptureBundles = new ChargeCaptureBundlesClient(_client);
        ChargeCapture = new ChargeCaptureClient(_client);
        ClaimSubmission = new ClaimSubmissionClient(_client);
        Contracts = new ContractsClient(_client);
        Credentialing = new CredentialingClient(_client);
        CustomSchemas = new CustomSchemasClient(_client);
        Eligibility = new EligibilityClient(_client);
        EncounterProviders = new EncounterProvidersClient(_client);
        Encounters = new EncountersClient(_client);
        ExpectedNetworkStatus = new ExpectedNetworkStatusClient(_client);
        Exports = new ExportsClient(_client);
        ExternalPaymentAccountConfig = new ExternalPaymentAccountConfigClient(_client);
        FeeSchedules = new FeeSchedulesClient(_client);
        Guarantor = new GuarantorClient(_client);
        ImportInvoice = new ImportInvoiceClient(_client);
        InsuranceAdjudications = new InsuranceAdjudicationsClient(_client);
        InsurancePayments = new InsurancePaymentsClient(_client);
        InsuranceRefunds = new InsuranceRefundsClient(_client);
        Invoices = new InvoicesClient(_client);
        MedicationDispense = new MedicationDispenseClient(_client);
        NonInsurancePayerPayments = new NonInsurancePayerPaymentsClient(_client);
        NonInsurancePayerRefunds = new NonInsurancePayerRefundsClient(_client);
        NonInsurancePayers = new NonInsurancePayersClient(_client);
        OrganizationServiceFacilities = new OrganizationServiceFacilitiesClient(_client);
        OrganizationProviders = new OrganizationProvidersClient(_client);
        PatientPayments = new PatientPaymentsClient(_client);
        PatientRefunds = new PatientRefundsClient(_client);
        Payers = new PayersClient(_client);
        ServiceLines = new ServiceLinesClient(_client);
        Tasks = new TasksClient(_client);
        WriteOffs = new WriteOffsClient(_client);
        PreEncounter = new PreEncounterClient(_client);
        Claims = new ClaimsClient(_client);
        Commons = new CommonsClient(_client);
        Diagnoses = new DiagnosesClient(_client);
        Era = new EraClient(_client);
        Financials = new FinancialsClient(_client);
        Individual = new IndividualClient(_client);
        ServiceFacility = new ServiceFacilityClient(_client);
        Tags = new TagsClient(_client);
    }

    public AuthClient Auth { get; init; }

    public BillingNotesClient BillingNotes { get; init; }

    public ChargeCaptureBundlesClient ChargeCaptureBundles { get; init; }

    public ChargeCaptureClient ChargeCapture { get; init; }

    public ClaimSubmissionClient ClaimSubmission { get; init; }

    public ContractsClient Contracts { get; init; }

    public CredentialingClient Credentialing { get; init; }

    public CustomSchemasClient CustomSchemas { get; init; }

    public EligibilityClient Eligibility { get; init; }

    public EncounterProvidersClient EncounterProviders { get; init; }

    public EncountersClient Encounters { get; init; }

    public ExpectedNetworkStatusClient ExpectedNetworkStatus { get; init; }

    public ExportsClient Exports { get; init; }

    public ExternalPaymentAccountConfigClient ExternalPaymentAccountConfig { get; init; }

    public FeeSchedulesClient FeeSchedules { get; init; }

    public GuarantorClient Guarantor { get; init; }

    public ImportInvoiceClient ImportInvoice { get; init; }

    public InsuranceAdjudicationsClient InsuranceAdjudications { get; init; }

    public InsurancePaymentsClient InsurancePayments { get; init; }

    public InsuranceRefundsClient InsuranceRefunds { get; init; }

    public InvoicesClient Invoices { get; init; }

    public MedicationDispenseClient MedicationDispense { get; init; }

    public NonInsurancePayerPaymentsClient NonInsurancePayerPayments { get; init; }

    public NonInsurancePayerRefundsClient NonInsurancePayerRefunds { get; init; }

    public NonInsurancePayersClient NonInsurancePayers { get; init; }

    public OrganizationServiceFacilitiesClient OrganizationServiceFacilities { get; init; }

    public OrganizationProvidersClient OrganizationProviders { get; init; }

    public PatientPaymentsClient PatientPayments { get; init; }

    public PatientRefundsClient PatientRefunds { get; init; }

    public PayersClient Payers { get; init; }

    public ServiceLinesClient ServiceLines { get; init; }

    public TasksClient Tasks { get; init; }

    public WriteOffsClient WriteOffs { get; init; }

    public PreEncounterClient PreEncounter { get; init; }

    public ClaimsClient Claims { get; init; }

    public CommonsClient Commons { get; init; }

    public DiagnosesClient Diagnoses { get; init; }

    public EraClient Era { get; init; }

    public FinancialsClient Financials { get; init; }

    public IndividualClient Individual { get; init; }

    public ServiceFacilityClient ServiceFacility { get; init; }

    public TagsClient Tags { get; init; }
}
