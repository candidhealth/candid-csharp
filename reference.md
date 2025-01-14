# Reference
## Auth V2
<details><summary><code>client.Auth.V2.<a href="/src/Candid.Net/Auth/V2/V2Client.cs">GetTokenAsync</a>(AuthGetTokenRequest { ... }) -> AuthGetTokenResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

<Callout intent="info">
Candid Health SDKs automatically handle authentication workflows after configuring them with the `client_id` and
`client_secret`.
</Callout>

Candid Health utilizes the [OAuth 2.0 bearer token authentication scheme](https://developer.mozilla.org/en-US/docs/Web/HTTP/Authentication) in our auth flow. You obtain the bearer token for all
subsequent API requests via the `/auth/token` endpoint defined below, which requires you to provide your `client_id` and `client_secret`. Your `client_id` and `client_secret` can be [generated](https://support.joincandidhealth.com/hc/en-us/articles/23065219476244--Generating-Candid-API-Keys) from the "Users & Credentials" tab by your org admin.

The bearer token is a signed [JWT](https://jwt.io/). The public key for the JWT can be found [here](https://candidhealth.auth0.com/pem) for any verification workflows.

The bearer token should be provided in the `Authorization` header for all subsequent API calls.

<Callout intent="warning">
The bearer token expires 5 hours after it has been created. After it has expired, the client will receive an "HTTP 401
Unauthorized" error, at which point the client should generate a new token. It is important that tokens be reused between
requests; if the client attempts to generate a token too often, it will be rate-limited and will receive an `HTTP 429 Too Many Requests` error.
</Callout>
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Auth.V2.GetTokenAsync(
    new AuthGetTokenRequest { ClientId = "YOUR_CLIENT_ID", ClientSecret = "YOUR_CLIENT_SECRET" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthGetTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## BillingNotes V2
<details><summary><code>client.BillingNotes.V2.<a href="/src/Candid.Net/BillingNotes/V2/V2Client.cs">CreateAsync</a>(StandaloneBillingNoteCreate { ... }) -> BillingNote</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BillingNotes.V2.CreateAsync(
    new StandaloneBillingNoteCreate
    {
        EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Text = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StandaloneBillingNoteCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BillingNotes.V2.<a href="/src/Candid.Net/BillingNotes/V2/V2Client.cs">DeleteAsync</a>(billingNoteId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BillingNotes.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**billingNoteId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.BillingNotes.V2.<a href="/src/Candid.Net/BillingNotes/V2/V2Client.cs">UpdateAsync</a>(billingNoteId, BillingNoteUpdate { ... }) -> BillingNote</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.BillingNotes.V2.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new BillingNoteUpdate { Text = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**billingNoteId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `BillingNoteUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ChargeCapture V1
<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">CreateAsync</a>(CreateChargeCaptureRequest { ... }) -> ChargeCapture.V1.ChargeCapture</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.CreateAsync(
    new CreateChargeCaptureRequest
    {
        Data = new ChargeCaptureData
        {
            Diagnoses = new List<DiagnosisCreate>() { },
            Interventions = new List<Intervention>() { },
            ExternalClaimSubmission = new ExternalClaimSubmissionCreate
            {
                ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
                PatientControlNumber = "PATIENT_CONTROL_NUMBER",
                SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
                {
                    new ClaimSubmissionRecordCreate
                    {
                        SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
                        ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
                        PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                        IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                    },
                    new ClaimSubmissionRecordCreate
                    {
                        SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
                        ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
                        PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                        IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                    },
                },
            },
            ServiceLines = new List<ServiceLineCreate>() { },
            PatientHistories = new List<PatientHistoryCategory>() { },
            BillingNotes = new List<BillingNote>() { },
            BenefitsAssignedToProvider = true,
            PriorAuthorizationNumber = "string",
            ExternalId = "string",
            DateOfService = new DateOnly(2023, 1, 15),
            TagIds = new List<string>() { },
            ClinicalNotes = new List<ClinicalNoteCategoryCreate>() { },
            PayToAddress = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            BillableStatus = BillableStatusType.Billable,
            ResponsibleParty = ResponsiblePartyType.InsurancePay,
            ProviderAcceptsAssignment = true,
            Synchronicity = SynchronicityType.Synchronous,
            PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
            AppointmentType = "string",
            EndDateOfService = new DateOnly(2023, 1, 15),
            SubscriberPrimary = new SubscriberCreate
            {
                InsuranceCard = new InsuranceCardCreate
                {
                    MemberId = "string",
                    PayerName = "string",
                    PayerId = "string",
                },
                PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
                FirstName = "string",
                LastName = "string",
                Gender = Candid.Net.Gender.Male,
            },
            SubscriberSecondary = new SubscriberCreate
            {
                InsuranceCard = new InsuranceCardCreate
                {
                    MemberId = "string",
                    PayerName = "string",
                    PayerId = "string",
                },
                PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
                FirstName = "string",
                LastName = "string",
                Gender = Candid.Net.Gender.Male,
            },
            AdditionalInformation = "string",
            ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
            AdmissionDate = new DateOnly(2023, 1, 15),
            DischargeDate = new DateOnly(2023, 1, 15),
            OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
            LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
            DelayReasonCode = DelayReasonCode.C1,
            Patient = new PatientUpdate(),
            PatientAuthorizedRelease = true,
            SchemaInstances = new List<SchemaInstance>() { },
            Vitals = new VitalsUpdate
            {
                HeightIn = 70,
                WeightLbs = 165,
                BloodPressureSystolicMmhg = 115,
                BloodPressureDiastolicMmhg = 85,
                BodyTemperatureF = 98,
                HemoglobinGdl = 15.1,
                HematocritPct = 51.2,
            },
            ExistingMedications = new List<Medication>() { },
            RenderingProvider = new RenderingProviderUpdate(),
            ServiceFacility = new EncounterServiceFacilityUpdate
            {
                OrganizationName = "Test Organization",
                Address = new StreetAddressLongZip
                {
                    Address1 = "123 Main St",
                    Address2 = "Apt 1",
                    City = "New York",
                    State = State.Ny,
                    ZipCode = "10001",
                    ZipPlusFourCode = "1234",
                },
            },
            Guarantor = new GuarantorUpdate(),
            BillingProvider = new BillingProviderUpdate(),
            SupervisingProvider = new SupervisingProviderUpdate(),
            ReferringProvider = new ReferringProviderUpdate(),
            InitialReferringProvider = new InitialReferringProviderUpdate(),
            ReferralNumber = "string",
        },
        ChargeExternalId = "string",
        EhrSourceUrl = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        PatientExternalId = "string",
        Status = ChargeCaptureStatus.Planned,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateChargeCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">DeleteAsync</a>(chargeCaptureId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**chargeCaptureId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">UpdateAsync</a>(chargeCaptureId, ChargeCaptureUpdate { ... }) -> ChargeCapture.V1.ChargeCapture</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ChargeCaptureUpdate
    {
        Data = new ChargeCaptureData
        {
            Diagnoses = new List<DiagnosisCreate>() { },
            Interventions = new List<Intervention>() { },
            ExternalClaimSubmission = new ExternalClaimSubmissionCreate
            {
                ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
                PatientControlNumber = "PATIENT_CONTROL_NUMBER",
                SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
                {
                    new ClaimSubmissionRecordCreate
                    {
                        SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
                        ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
                        PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                        IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                    },
                    new ClaimSubmissionRecordCreate
                    {
                        SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
                        ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
                        PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                        IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                    },
                },
            },
            ServiceLines = new List<ServiceLineCreate>() { },
            PatientHistories = new List<PatientHistoryCategory>() { },
            BillingNotes = new List<BillingNote>() { },
            BenefitsAssignedToProvider = true,
            PriorAuthorizationNumber = "string",
            ExternalId = "string",
            DateOfService = new DateOnly(2023, 1, 15),
            TagIds = new List<string>() { },
            ClinicalNotes = new List<ClinicalNoteCategoryCreate>() { },
            PayToAddress = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            BillableStatus = BillableStatusType.Billable,
            ResponsibleParty = ResponsiblePartyType.InsurancePay,
            ProviderAcceptsAssignment = true,
            Synchronicity = SynchronicityType.Synchronous,
            PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
            AppointmentType = "string",
            EndDateOfService = new DateOnly(2023, 1, 15),
            SubscriberPrimary = new SubscriberCreate
            {
                InsuranceCard = new InsuranceCardCreate
                {
                    MemberId = "string",
                    PayerName = "string",
                    PayerId = "string",
                },
                PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
                FirstName = "string",
                LastName = "string",
                Gender = Candid.Net.Gender.Male,
            },
            SubscriberSecondary = new SubscriberCreate
            {
                InsuranceCard = new InsuranceCardCreate
                {
                    MemberId = "string",
                    PayerName = "string",
                    PayerId = "string",
                },
                PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
                FirstName = "string",
                LastName = "string",
                Gender = Candid.Net.Gender.Male,
            },
            AdditionalInformation = "string",
            ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
            AdmissionDate = new DateOnly(2023, 1, 15),
            DischargeDate = new DateOnly(2023, 1, 15),
            OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
            LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
            DelayReasonCode = DelayReasonCode.C1,
            Patient = new PatientUpdate(),
            PatientAuthorizedRelease = true,
            SchemaInstances = new List<SchemaInstance>() { },
            Vitals = new VitalsUpdate
            {
                HeightIn = 70,
                WeightLbs = 165,
                BloodPressureSystolicMmhg = 115,
                BloodPressureDiastolicMmhg = 85,
                BodyTemperatureF = 98,
                HemoglobinGdl = 15.1,
                HematocritPct = 51.2,
            },
            ExistingMedications = new List<Medication>() { },
            RenderingProvider = new RenderingProviderUpdate(),
            ServiceFacility = new EncounterServiceFacilityUpdate
            {
                OrganizationName = "Test Organization",
                Address = new StreetAddressLongZip
                {
                    Address1 = "123 Main St",
                    Address2 = "Apt 1",
                    City = "New York",
                    State = State.Ny,
                    ZipCode = "10001",
                    ZipPlusFourCode = "1234",
                },
            },
            Guarantor = new GuarantorUpdate(),
            BillingProvider = new BillingProviderUpdate(),
            SupervisingProvider = new SupervisingProviderUpdate(),
            ReferringProvider = new ReferringProviderUpdate(),
            InitialReferringProvider = new InitialReferringProviderUpdate(),
            ReferralNumber = "string",
        },
        ChargeExternalId = "string",
        EhrSourceUrl = "string",
        PatientExternalId = "string",
        Status = ChargeCaptureStatus.Planned,
        DateOfService = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**chargeCaptureId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ChargeCaptureUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">GetAsync</a>(chargeCaptureId) -> ChargeCapture.V1.ChargeCapture</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**chargeCaptureId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">GetAllAsync</a>(GetAllChargeCapturesRequest { ... }) -> ChargeCapturePage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.GetAllAsync(
    new GetAllChargeCapturesRequest
    {
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        PatientExternalId = "string",
        Status = ChargeCaptureStatus.Planned,
        ChargeExternalId = "string",
        DateOfService = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllChargeCapturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Contracts V2
<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">GetAsync</a>(contractId) -> ContractWithProviders</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**contractId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">GetMultiAsync</a>(GetMultiContractsRequest { ... }) -> ContractsPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.GetMultiAsync(
    new GetMultiContractsRequest
    {
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        Limit = 1,
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        RenderingProviderIds = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
        PayerNames = ["string"],
        States = [State.Aa],
        ContractStatus = ContractStatus.Pending,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiContractsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">CreateAsync</a>(ContractCreate { ... }) -> ContractWithProviders</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new contract within the user's current organization
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.CreateAsync(
    new ContractCreate
    {
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        RenderingProviderIds = new HashSet<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        EffectiveDate = "string",
        ExpirationDate = "string",
        Regions = new RegionStates(),
        ContractStatus = ContractStatus.Pending,
        AuthorizedSignatory = new AuthorizedSignatory
        {
            FirstName = "string",
            LastName = "string",
            Title = "string",
            Email = "string",
            Phone = "string",
            Fax = "string",
        },
        CommercialInsuranceTypes = "no-properties-union",
        MedicareInsuranceTypes = "no-properties-union",
        MedicaidInsuranceTypes = "no-properties-union",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ContractCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">DeleteAsync</a>(contractId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**contractId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">UpdateAsync</a>(contractId, ContractUpdate { ... }) -> ContractWithProviders</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ContractUpdate
    {
        RenderingProviderIds = new HashSet<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        EffectiveDate = "string",
        ExpirationDate = "string",
        Regions = new RegionStates { States = new List<State>() { State.Aa } },
        ContractStatus = ContractStatus.Pending,
        AuthorizedSignatory = new AuthorizedSignatory
        {
            FirstName = "string",
            LastName = "string",
            Title = "string",
            Email = "string",
            Phone = "string",
            Fax = "string",
        },
        CommercialInsuranceTypes = "no-properties-union",
        MedicareInsuranceTypes = "no-properties-union",
        MedicaidInsuranceTypes = "no-properties-union",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**contractId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ContractUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Credentialing V2
<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">CreateAsync</a>(ProviderCredentialingSpanCreate { ... }) -> ProviderCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.CreateAsync(
    new ProviderCredentialingSpanCreate
    {
        RenderingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        StartDate = new DateOnly(2023, 1, 15),
        EndDate = new DateOnly(2023, 1, 15),
        Regions = new RegionStates { States = new List<State>() { State.Aa } },
        SubmittedDate = new DateOnly(2023, 1, 15),
        PayerLoadedDate = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ProviderCredentialingSpanCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetAsync</a>(providerCredentialingId) -> ProviderCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**providerCredentialingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetAllAsync</a>(GetAllProviderCredentialingSpansRequest { ... }) -> ProviderCredentialingSpanPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.GetAllAsync(
    new GetAllProviderCredentialingSpansRequest
    {
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        AsRenderingProvider = true,
        AsContractingProvider = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllProviderCredentialingSpansRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">DeleteAsync</a>(providerCredentialingId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Soft deletes a credentialing span rate from the system.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**providerCredentialingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">UpdateAsync</a>(providerCredentialingId, ProviderCredentialingSpanUpdate { ... }) -> ProviderCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ProviderCredentialingSpanUpdate
    {
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        StartDate = new DateOnly(2023, 1, 15),
        EndDate = new DateOnly(2023, 1, 15),
        Regions = new RegionStates { States = new List<State>() { State.Aa } },
        SubmittedDate = new DateOnly(2023, 1, 15),
        PayerLoadedDate = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**providerCredentialingId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ProviderCredentialingSpanUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## CustomSchemas V1
<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">GetMultiAsync</a>() -> SchemaGetMultiResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all custom schemas.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CustomSchemas.V1.GetMultiAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">GetAsync</a>(schemaId) -> Schema</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a custom schema with a given ID.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CustomSchemas.V1.GetAsync("ec096b13-f80a-471d-aaeb-54b021c9d582");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**schemaId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">CreateAsync</a>(SchemaCreate { ... }) -> Schema</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create custom schema with a set of typed keys. Schema keys can be referenced as inputs in user-configurable rules in the Rules
Engine, and key-value pairs can be attached to claims via the Encounters API.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CustomSchemas.V1.CreateAsync(
    new SchemaCreate
    {
        Name = "General Medicine",
        Description = "Values associated with a generic visit",
        Fields = new List<SchemaField>()
        {
            new SchemaField { Key = "provider_category", Type = Primitive.String },
            new SchemaField { Key = "is_urgent_care", Type = Primitive.Boolean },
            new SchemaField { Key = "bmi", Type = Primitive.Double },
            new SchemaField { Key = "age", Type = Primitive.Integer },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SchemaCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">UpdateAsync</a>(schemaId, SchemaUpdate { ... }) -> Schema</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the name, description, or keys on a preexisting schema.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.CustomSchemas.V1.UpdateAsync(
    "ec096b13-f80a-471d-aaeb-54b021c9d582",
    new SchemaUpdate
    {
        Name = "General Medicine and Health",
        Description = "Values collected during all visits",
        FieldsToAdd = new List<SchemaField>()
        {
            new SchemaField { Key = "visit_type", Type = Primitive.String },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**schemaId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `SchemaUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Eligibility V2
<details><summary><code>client.Eligibility.V2.<a href="/src/Candid.Net/Eligibility/V2/V2Client.cs">SubmitEligibilityCheckAsync</a>(object { ... }) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This API is a wrapper around Change Healthcare's eligibility API. Below are some helpful documentation links:

- [Change Healthcare - Guides: Contents of the Eligibility Request Body](https://developers.changehealthcare.com/eligibilityandclaims/docs/contents-of-the-eligibility-request-body)
- [Change Healthcare - Guides: Use "Bare Minimum" Eligibility Requests](https://developers.changehealthcare.com/eligibilityandclaims/docs/use-bare-minimum-eligibility-requests)
- [Change Healthcare - Guides: Contents of the Eligibility Response](https://developers.changehealthcare.com/eligibilityandclaims/docs/contents-of-the-eligibility-response)
- [Change Healthcare - Guides: Eligibility JSON-to-EDI API Contents](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-json-to-edi-api-contents)
- [Change Healthcare - Guides: Eligibility Error Messages](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-error-messages)
- [Change Healthcare - Guides: FAQ](https://developers.changehealthcare.com/eligibilityandclaims/docs/frequently-asked-questions)
- [Change Healthcare - Guides: Eligibility FAQs](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-api-requests)
- [Change Healthcare - Guides: Sandbox API Values and Test Responses](https://developers.changehealthcare.com/eligibilityandclaims/docs/eligibility-sandbox-api-values-and-test-responses)
- [Change Healthcare - Guides: Sandbox Predefined Fields and Values](https://developers.changehealthcare.com/eligibilityandclaims/docs/sandbox-predefined-fields-and-values)
- [Change Healthcare - Guides: Using Test Payers in the Sandbox](https://developers.changehealthcare.com/eligibilityandclaims/docs/use-the-test-payers-in-the-sandbox-api)

A schema of the response object can be found here: [Change Healthcare Docs](https://developers.changehealthcare.com/eligibilityandclaims/reference/medicaleligibility)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Eligibility.V2.SubmitEligibilityCheckAsync(
    new Dictionary<object, object?>() { { "key", "value" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Eligibility.V2.<a href="/src/Candid.Net/Eligibility/V2/V2Client.cs">SubmitEligibilityCheckAvailityAsync</a>() -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

**Availity has transitioned their GET endpoint to a POST endpoint. Candid has updated their pass-through integration to enable backwards compatibility for the GET endpoint so that customers do not have to immediately update their integrations.**

**Candid recommends integrations with the [POST endpoint](https://docs.joincandidhealth.com/api-reference/eligibility/v-2/submit-eligibility-check-availity-post) to ensure the best possible integration experience. Given the transition, Availity’s documentation will be out of sync with this endpoint.**

If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint

This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:

- [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
- [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)

A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)

- Note Availity requires a free developer account to access this documentation.

Check connection status of Availity API and partners here:

- [Availity Trading Partner Connection Status](https://www.availity.com/status/)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Eligibility.V2.SubmitEligibilityCheckAvailityAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Eligibility.V2.<a href="/src/Candid.Net/Eligibility/V2/V2Client.cs">SubmitEligibilityCheckAvailityPostAsync</a>(object { ... }) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint

This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:

- [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
- [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)

A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)

- Note Availity requires a free developer account to access this documentation.

Check connection status of Availity API and partners here:

- [Availity Trading Partner Connection Status](https://www.availity.com/status/)
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Eligibility.V2.SubmitEligibilityCheckAvailityPostAsync(
    new Dictionary<object, object?>() { { "key", "value" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## EncounterProviders V2
<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateReferringProviderAsync</a>(encounterId, ReferringProviderUpdate { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.UpdateReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ReferringProviderUpdate()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ReferringProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateInitialReferringProviderAsync</a>(encounterId, InitialReferringProviderUpdate { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.UpdateInitialReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new InitialReferringProviderUpdate()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `InitialReferringProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateSupervisingProviderAsync</a>(encounterId, SupervisingProviderUpdate { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.UpdateSupervisingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new SupervisingProviderUpdate()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `SupervisingProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateOrderingProviderAsync</a>(serviceLineId, OrderingProviderUpdate { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.UpdateOrderingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new OrderingProviderUpdate
    {
        Npi = "string",
        TaxonomyCode = "string",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OrderingProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateReferringProviderAsync</a>(encounterId, ReferringProvider { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.CreateReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ReferringProvider
    {
        Npi = "string",
        TaxonomyCode = "string",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ReferringProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateInitialReferringProviderAsync</a>(encounterId, InitialReferringProvider { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.CreateInitialReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new InitialReferringProvider
    {
        Npi = "string",
        TaxonomyCode = "string",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        Qualifier = QualifierCode.Dq,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `InitialReferringProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateSupervisingProviderAsync</a>(encounterId, SupervisingProvider { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.CreateSupervisingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new SupervisingProvider
    {
        Npi = "string",
        TaxonomyCode = "string",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `SupervisingProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateOrderingProviderAsync</a>(serviceLineId, OrderingProvider { ... }) -> EncounterProvider</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.CreateOrderingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new OrderingProvider
    {
        Npi = "string",
        TaxonomyCode = "string",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OrderingProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">DeleteReferringProviderAsync</a>(encounterId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.DeleteReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">DeleteInitialReferringProviderAsync</a>(encounterId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.DeleteInitialReferringProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">DeleteSupervisingProviderAsync</a>(encounterId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.DeleteSupervisingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">DeleteOrderingProviderAsync</a>(serviceLineId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterProviders.V2.DeleteOrderingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Encounters V4
<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">GetAllAsync</a>(GetAllEncountersRequest { ... }) -> EncounterPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Encounters.V4.GetAllAsync(
    new GetAllEncountersRequest
    {
        Limit = 100,
        ClaimStatus = ClaimStatus.BillerReceived,
        Sort = EncounterSortOptions.CreatedAtAsc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        DateOfServiceMin = new DateOnly(2019, 8, 24),
        DateOfServiceMax = new DateOnly(2019, 8, 25),
        PrimaryPayerNames = "Medicare,Medicaid",
        SearchTerm = "doe",
        ExternalId = "123456",
        DiagnosesUpdatedSince = new DateTime(2019, 08, 24, 14, 15, 22, 000),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllEncountersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">GetAsync</a>(encounterId) -> Encounter</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Encounters.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateAsync</a>(EncounterCreate { ... }) -> Encounter</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Encounters.V4.CreateAsync(
    new EncounterCreate
    {
        Patient = new PatientCreate
        {
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            NonInsurancePayers = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
            NonInsurancePayersInfo = new List<PatientNonInsurancePayerInfoCreate>()
            {
                new PatientNonInsurancePayerInfoCreate
                {
                    NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    MemberId = "string",
                },
            },
            EmailConsent = true,
            ExternalId = "string",
            DateOfBirth = new DateOnly(2023, 1, 15),
            Address = new StreetAddressShortZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            FirstName = "string",
            LastName = "string",
            Gender = Candid.Net.Gender.Male,
        },
        BillingProvider = new BillingProvider
        {
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            TaxId = "string",
            Npi = "string",
            TaxonomyCode = "string",
            ProviderCommercialLicenseType =
                BillingProviderCommercialLicenseType.LicensedClinicalSocialWorker,
        },
        RenderingProvider = new RenderingProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        ReferringProvider = new ReferringProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        InitialReferringProvider = new InitialReferringProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            Qualifier = QualifierCode.Dq,
        },
        SupervisingProvider = new SupervisingProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        ServiceFacility = new EncounterServiceFacilityBase
        {
            OrganizationName = "string",
            Npi = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            SecondaryIdentification = "string",
        },
        SubscriberPrimary = new SubscriberCreate
        {
            InsuranceCard = new InsuranceCardCreate
            {
                MemberId = "string",
                PayerName = "string",
                PayerId = "string",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
            FirstName = "string",
            LastName = "string",
            Gender = Candid.Net.Gender.Male,
        },
        SubscriberSecondary = new SubscriberCreate
        {
            InsuranceCard = new InsuranceCardCreate
            {
                MemberId = "string",
                PayerName = "string",
                PayerId = "string",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
            FirstName = "string",
            LastName = "string",
            Gender = Candid.Net.Gender.Male,
        },
        PriorAuthorizationNumber = "string",
        ResponsibleParty = ResponsiblePartyType.InsurancePay,
        Diagnoses = new List<DiagnosisCreate>()
        {
            new DiagnosisCreate
            {
                Name = "string",
                CodeType = DiagnosisTypeCode.Abf,
                Code = "string",
            },
        },
        ClinicalNotes = new List<ClinicalNoteCategoryCreate>()
        {
            new ClinicalNoteCategoryCreate
            {
                Category = NoteCategory.Clinical,
                Notes = new List<ClinicalNote>()
                {
                    new ClinicalNote
                    {
                        Text = "string",
                        AuthorName = "string",
                        AuthorNpi = "string",
                        Timestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                    },
                },
            },
        },
        BillingNotes = new List<BillingNoteBase>() { new BillingNoteBase { Text = "string" } },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        PatientHistories = new List<PatientHistoryCategory>()
        {
            new PatientHistoryCategory
            {
                Category = PatientHistoryCategoryEnum.PresentIllness,
                Questions = new List<IntakeQuestion>()
                {
                    new IntakeQuestion
                    {
                        Id = "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
                        Text = "Do you have any allergies?",
                        Responses = new List<IntakeResponseAndFollowUps>()
                        {
                            new IntakeResponseAndFollowUps
                            {
                                Response = "No allergies",
                                FollowUps = new List<IntakeFollowUp>()
                                {
                                    new IntakeFollowUp
                                    {
                                        Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
                                        Text = "Do you have any allergies?",
                                        Response = "No allergies",
                                    },
                                },
                            },
                        },
                    },
                },
            },
        },
        ServiceLines = new List<ServiceLineCreate>()
        {
            new ServiceLineCreate
            {
                Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
                ProcedureCode = "string",
                Quantity = "string",
                Units = ServiceLineUnits.Mj,
                ChargeAmountCents = 1,
                DiagnosisPointers = new List<int>() { 1 },
                DrugIdentification = new DrugIdentification
                {
                    ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
                    NationalDrugCode = "string",
                    NationalDrugUnitCount = "string",
                    MeasurementUnitCode = MeasurementUnitCode.Milliliters,
                    LinkSequenceNumber = "string",
                    PharmacyPrescriptionNumber = "string",
                    ConversionFormula = "string",
                    DrugDescription = "string",
                },
                PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
                Description = "string",
                DateOfService = new DateOnly(2023, 1, 15),
                EndDateOfService = new DateOnly(2023, 1, 15),
                OrderingProvider = new OrderingProvider
                {
                    Npi = "string",
                    TaxonomyCode = "string",
                    Address = new StreetAddressLongZip
                    {
                        Address1 = "123 Main St",
                        Address2 = "Apt 1",
                        City = "New York",
                        State = State.Ny,
                        ZipCode = "10001",
                        ZipPlusFourCode = "1234",
                    },
                },
                TestResults = new List<TestResult>()
                {
                    new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
                },
            },
        },
        Guarantor = new GuarantorCreate
        {
            PhoneNumbers = new List<PhoneNumber>()
            {
                new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
            },
            PhoneConsent = true,
            Email = "johndoe@joincandidhealth.com",
            EmailConsent = true,
            FirstName = "string",
            LastName = "string",
            ExternalId = "string",
            DateOfBirth = new DateOnly(2023, 1, 15),
            Address = new StreetAddressShortZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        ExternalClaimSubmission = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
            PatientControlNumber = "PATIENT_CONTROL_NUMBER",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
            {
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
                    ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                },
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
                    ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                },
            },
        },
        TagIds = new List<string>() { "string" },
        SchemaInstances = new List<SchemaInstance>()
        {
            new SchemaInstance
            {
                SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
                Content = new Dictionary<string, object>()
                {
                    { "provider_category", "internist" },
                    { "is_urgent_care", true },
                    { "bmi", 24.2 },
                    { "age", 38 },
                },
            },
        },
        ReferralNumber = "string",
        ExternalId = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        EndDateOfService = new DateOnly(2023, 1, 15),
        PatientAuthorizedRelease = true,
        BenefitsAssignedToProvider = true,
        ProviderAcceptsAssignment = true,
        AppointmentType = "string",
        ExistingMedications = new List<Medication>()
        {
            new Medication
            {
                Name = "Lisinopril",
                RxCui = "860975",
                Dosage = "10mg",
                DosageForm = "Tablet",
                Frequency = "Once Daily",
                AsNeeded = true,
            },
        },
        Vitals = new Vitals
        {
            HeightIn = 70,
            WeightLbs = 165,
            BloodPressureSystolicMmhg = 115,
            BloodPressureDiastolicMmhg = 85,
            BodyTemperatureF = 98,
            HemoglobinGdl = 15.1,
            HematocritPct = 51.2,
        },
        Interventions = new List<Intervention>()
        {
            new Intervention
            {
                Name = "Physical Therapy Session",
                Category = InterventionCategory.Lifestyle,
                Description =
                    "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
                Medication = new Medication
                {
                    Name = "Lisinopril",
                    RxCui = "860975",
                    Dosage = "10mg",
                    DosageForm = "Tablet",
                    Frequency = "Once Daily",
                    AsNeeded = true,
                },
                Labs = new List<Lab>()
                {
                    new Lab
                    {
                        Name = "Genetic Health Labs",
                        Code = "GH12345",
                        CodeType = LabCodeType.Quest,
                    },
                },
            },
        },
        PayToAddress = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        Synchronicity = SynchronicityType.Synchronous,
        BillableStatus = BillableStatusType.Billable,
        AdditionalInformation = "string",
        ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
        AdmissionDate = new DateOnly(2023, 1, 15),
        DischargeDate = new DateOnly(2023, 1, 15),
        OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
        LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
        DelayReasonCode = DelayReasonCode.C1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EncounterCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateFromPreEncounterPatientAsync</a>(EncounterCreateFromPreEncounter { ... }) -> Encounter</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an encounter from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
of the pre-encounter service should use the standard create endpoint.

The endpoint will create an encounter from the provided fields, pulling information from the provided patient and appointment objects
where applicable. In particular, the following fields are populated from the patient and appointment objects:

- Patient
- Referring Provider
- Subscriber Primary
- Subscriber Secondary
- Referral Number
- Responsible Party
- Guarantor

Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
encounter has not already been submitted or adjudicated.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Encounters.V4.CreateFromPreEncounterPatientAsync(
    new EncounterCreateFromPreEncounter
    {
        PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PreEncounterAppointmentIds = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        BillingProvider = new BillingProvider
        {
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            TaxId = "string",
            Npi = "string",
            TaxonomyCode = "string",
            ProviderCommercialLicenseType =
                BillingProviderCommercialLicenseType.LicensedClinicalSocialWorker,
        },
        RenderingProvider = new RenderingProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        InitialReferringProvider = new InitialReferringProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            Qualifier = QualifierCode.Dq,
        },
        SupervisingProvider = new SupervisingProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        ServiceFacility = new EncounterServiceFacilityBase
        {
            OrganizationName = "string",
            Npi = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
            SecondaryIdentification = "string",
        },
        Diagnoses = new List<DiagnosisCreate>()
        {
            new DiagnosisCreate
            {
                Name = "string",
                CodeType = DiagnosisTypeCode.Abf,
                Code = "string",
            },
        },
        ClinicalNotes = new List<ClinicalNoteCategoryCreate>()
        {
            new ClinicalNoteCategoryCreate
            {
                Category = NoteCategory.Clinical,
                Notes = new List<ClinicalNote>()
                {
                    new ClinicalNote
                    {
                        Text = "string",
                        AuthorName = "string",
                        AuthorNpi = "string",
                        Timestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                    },
                },
            },
        },
        BillingNotes = new List<BillingNoteBase>() { new BillingNoteBase { Text = "string" } },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        PatientHistories = new List<PatientHistoryCategory>()
        {
            new PatientHistoryCategory
            {
                Category = PatientHistoryCategoryEnum.PresentIllness,
                Questions = new List<IntakeQuestion>()
                {
                    new IntakeQuestion
                    {
                        Id = "6E7FBCE4-A8EA-46D0-A8D8-FF83CA3BB176",
                        Text = "Do you have any allergies?",
                        Responses = new List<IntakeResponseAndFollowUps>()
                        {
                            new IntakeResponseAndFollowUps
                            {
                                Response = "No allergies",
                                FollowUps = new List<IntakeFollowUp>()
                                {
                                    new IntakeFollowUp
                                    {
                                        Id = "4F3D57F9-AC94-49D6-87E4-E804B709917A",
                                        Text = "Do you have any allergies?",
                                        Response = "No allergies",
                                    },
                                },
                            },
                        },
                    },
                },
            },
        },
        ServiceLines = new List<ServiceLineCreate>()
        {
            new ServiceLineCreate
            {
                Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
                ProcedureCode = "string",
                Quantity = "string",
                Units = ServiceLineUnits.Mj,
                ChargeAmountCents = 1,
                DiagnosisPointers = new List<int>() { 1 },
                DrugIdentification = new DrugIdentification
                {
                    ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
                    NationalDrugCode = "string",
                    NationalDrugUnitCount = "string",
                    MeasurementUnitCode = MeasurementUnitCode.Milliliters,
                    LinkSequenceNumber = "string",
                    PharmacyPrescriptionNumber = "string",
                    ConversionFormula = "string",
                    DrugDescription = "string",
                },
                PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
                Description = "string",
                DateOfService = new DateOnly(2023, 1, 15),
                EndDateOfService = new DateOnly(2023, 1, 15),
                OrderingProvider = new OrderingProvider
                {
                    Npi = "string",
                    TaxonomyCode = "string",
                    Address = new StreetAddressLongZip
                    {
                        Address1 = "123 Main St",
                        Address2 = "Apt 1",
                        City = "New York",
                        State = State.Ny,
                        ZipCode = "10001",
                        ZipPlusFourCode = "1234",
                    },
                },
                TestResults = new List<TestResult>()
                {
                    new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
                },
            },
        },
        ExternalClaimSubmission = new ExternalClaimSubmissionCreate
        {
            ClaimCreatedAt = new DateTime(2023, 01, 01, 12, 00, 00, 000),
            PatientControlNumber = "PATIENT_CONTROL_NUMBER",
            SubmissionRecords = new List<ClaimSubmissionRecordCreate>()
            {
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = new DateTime(2023, 01, 01, 13, 00, 00, 000),
                    ClaimFrequencyCode = ClaimFrequencyTypeCode.Original,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Electronic,
                },
                new ClaimSubmissionRecordCreate
                {
                    SubmittedAt = new DateTime(2023, 01, 04, 12, 00, 00, 000),
                    ClaimFrequencyCode = ClaimFrequencyTypeCode.Replacement,
                    PayerResponsibility = ClaimSubmissionPayerResponsibilityType.Primary,
                    IntendedSubmissionMedium = IntendedSubmissionMedium.Paper,
                },
            },
        },
        TagIds = new List<string>() { "string" },
        SchemaInstances = new List<SchemaInstance>()
        {
            new SchemaInstance
            {
                SchemaId = "ec096b13-f80a-471d-aaeb-54b021c9d582",
                Content = new Dictionary<string, object>()
                {
                    { "provider_category", "internist" },
                    { "is_urgent_care", true },
                    { "bmi", 24.2 },
                    { "age", 38 },
                },
            },
        },
        ExternalId = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        EndDateOfService = new DateOnly(2023, 1, 15),
        PatientAuthorizedRelease = true,
        BenefitsAssignedToProvider = true,
        ProviderAcceptsAssignment = true,
        AppointmentType = "string",
        ExistingMedications = new List<Medication>()
        {
            new Medication
            {
                Name = "Lisinopril",
                RxCui = "860975",
                Dosage = "10mg",
                DosageForm = "Tablet",
                Frequency = "Once Daily",
                AsNeeded = true,
            },
        },
        Vitals = new Vitals
        {
            HeightIn = 70,
            WeightLbs = 165,
            BloodPressureSystolicMmhg = 115,
            BloodPressureDiastolicMmhg = 85,
            BodyTemperatureF = 98,
            HemoglobinGdl = 15.1,
            HematocritPct = 51.2,
        },
        Interventions = new List<Intervention>()
        {
            new Intervention
            {
                Name = "Physical Therapy Session",
                Category = InterventionCategory.Lifestyle,
                Description =
                    "A session focused on improving muscular strength, flexibility, and range of motion post-injury.",
                Medication = new Medication
                {
                    Name = "Lisinopril",
                    RxCui = "860975",
                    Dosage = "10mg",
                    DosageForm = "Tablet",
                    Frequency = "Once Daily",
                    AsNeeded = true,
                },
                Labs = new List<Lab>()
                {
                    new Lab
                    {
                        Name = "Genetic Health Labs",
                        Code = "GH12345",
                        CodeType = LabCodeType.Quest,
                    },
                },
            },
        },
        PayToAddress = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        Synchronicity = SynchronicityType.Synchronous,
        BillableStatus = BillableStatusType.Billable,
        AdditionalInformation = "string",
        ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
        AdmissionDate = new DateOnly(2023, 1, 15),
        DischargeDate = new DateOnly(2023, 1, 15),
        OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
        LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
        DelayReasonCode = DelayReasonCode.C1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `EncounterCreateFromPreEncounter` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">UpdateAsync</a>(encounterId, EncounterUpdate { ... }) -> Encounter</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Encounters.V4.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new EncounterUpdate
    {
        DiagnosisIds = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        PlaceOfServiceCodeAsSubmitted = FacilityTypeCode.Pharmacy,
        BenefitsAssignedToProvider = true,
        PriorAuthorizationNumber = "string",
        ExternalId = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        TagIds = new List<string>() { },
        ClinicalNotes = new List<ClinicalNoteCategoryCreate>() { },
        PayToAddress = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        BillableStatus = BillableStatusType.Billable,
        ResponsibleParty = ResponsiblePartyType.InsurancePay,
        ProviderAcceptsAssignment = true,
        Synchronicity = SynchronicityType.Synchronous,
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        AppointmentType = "string",
        EndDateOfService = new DateOnly(2023, 1, 15),
        SubscriberPrimary = new SubscriberCreate
        {
            InsuranceCard = new InsuranceCardCreate
            {
                MemberId = "string",
                PayerName = "string",
                PayerId = "string",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
            FirstName = "string",
            LastName = "string",
            Gender = Candid.Net.Gender.Male,
        },
        SubscriberSecondary = new SubscriberCreate
        {
            InsuranceCard = new InsuranceCardCreate
            {
                MemberId = "string",
                PayerName = "string",
                PayerId = "string",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
            FirstName = "string",
            LastName = "string",
            Gender = Candid.Net.Gender.Male,
        },
        AdditionalInformation = "string",
        ServiceAuthorizationExceptionCode = ServiceAuthorizationExceptionCode.C1,
        AdmissionDate = new DateOnly(2023, 1, 15),
        DischargeDate = new DateOnly(2023, 1, 15),
        OnsetOfCurrentIllnessOrSymptomDate = new DateOnly(2023, 1, 15),
        LastMenstrualPeriodDate = new DateOnly(2023, 1, 15),
        DelayReasonCode = DelayReasonCode.C1,
        Patient = new PatientUpdate(),
        PatientAuthorizedRelease = true,
        SchemaInstances = new List<SchemaInstance>() { },
        Vitals = new VitalsUpdate
        {
            HeightIn = 70,
            WeightLbs = 165,
            BloodPressureSystolicMmhg = 115,
            BloodPressureDiastolicMmhg = 85,
            BodyTemperatureF = 98,
            HemoglobinGdl = 15.1,
            HematocritPct = 51.2,
        },
        ExistingMedications = new List<Medication>() { },
        RenderingProvider = new RenderingProviderUpdate(),
        ServiceFacility = new EncounterServiceFacilityUpdate
        {
            OrganizationName = "Test Organization",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        Guarantor = new GuarantorUpdate(),
        BillingProvider = new BillingProviderUpdate(),
        SupervisingProvider = new SupervisingProviderUpdate(),
        ReferringProvider = new ReferringProviderUpdate(),
        InitialReferringProvider = new InitialReferringProviderUpdate(),
        ReferralNumber = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `EncounterUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExpectedNetworkStatus V1
<details><summary><code>client.ExpectedNetworkStatus.V1.<a href="/src/Candid.Net/ExpectedNetworkStatus/V1/V1Client.cs">ComputeAsync</a>(ExpectedNetworkStatusRequest { ... }) -> ExpectedNetworkStatusResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the expected network status given the provided information.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ExpectedNetworkStatus.V1.ComputeAsync(
    new ExpectedNetworkStatusRequest
    {
        ExternalPatientId = "string",
        SubscriberPayerId = "string",
        SubscriberPayerName = "string",
        SubscriberInsuranceType = Candid.Net.InsuranceTypeCode.C01,
        SubscriberPlanName = "string",
        BillingProviderNpi = "string",
        BillingProviderTin = "string",
        RenderingProviderNpi = "string",
        ContractedState = State.Aa,
        DateOfService = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExpectedNetworkStatusRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExpectedNetworkStatus V2
<details><summary><code>client.ExpectedNetworkStatus.V2.<a href="/src/Candid.Net/ExpectedNetworkStatus/V2/V2Client.cs">ComputeForRenderingProviderAsync</a>(renderingProviderId, ExpectedNetworkStatusRequestV2 { ... }) -> ExpectedNetworkStatusResponseV2</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes the expected network status for a given rendering provider.
This endpoint is not available to all customers. Reach out to the Candid sales team
to discuss enabling this endpoint if it is not available for your organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ExpectedNetworkStatus.V2.ComputeForRenderingProviderAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ExpectedNetworkStatusRequestV2
    {
        ServiceType = ServiceType.NewPatientVideoAppt,
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        SubscriberInformation = new ExpectedNetworkStatusSubscriberInformation
        {
            PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            MemberId = "string",
            InsuranceType = new InsuranceType
            {
                LineOfBusiness = LineOfBusiness.Medicare,
                InsuranceTypeCodes = Candid.Net.InsuranceTypeCode.C01,
            },
        },
        PatientAddress = new StreetAddressShortZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationServiceFacilityId = "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569",
        DateOfService = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**renderingProviderId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ExpectedNetworkStatusRequestV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ExpectedNetworkStatus.V2.<a href="/src/Candid.Net/ExpectedNetworkStatus/V2/V2Client.cs">ComputeAllInNetworkProvidersAsync</a>(ComputeAllInNetworkProvidersRequest { ... }) -> ComputeAllInNetworkProvidersResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Computes all the in network providers for a given set of inputs.
This endpoint is not available to all customers. Reach out to the Candid sales team
to discuss enabling this endpoint if it is not available for your organization.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ExpectedNetworkStatus.V2.ComputeAllInNetworkProvidersAsync(
    new ComputeAllInNetworkProvidersRequest
    {
        ServiceType = ServiceType.NewPatientVideoAppt,
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        SubscriberInformation = new ExpectedNetworkStatusSubscriberInformation
        {
            PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            MemberId = "string",
            InsuranceType = new InsuranceType
            {
                LineOfBusiness = LineOfBusiness.Medicare,
                InsuranceTypeCodes = Candid.Net.InsuranceTypeCode.C01,
            },
        },
        PatientAddress = new StreetAddressShortZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationServiceFacilityId = "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569",
        DateOfService = new DateOnly(2023, 1, 15),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ComputeAllInNetworkProvidersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Exports V3
<details><summary><code>client.Exports.V3.<a href="/src/Candid.Net/Exports/V3/V3Client.cs">GetExportsAsync</a>(GetExportsRequest { ... }) -> GetExportsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve CSV-formatted reports on claim submissions and outcomes. This endpoint returns Export objects that contain an
authenticated URL to a customer's reports with a 2min TTL. The schema for the CSV export can be found [here](https://app.joincandidhealth.com/files/exports_schema.csv).

**Schema changes:** Changing column order, removing columns, or changing the name of a column is considered a
[Breaking Change](../../../api-principles/breaking-changes). Adding new columns to the end of the Exports file is not considered a
Breaking Change and happens periodically. For this reason, it is important that any downstream automation or processes built on top
of Candid Health's export files be resilient to the addition of new columns at the end of the file.

**SLA guarantees:** Files for a given date are guaranteed to be available after 3 business days. For example, Friday's file will be
available by Wednesday at the latest. If file generation is still in progress upon request before 3 business days have passed, the
caller will receive a 422 response. If the file has already been generated, it will be served. Historic files should be available
up to 90 days in the past by default. Please email our [Support team](mailto:support@joincandidhealth.com) with any data requests
outside of these stated guarantees.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Exports.V3.GetExportsAsync(
    new GetExportsRequest
    {
        StartDate = new DateOnly(2023, 10, 1),
        EndDate = new DateOnly(2023, 10, 2),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExternalPaymentAccountConfig V1
<details><summary><code>client.ExternalPaymentAccountConfig.V1.<a href="/src/Candid.Net/ExternalPaymentAccountConfig/V1/V1Client.cs">GetMultiAsync</a>(GetExternalPaymentAccountConfigsRequest { ... }) -> ExternalPaymentAccountConfigPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ExternalPaymentAccountConfig.V1.GetMultiAsync(
    new GetExternalPaymentAccountConfigsRequest
    {
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetExternalPaymentAccountConfigsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FeeSchedules V3
<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetMatchAsync</a>(serviceLineId) -> MatchResult?</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets the rate that matches a service line. No result means no rate exists matching the service line's dimensions.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetMatchAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">TestMatchAsync</a>(serviceLineId, rateId) -> MatchTestResult</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Tests a service line against a rate to see if it matches.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.TestMatchAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**rateId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetMultiAsync</a>(GetMultiRequest { ... }) -> RatesPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of dimensions with their rates. The rates returned will always be the most recent versions of those rates.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetMultiAsync(
    new GetMultiRequest
    {
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        Limit = 1,
        ActiveDate = new DateOnly(2023, 1, 15),
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        States = [State.Aa],
        ZipCodes = ["string"],
        LicenseTypes = [LicenseType.Md],
        FacilityTypeCodes = [FacilityTypeCode.Pharmacy],
        NetworkTypes = [Candid.Net.NetworkType.Ppo],
        CptCode = "string",
        Modifiers = [ProcedureModifier.TwentyTwo],
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetUniqueValuesForDimensionAsync</a>(GetUniqueDimensionValuesRequest { ... }) -> DimensionsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets unique values for a dimension based on other selection criteria. The response is a list of dimensions with your criteria and the unique values populated. This API is useful for driving pivots on dimension values.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetUniqueValuesForDimensionAsync(
    new GetUniqueDimensionValuesRequest
    {
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        Limit = 1,
        PivotDimension = DimensionName.PayerUuid,
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        States = [State.Aa],
        ZipCodes = ["string"],
        LicenseTypes = [LicenseType.Md],
        FacilityTypeCodes = [FacilityTypeCode.Pharmacy],
        NetworkTypes = [Candid.Net.NetworkType.Ppo],
        CptCode = "string",
        Modifiers = [ProcedureModifier.TwentyTwo],
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetUniqueDimensionValuesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetRateHistoryAsync</a>(rateId) -> IEnumerable<Rate></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets every version of a rate.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetRateHistoryAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**rateId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">UploadFeeScheduleAsync</a>(FeeScheduleUploadRequest { ... }) -> IEnumerable<Rate></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Uploads a new fee schedule.\n Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.\n If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will be returned.\n Use the dry run flag to discover already existing rates and to run validations. If validations for any rate fail, no rates will be saved to the system.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.UploadFeeScheduleAsync(
    new FeeScheduleUploadRequest
    {
        DryRun = true,
        Rates = new List<object>()
        {
            new NewRate
            {
                Dimensions = new Dimensions
                {
                    PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    States = new HashSet<State>() { State.Aa },
                    ZipCodes = new HashSet<string>() { "string" },
                    LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                    FacilityTypeCodes = new HashSet<FacilityTypeCode>()
                    {
                        FacilityTypeCode.Pharmacy,
                    },
                    NetworkTypes = new HashSet<Candid.Net.NetworkType>()
                    {
                        Candid.Net.NetworkType.Ppo,
                    },
                    CptCode = "string",
                    Modifiers = new HashSet<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
                },
                Entries = new List<RateEntry>()
                {
                    new RateEntry
                    {
                        StartDate = new DateOnly(2024, 4, 11),
                        RateCents = 33000,
                        IsDeactivated = false,
                    },
                },
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FeeScheduleUploadRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">DeleteRateAsync</a>(rateId, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Soft deletes a rate from the system. Only the most recent version of a rate can be deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.DeleteRateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", 1);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**rateId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `int` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetPayerThresholdsDefaultAsync</a>() -> PayerThreshold</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets the default payer threshold
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetPayerThresholdsDefaultAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetPayerThresholdsAsync</a>(PayerThresholdGetRequest { ... }) -> PayerThresholdsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a list of payers and thresholds by their uuids
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.GetPayerThresholdsAsync(
    new PayerThresholdGetRequest { PayerUuids = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"] }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PayerThresholdGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">SetPayerThresholdAsync</a>(payerUuid, PayerThreshold { ... }) -> PayerThreshold</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets the threshold information for a payer
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.FeeSchedules.V3.SetPayerThresholdAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new PayerThreshold
    {
        UpperThresholdCents = 1,
        LowerThresholdCents = 1,
        DisablePaidIncorrectly = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**payerUuid:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PayerThreshold` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Guarantor V1
<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">CreateAsync</a>(encounterId, GuarantorCreate { ... }) -> Guarantor.V1.Guarantor</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new guarantor and returns the newly created Guarantor object.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Guarantor.V1.CreateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new GuarantorCreate
    {
        PhoneNumbers = new List<PhoneNumber>()
        {
            new PhoneNumber { Number = "1234567890", Type = PhoneNumberType.Home },
        },
        PhoneConsent = true,
        Email = "johndoe@joincandidhealth.com",
        EmailConsent = true,
        FirstName = "string",
        LastName = "string",
        ExternalId = "string",
        DateOfBirth = new DateOnly(2023, 1, 15),
        Address = new StreetAddressShortZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**encounterId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `GuarantorCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">GetAsync</a>(guarantorId) -> Guarantor.V1.Guarantor</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a guarantor by its `guarantor_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Guarantor.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**guarantorId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">UpdateAsync</a>(guarantorId, GuarantorUpdate { ... }) -> Guarantor.V1.Guarantor</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a guarantor by its `guarantor_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Guarantor.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new GuarantorUpdate()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**guarantorId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `GuarantorUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ImportInvoice V1
<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">ImportInvoiceAsync</a>(CreateImportInvoiceRequest { ... }) -> ImportInvoice.V1.ImportInvoice</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Import an existing invoice from a third party service to reflect state in Candid.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ImportInvoice.V1.ImportInvoiceAsync(
    new CreateImportInvoiceRequest
    {
        ExternalPaymentAccountConfigId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PatientExternalId = "string",
        ExternalCustomerIdentifier = "string",
        Note = "string",
        DueDate = new DateOnly(2023, 1, 15),
        Items = new List<InvoiceItemCreate>()
        {
            new InvoiceItemCreate
            {
                Attribution = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                AmountCents = 1,
            },
        },
        Status = Candid.Net.Invoices.V2.InvoiceStatus.Draft,
        ExternalIdentifier = "string",
        CustomerInvoiceUrl = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateImportInvoiceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">GetMultiAsync</a>(SearchImportedInvoicesRequest { ... }) -> ImportInvoicesPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all Invoices for the authenticated user's organziation with all filters applied.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ImportInvoice.V1.GetMultiAsync(
    new SearchImportedInvoicesRequest
    {
        PatientExternalId = "string",
        EncounterExternalId = "string",
        Note = "string",
        DueDateBefore = new DateOnly(2023, 1, 15),
        DueDateAfter = new DateOnly(2023, 1, 15),
        Status = [Candid.Net.Invoices.V2.InvoiceStatus.Draft],
        Limit = 1,
        Sort = InvoiceSortField.CreatedAt,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SearchImportedInvoicesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">GetAsync</a>(invoiceId) -> ImportInvoice.V1.ImportInvoice</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve and view an import invoice
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ImportInvoice.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**invoiceId:** `string` — InvoiceId to be returned
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">UpdateAsync</a>(invoiceId, ImportInvoiceUpdateRequest { ... }) -> ImportInvoice.V1.ImportInvoice</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the information on the imported invoice
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ImportInvoice.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ImportInvoiceUpdateRequest
    {
        CustomerInvoiceUrl = "string",
        Status = Candid.Net.Invoices.V2.InvoiceStatus.Draft,
        Note = "string",
        DueDate = new DateOnly(2023, 1, 15),
        Items = new InvoiceItemInfoUpdate
        {
            UpdateType = InvoiceItemUpdateType.Append,
            Items = new List<InvoiceItemCreate>()
            {
                new InvoiceItemCreate
                {
                    Attribution = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    AmountCents = 1,
                },
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**invoiceId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ImportInvoiceUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## InsuranceAdjudications V1
<details><summary><code>client.InsuranceAdjudications.V1.<a href="/src/Candid.Net/InsuranceAdjudications/V1/V1Client.cs">GetAsync</a>(insuranceAdjudicationId) -> InsuranceAdjudication</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created insurance adjudication by its `insurance_adjudication_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceAdjudications.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insuranceAdjudicationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceAdjudications.V1.<a href="/src/Candid.Net/InsuranceAdjudications/V1/V1Client.cs">CreateAsync</a>(InsuranceAdjudicationCreate { ... }) -> InsuranceAdjudication</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new insurance adjudication record and returns the newly created InsuranceAdjudication object.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceAdjudications.V1.CreateAsync(
    new InsuranceAdjudicationCreate
    {
        PayerIdentifier = new PayerInfo(),
        Payee = new Payee { PayeeName = "string", PayeeIdentifier = "string" },
        PostDate = new DateOnly(2023, 1, 15),
        CheckNumber = "string",
        CheckDate = new DateOnly(2023, 1, 15),
        Note = "string",
        Claims = new Dictionary<string, IEnumerable<ClaimAdjudicationCreate>>()
        {
            {
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                new List<ClaimAdjudicationCreate>()
                {
                    new ClaimAdjudicationCreate
                    {
                        ClaimStatusCode = ClaimStatusCodeCreate.ProcessedAsPrimary,
                        ServiceLines = new Dictionary<
                            string,
                            IEnumerable<ServiceLineAdjudicationCreate>
                        >()
                        { },
                        Carcs = new List<ClaimAdjustmentReasonCode>() { },
                    },
                }
            },
        },
        RemitDraftId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsuranceAdjudicationCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceAdjudications.V1.<a href="/src/Candid.Net/InsuranceAdjudications/V1/V1Client.cs">DeleteAsync</a>(insuranceAdjudicationId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the insurance adjudication record matching the provided insurance_adjudication_id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceAdjudications.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insuranceAdjudicationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## InsurancePayments V1
<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">GetMultiAsync</a>(GetMultiInsurancePaymentRequest { ... }) -> InsurancePaymentsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all non-ERA originated insurance payments satisfying the search criteria
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsurancePayments.V1.GetMultiAsync(
    new GetMultiInsurancePaymentRequest
    {
        Limit = 1,
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sort = InsurancePaymentSortField.AmountCents,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiInsurancePaymentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">GetAsync</a>(insurancePaymentId) -> InsurancePayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created insurance payment by its `insurance_payment_id`.
If the payment does not exist, a `403` will be thrown.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsurancePayments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insurancePaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">CreateAsync</a>(InsurancePaymentCreate { ... }) -> InsurancePayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new insurance payment record and returns the newly created `InsurancePayment` object. This endpoint
should only be used for insurance payments that do not have a corresponding ERA (for example: a settlement check
from a payer). If the payment is an ERA, then you should used the insurance-adjudications API.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsurancePayments.V1.CreateAsync(
    new InsurancePaymentCreate
    {
        PayerIdentifier = new PayerInfo(),
        AmountCents = 1,
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsurancePaymentCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">UpdateAsync</a>(insurancePaymentId, InsurancePaymentUpdate { ... }) -> InsurancePayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the patient payment record matching the provided insurance_payment_id. If updating the payment amount,
then the allocations must be appropriately updated as well.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsurancePayments.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new InsurancePaymentUpdate
    {
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insurancePaymentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `InsurancePaymentUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">DeleteAsync</a>(insurancePaymentId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the insurance payment record matching the provided `insurance_payment_id`.
If the matching record's organization_id does not match the authenticated user's
current organization_id, then a response code of `403` will be returned.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsurancePayments.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insurancePaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## InsuranceRefunds V1
<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">GetMultiAsync</a>(GetMultiInsuranceRefundsRequest { ... }) -> InsuranceRefundsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all insurance refunds satisfying the search criteria AND whose organization_id matches
the current organization_id of the authenticated user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceRefunds.V1.GetMultiAsync(
    new GetMultiInsuranceRefundsRequest
    {
        Limit = 1,
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sort = InsuranceRefundSortField.AmountCents,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiInsuranceRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">GetAsync</a>(insuranceRefundId) -> InsuranceRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created insurance refund by its `insurance_refund_id`.
If the refund does not exist, a `403` will be thrown.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceRefunds.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insuranceRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">CreateAsync</a>(InsuranceRefundCreate { ... }) -> InsuranceRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new insurance refund record and returns the newly created `InsuranceRefund` object.
The allocations can describe whether the refund is being applied toward a specific service line,
claim, or billing provider.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceRefunds.V1.CreateAsync(
    new InsuranceRefundCreate
    {
        PayerIdentifier = new PayerInfo(),
        AmountCents = 1,
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
        RefundReason = RefundReason.Overcharged,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `InsuranceRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">UpdateAsync</a>(insuranceRefundId, InsuranceRefundUpdate { ... }) -> InsuranceRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the patient refund record matching the provided insurance_refund_id. If updating the refund amount,
then the allocations must be appropriately updated as well.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceRefunds.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new InsuranceRefundUpdate
    {
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        RefundReason = RefundReason.Overcharged,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insuranceRefundId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `InsuranceRefundUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">DeleteAsync</a>(insuranceRefundId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the insurance refund record matching the provided `insurance_refund_id`.
If the matching record's organization_id does not match the authenticated user's
current organization_id, then a response code of `403` will be returned.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InsuranceRefunds.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**insuranceRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## MedicationDispense V1
<details><summary><code>client.MedicationDispense.V1.<a href="/src/Candid.Net/MedicationDispense/V1/V1Client.cs">CreateAsync</a>(MedicationDispenseCreate { ... }) -> Encounter</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.MedicationDispense.V1.CreateAsync(
    new MedicationDispenseCreate
    {
        MedicationDispenseExternalId = "string",
        PatientExternalId = "string",
        ProcedureCode = "string",
        Quantity = "string",
        Units = ServiceLineUnits.Mj,
        DateOfService = new DateOnly(2023, 1, 15),
        DrugIdentification = new DrugIdentification
        {
            ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
            NationalDrugCode = "string",
            NationalDrugUnitCount = "string",
            MeasurementUnitCode = MeasurementUnitCode.Milliliters,
            LinkSequenceNumber = "string",
            PharmacyPrescriptionNumber = "string",
            ConversionFormula = "string",
            DrugDescription = "string",
        },
        Description = "string",
        Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MedicationDispenseCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NonInsurancePayerPayments V1
<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">GetMultiAsync</a>(GetMultiNonInsurancePayerPaymentRequest { ... }) -> NonInsurancePayerPaymentsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all non-insurance payer payments
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerPayments.V1.GetMultiAsync(
    new GetMultiNonInsurancePayerPaymentRequest
    {
        Limit = 1,
        NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        CheckNumber = ["string"],
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sort = NonInsurancePayerPaymentSortField.AmountCents,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiNonInsurancePayerPaymentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerPaymentId) -> NonInsurancePayerPayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created non-insurance payer payment by its `non_insurance_payer_payment_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerPayments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerPaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">CreateAsync</a>(NonInsurancePayerPaymentCreate { ... }) -> NonInsurancePayerPayment</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerPayments.V1.CreateAsync(
    new NonInsurancePayerPaymentCreate
    {
        NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        AmountCents = 1,
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
        CheckNumber = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NonInsurancePayerPaymentCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerPaymentId, UpdateNonInsurancePayerPaymentRequest { ... }) -> NonInsurancePayerPayment</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerPayments.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new UpdateNonInsurancePayerPaymentRequest
    {
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerPaymentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `UpdateNonInsurancePayerPaymentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">DeleteAsync</a>(nonInsurancePayerPaymentId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the non-insurance payer payment record matching the provided `non_insurance_payer_payment_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerPayments.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerPaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NonInsurancePayerRefunds V1
<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">GetMultiAsync</a>(GetMultiNonInsurancePayerRefundsRequest { ... }) -> NonInsurancePayerRefundsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all non-insurance payer refunds satisfying the search criteria
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerRefunds.V1.GetMultiAsync(
    new GetMultiNonInsurancePayerRefundsRequest
    {
        Limit = 1,
        NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        CheckNumber = ["string"],
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sort = NonInsurancePayerRefundSortField.AmountCents,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiNonInsurancePayerRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerRefundId) -> NonInsurancePayerRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created non-insurance payer refund by its `non_insurance_payer_refund_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerRefunds.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">CreateAsync</a>(NonInsurancePayerRefundCreate { ... }) -> NonInsurancePayerRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new non-insurance payer refund record and returns the newly created `NonInsurancePayerRefund` object.
The allocations can describe whether the refund is being applied toward a specific service line,
claim, or billing provider.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerRefunds.V1.CreateAsync(
    new NonInsurancePayerRefundCreate
    {
        NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        AmountCents = 1,
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        CheckNumber = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
        RefundReason = RefundReason.Overcharged,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `NonInsurancePayerRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerRefundId, NonInsurancePayerRefundUpdate { ... }) -> NonInsurancePayerRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the non-insurance payer refund record matching the provided non_insurance_payer_refund_id. If updating the refund amount,
then the allocations must be appropriately updated as well.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerRefunds.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new NonInsurancePayerRefundUpdate
    {
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        RefundReason = RefundReason.Overcharged,
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerRefundId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `NonInsurancePayerRefundUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">DeleteAsync</a>(nonInsurancePayerRefundId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the non-insurance payer refund record matching the provided `non_insurance_payer_refund_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayerRefunds.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NonInsurancePayers V1
<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">CreateAsync</a>(CreateNonInsurancePayerRequest { ... }) -> NonInsurancePayer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.CreateAsync(
    new CreateNonInsurancePayerRequest
    {
        Name = "string",
        Description = "string",
        Category = "string",
        Address = new StreetAddressShortZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateNonInsurancePayerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">ToggleEnablementAsync</a>(nonInsurancePayerId, ToggleNonInsurancePayerEnablementRequest { ... }) -> NonInsurancePayer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.ToggleEnablementAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ToggleNonInsurancePayerEnablementRequest { Enabled = true }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ToggleNonInsurancePayerEnablementRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">GetMultiAsync</a>(GetMultiNonInsurancePayersRequest { ... }) -> NonInsurancePayerPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.GetMultiAsync(
    new GetMultiNonInsurancePayersRequest
    {
        Name = "string",
        Category = "string",
        Enabled = true,
        Sort = NonInsurancePayerSortField.Name,
        SortDirection = Candid.Net.SortDirection.Asc,
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiNonInsurancePayersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerId) -> NonInsurancePayer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerId, NonInsurancePayerUpdateRequest { ... }) -> NonInsurancePayer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new NonInsurancePayerUpdateRequest
    {
        Name = "string",
        Description = "no-properties-union",
        Category = "no-properties-union",
        Address = "no-properties-union",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `NonInsurancePayerUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">DeleteAsync</a>(nonInsurancePayerId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**nonInsurancePayerId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## OrganizationServiceFacilities V2
<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">GetAsync</a>(organizationServiceFacilityId) -> OrganizationServiceFacility</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.GetAsync("30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**organizationServiceFacilityId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">GetMultiAsync</a>(GetAllOrganizationServiceFacilitiesRequest { ... }) -> OrganizationServiceFacilityPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.GetMultiAsync(
    new GetAllOrganizationServiceFacilitiesRequest
    {
        Limit = 100,
        Name = "Test Service Facility",
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllOrganizationServiceFacilitiesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">CreateAsync</a>(OrganizationServiceFacilityCreate { ... }) -> OrganizationServiceFacility</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.CreateAsync(
    new OrganizationServiceFacilityCreate
    {
        Name = "Test Service Facility",
        Aliases = new List<string>() { "Test Service Facility Alias" },
        Description = "Test Service Facility Description",
        Status = ServiceFacilityStatus.Active,
        OperationalStatus = ServiceFacilityOperationalStatus.Closed,
        Mode = ServiceFacilityMode.Instance,
        Type = ServiceFacilityType.DiagnosticsOrTherapeuticsUnit,
        PhysicalType = ServiceFacilityPhysicalType.Site,
        Telecoms = new List<string>() { "555-555-5555" },
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrganizationServiceFacilityCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">UpdateAsync</a>(organizationServiceFacilityId, OrganizationServiceFacilityUpdate { ... }) -> OrganizationServiceFacility</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.UpdateAsync(
    "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569",
    new OrganizationServiceFacilityUpdate
    {
        Name = "Test Service Facility",
        Aliases = new List<string>() { "Test Service Facility Alias" },
        Description = "Test Service Facility Description",
        Status = ServiceFacilityStatus.Active,
        OperationalStatus = ServiceFacilityOperationalStatus.Closed,
        Mode = ServiceFacilityMode.Instance,
        Type = ServiceFacilityType.DiagnosticsOrTherapeuticsUnit,
        PhysicalType = ServiceFacilityPhysicalType.Site,
        Telecoms = new List<string>() { "555-555-5555" },
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**organizationServiceFacilityId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OrganizationServiceFacilityUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">DeleteAsync</a>(organizationServiceFacilityId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.DeleteAsync("30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**organizationServiceFacilityId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## OrganizationProviders V3
<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">GetAsync</a>(organizationProviderId) -> OrganizationProviderV2</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationProviders.V3.GetAsync("965A563A-0285-4910-9569-E3739C0F6EAB");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**organizationProviderId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">GetMultiAsync</a>(GetAllOrganizationProvidersRequestV2 { ... }) -> OrganizationProviderPageV2</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationProviders.V3.GetMultiAsync(
    new GetAllOrganizationProvidersRequestV2
    {
        Limit = 100,
        SearchTerm = "john",
        Npi = "1234567890",
        IsRendering = true,
        IsBilling = true,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        Sort = OrganizationProviderSortOptions.ProviderNameAsc,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllOrganizationProvidersRequestV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">CreateAsync</a>(OrganizationProviderCreateV2 { ... }) -> OrganizationProviderV2</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationProviders.V3.CreateAsync(
    new OrganizationProviderCreateV2
    {
        Npi = "string",
        IsRendering = true,
        IsBilling = true,
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
        ProviderType = ProviderType.Individual,
        TaxId = "string",
        TaxonomyCode = "string",
        LicenseType = LicenseType.Md,
        Addresses = new List<OrganizationProviderAddress>()
        {
            new OrganizationProviderAddress
            {
                Address = new StreetAddressLongZip
                {
                    Address1 = "123 Main St",
                    Address2 = "Apt 1",
                    City = "New York",
                    State = State.Ny,
                    ZipCode = "10001",
                    ZipPlusFourCode = "1234",
                },
                AddressType = AddressType.Default,
            },
        },
        EmploymentStartDate = new DateOnly(2023, 1, 15),
        EmploymentTerminationDate = new DateOnly(2023, 1, 15),
        Qualifications = new List<IdentifierCreate>()
        {
            new IdentifierCreate
            {
                Period = new DateRangeOptionalEnd { StartDate = "string" },
                IdentifierCode = IdentifierCode.Mcr,
                IdentifierValue = new MedicareProviderIdentifier(),
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `OrganizationProviderCreateV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">UpdateAsync</a>(organizationProviderId, OrganizationProviderUpdateV2 { ... }) -> OrganizationProviderV2</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationProviders.V3.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new OrganizationProviderUpdateV2
    {
        Npi = "string",
        IsRendering = true,
        IsBilling = true,
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
        ProviderType = ProviderType.Individual,
        TaxId = "string",
        TaxonomyCode = "string",
        LicenseType = LicenseType.Md,
        Addresses = new List<OrganizationProviderAddress>()
        {
            new OrganizationProviderAddress
            {
                Address = new StreetAddressLongZip
                {
                    Address1 = "123 Main St",
                    Address2 = "Apt 1",
                    City = "New York",
                    State = State.Ny,
                    ZipCode = "10001",
                    ZipPlusFourCode = "1234",
                },
                AddressType = AddressType.Default,
            },
        },
        EmploymentStartDate = "string",
        EmploymentTerminationDate = "string",
        Qualifications = new List<object>()
        {
            new IdentifierCreate
            {
                Period = new DateRangeOptionalEnd { StartDate = "string" },
                IdentifierCode = IdentifierCode.Mcr,
                IdentifierValue = new MedicareProviderIdentifier(),
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**organizationProviderId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `OrganizationProviderUpdateV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PatientPayments V4
<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">GetMultiAsync</a>(GetMultiPatientPaymentsRequest { ... }) -> PatientPaymentsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all patient payments satisfying the search criteria AND whose organization_id matches
the current organization_id of the authenticated user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientPayments.V4.GetMultiAsync(
    new GetMultiPatientPaymentsRequest
    {
        Limit = 1,
        PatientExternalId = "string",
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Unattributed = true,
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sources = [PatientTransactionSource.ManualEntry],
        Sort = PatientPaymentSortField.PaymentSource,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiPatientPaymentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">GetAsync</a>(patientPaymentId) -> PatientPayments.V4.PatientPayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created patient payment by its `patient_payment_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientPayments.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientPaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">CreateAsync</a>(PatientPaymentCreate { ... }) -> PatientPayments.V4.PatientPayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new patient payment record and returns the newly created PatientPayment object.
The allocations can describe whether the payment is being applied toward a specific service line,
claim, or billing provider.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientPayments.V4.CreateAsync(
    new PatientPaymentCreate
    {
        AmountCents = 1,
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
        PatientExternalId = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
        Invoice = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientPaymentCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">UpdateAsync</a>(patientPaymentId, PatientPaymentUpdate { ... }) -> PatientPayments.V4.PatientPayment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the patient payment record matching the provided patient_payment_id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientPayments.V4.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new PatientPaymentUpdate
    {
        PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        PaymentNote = "string",
        Invoice = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientPaymentId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatientPaymentUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">DeleteAsync</a>(patientPaymentId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the patient payment record matching the provided patient_payment_id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientPayments.V4.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientPaymentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PatientRefunds V1
<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">GetMultiAsync</a>(GetMultiPatientRefundsRequest { ... }) -> PatientRefundsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all patient refunds satisfying the search criteria AND whose organization_id matches
the current organization_id of the authenticated user.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientRefunds.V1.GetMultiAsync(
    new GetMultiPatientRefundsRequest
    {
        Limit = 1,
        PatientExternalId = "string",
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Unattributed = true,
        InvoiceId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sources = [PatientTransactionSource.ManualEntry],
        Sort = PatientRefundSortField.RefundSource,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiPatientRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">GetAsync</a>(patientRefundId) -> PatientRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created patient refund by its `patient_refund_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientRefunds.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">CreateAsync</a>(PatientRefundCreate { ... }) -> PatientRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new patient refund record and returns the newly created PatientRefund object.
The allocations can describe whether the refund is being applied toward a specific service line,
claim, or billing provider.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientRefunds.V1.CreateAsync(
    new PatientRefundCreate
    {
        AmountCents = 1,
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        PatientExternalId = "string",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
        },
        Invoice = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        RefundReason = RefundReason.Overcharged,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">UpdateAsync</a>(patientRefundId, PatientRefundUpdate { ... }) -> PatientRefund</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the patient refund record matching the provided patient_refund_id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientRefunds.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new PatientRefundUpdate
    {
        RefundTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        RefundNote = "string",
        Invoice = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        RefundReason = RefundReason.Overcharged,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientRefundId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `PatientRefundUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">DeleteAsync</a>(patientRefundId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the patient refund record matching the provided patient_refund_id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PatientRefunds.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**patientRefundId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Payers V3
<details><summary><code>client.Payers.V3.<a href="/src/Candid.Net/Payers/V3/V3Client.cs">GetAsync</a>(payerUuid) -> Payer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payers.V3.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**payerUuid:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Payers.V3.<a href="/src/Candid.Net/Payers/V3/V3Client.cs">GetAllAsync</a>(GetAllPayersRequest { ... }) -> PayerPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payers.V3.GetAllAsync(
    new GetAllPayersRequest
    {
        Limit = 100,
        SearchTerm = "john",
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllPayersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ServiceLines V2
<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">CreateAsync</a>(ServiceLineCreateStandalone { ... }) -> ServiceLine</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceLines.V2.CreateAsync(
    new ServiceLineCreateStandalone
    {
        Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
        ChargeAmountCents = 1,
        DiagnosisIdZero = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdOne = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdTwo = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdThree = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DenialReason = new ServiceLineDenialReason
        {
            Reason = DenialReasonContent.AuthorizationRequired,
        },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        ProcedureCode = "string",
        Quantity = "string",
        Units = ServiceLineUnits.Mj,
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Description = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        EndDateOfService = new DateOnly(2023, 1, 15),
        DrugIdentification = new DrugIdentification
        {
            ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
            NationalDrugCode = "string",
            NationalDrugUnitCount = "string",
            MeasurementUnitCode = MeasurementUnitCode.Milliliters,
            LinkSequenceNumber = "string",
            PharmacyPrescriptionNumber = "string",
            ConversionFormula = "string",
            DrugDescription = "string",
        },
        OrderingProvider = new OrderingProvider
        {
            Npi = "string",
            TaxonomyCode = "string",
            Address = new StreetAddressLongZip
            {
                Address1 = "123 Main St",
                Address2 = "Apt 1",
                City = "New York",
                State = State.Ny,
                ZipCode = "10001",
                ZipPlusFourCode = "1234",
            },
        },
        TestResults = new List<TestResult>()
        {
            new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ServiceLineCreateStandalone` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">UpdateAsync</a>(serviceLineId, ServiceLineUpdate { ... }) -> ServiceLine</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceLines.V2.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ServiceLineUpdate
    {
        EditReason = "string",
        Modifiers = new List<ProcedureModifier>() { ProcedureModifier.TwentyTwo },
        ChargeAmountCents = 1,
        DiagnosisIdZero = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdOne = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdTwo = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DiagnosisIdThree = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DrugIdentification = new DrugIdentification
        {
            ServiceIdQualifier = ServiceIdQualifier.EanUcc13,
            NationalDrugCode = "string",
            NationalDrugUnitCount = "string",
            MeasurementUnitCode = MeasurementUnitCode.Milliliters,
            LinkSequenceNumber = "string",
            PharmacyPrescriptionNumber = "string",
            ConversionFormula = "string",
            DrugDescription = "string",
        },
        DenialReason = new ServiceLineDenialReason
        {
            Reason = DenialReasonContent.AuthorizationRequired,
        },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        Units = ServiceLineUnits.Mj,
        ProcedureCode = "string",
        Quantity = "string",
        Description = "string",
        DateOfService = new DateOnly(2023, 1, 15),
        EndDateOfService = new DateOnly(2023, 1, 15),
        TestResults = new List<TestResult>()
        {
            new TestResult { Value = 1.1, ResultType = TestResultType.Hematocrit },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ServiceLineUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">DeleteAsync</a>(serviceLineId)</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceLines.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceLineId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tasks V3
<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetActionsAsync</a>(taskId) -> TaskActions</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.GetActionsAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**taskId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetMultiAsync</a>(GetAllTasksRequest { ... }) -> TaskPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.GetMultiAsync(
    new GetAllTasksRequest
    {
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        Status = TaskStatus.Finished,
        TaskType = TaskType.CustomerDataRequest,
        Categories = "string",
        UpdatedSince = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        SearchTerm = "string",
        AssignedToId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        DateOfServiceMin = new DateOnly(2023, 1, 15),
        DateOfServiceMax = new DateOnly(2023, 1, 15),
        BillingProviderNpi = "string",
        Sort = TaskSortOptions.UpdatedAtAsc,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllTasksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetAsync</a>(taskId) -> Task</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**taskId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">CreateAsync</a>(TaskCreateV3 { ... }) -> Task</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.CreateAsync(
    new TaskCreateV3
    {
        EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        TaskType = TaskType.CustomerDataRequest,
        Description = "string",
        BlocksClaimSubmission = true,
        AssigneeUserId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Category = TaskCategory.Other,
        WorkQueueId = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TaskCreateV3` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">UpdateAsync</a>(taskId, TaskUpdateV3 { ... }) -> Task</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new TaskUpdateV3
    {
        Status = TaskStatus.Finished,
        AssigneeUserId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BlocksClaimSubmission = true,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**taskId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `TaskUpdateV3` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## WriteOffs V1
<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">GetMultiAsync</a>(GetMultiWriteOffsRequest { ... }) -> WriteOffsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all write-offs satisfying the search criteria.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.WriteOffs.V1.GetMultiAsync(
    new GetMultiWriteOffsRequest
    {
        Limit = 1,
        PatientExternalId = "string",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Sort = WriteOffSortField.AmountCents,
        SortDirection = Candid.Net.SortDirection.Asc,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        AccountTypes = [AccountType.Patient],
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMultiWriteOffsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">GetAsync</a>(writeOffId) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieves a previously created write off by its `write_off_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.WriteOffs.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**writeOffId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">CreateAsync</a>(CreateWriteOffsRequest { ... }) -> CreateWriteOffsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates one or many write-offs applied toward a specific service line,
claim, or billing provider.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.WriteOffs.V1.CreateAsync(
    new CreateWriteOffsRequest
    {
        WriteOffs = new List<object>()
        {
            new PatientWriteOffCreate
            {
                WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                WriteOffNote = "string",
                WriteOffReason = PatientWriteOffReason.SmallBalance,
                ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                AmountCents = 1,
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateWriteOffsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">RevertAsync</a>(writeOffId) -> object</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reverts a write off given a `write_off_id`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.WriteOffs.V1.RevertAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**writeOffId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Appointments V1
<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">CreateAsync</a>(MutableAppointment { ... }) -> Appointment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an appointment. VersionConflictError is returned when the placer_appointment_id is already in use.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.CreateAsync(
    new MutableAppointment
    {
        PatientId = "string",
        StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Status = AppointmentStatus.Pending,
        ServiceDuration = 1,
        Services = new List<Service>()
        {
            new Service
            {
                UniversalServiceIdentifier = UniversalServiceIdentifier.MdVisit,
                StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            },
        },
        PlacerAppointmentId = "string",
        AttendingDoctor = new ExternalProvider
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            Type = ExternalProviderType.Primary,
            Npi = "string",
            Telecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            },
            Addresses = new List<Address>() { },
            Period = new Period(),
            CanonicalId = "string",
        },
        EstimatedCopayCents = 1,
        EstimatedPatientResponsibilityCents = 1,
        PatientDepositCents = 1,
        CheckedInTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Notes = "string",
        LocationResourceId = "string",
        AutomatedEligibilityCheckComplete = true,
        WorkQueue = AppointmentWorkQueue.EmergentIssue,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MutableAppointment` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">GetAsync</a>(id) -> Appointment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets an appointment.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.GetAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<Appointment></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets an appointment along with it's full history. The return list is ordered by version ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.GetHistoryAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">UpdateAsync</a>(id, version, MutableAppointment { ... }) -> Appointment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an appointment. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.UpdateAsync(
    "string",
    "string",
    new MutableAppointment
    {
        PatientId = "string",
        StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Status = AppointmentStatus.Pending,
        ServiceDuration = 1,
        Services = new List<Service>()
        {
            new Service
            {
                UniversalServiceIdentifier = UniversalServiceIdentifier.MdVisit,
                StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            },
        },
        PlacerAppointmentId = "string",
        AttendingDoctor = new ExternalProvider
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            Type = ExternalProviderType.Primary,
            Npi = "string",
            Telecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            },
            Addresses = new List<Address>() { },
            Period = new Period(),
            CanonicalId = "string",
        },
        EstimatedCopayCents = 1,
        EstimatedPatientResponsibilityCents = 1,
        PatientDepositCents = 1,
        CheckedInTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Notes = "string",
        LocationResourceId = "string",
        AutomatedEligibilityCheckComplete = true,
        WorkQueue = AppointmentWorkQueue.EmergentIssue,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MutableAppointment` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">ScanAsync</a>(AppointmentScanRequest { ... }) -> IEnumerable<Appointment></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 appointment updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.ScanAsync(
    new AppointmentScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AppointmentScanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">DeactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets an appointment as deactivated. The path must contain the most recent version to prevent race conditions. Deactivating historic versions is not supported. Subsequent updates via PUT to the appointment will "reactivate" the appointment and set the deactivated flag to false.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Appointments.V1.DeactivateAsync("string", "string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Coverages V1
<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">CreateAsync</a>(MutableCoverage { ... }) -> Coverage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new Coverage. A Coverage provides the high-level identifiers and descriptors of a specific insurance plan for a specific individual - typically the information you can find on an insurance card. Additionally a coverage will include detailed benefits information covered by the specific plan for the individual.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.CreateAsync(
    new MutableCoverage
    {
        Status = CoverageStatus.Active,
        Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            DateOfBirth = new DateOnly(2023, 1, 15),
            BiologicalSex = Sex.Female,
            Address = new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
        },
        Relationship = Relationship.Self,
        Patient = "string",
        InsurancePlan = new InsurancePlan
        {
            MemberId = "string",
            PayerId = "string",
            PayerName = "string",
            AdditionalPayerInformation = new AdditionalPayerInformation
            {
                AvailityEligibilityId = "string",
                AvailityPayerId = "string",
                AvailityPayerName = "string",
                AvailityRemittancePayerId = "string",
            },
            GroupNumber = "string",
            Name = "string",
            PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
            Type = Candid.Net.PreEncounter.Coverages.V1.InsuranceTypeCode.C01,
            Period = new Period(),
            InsuranceCardImageLocator = "string",
        },
        Verified = true,
        EligibilityChecks = new List<EligibilityCheckMetadata>()
        {
            new EligibilityCheckMetadata
            {
                CheckId = "string",
                ServiceCode = ServiceTypeCode.MedicalCare,
                Status = EligibilityCheckStatus.Created,
                InitiatedBy = "string",
                InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            },
        },
        LatestEligibilityCheck = new LatestEligibilityCheck
        {
            CheckId = "string",
            Status = EligibilityStatus.Active,
            InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        },
        Benefits = new CoverageBenefits(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MutableCoverage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">UpdateAsync</a>(id, version, MutableCoverage { ... }) -> Coverage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a Coverage. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    "string",
    new MutableCoverage
    {
        Status = CoverageStatus.Active,
        Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            DateOfBirth = new DateOnly(2023, 1, 15),
            BiologicalSex = Sex.Female,
            Address = new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
        },
        Relationship = Relationship.Self,
        Patient = "string",
        InsurancePlan = new InsurancePlan
        {
            MemberId = "string",
            PayerId = "string",
            PayerName = "string",
            AdditionalPayerInformation = new AdditionalPayerInformation
            {
                AvailityEligibilityId = "string",
                AvailityPayerId = "string",
                AvailityPayerName = "string",
                AvailityRemittancePayerId = "string",
            },
            GroupNumber = "string",
            Name = "string",
            PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
            Type = Candid.Net.PreEncounter.Coverages.V1.InsuranceTypeCode.C01,
            Period = new Period(),
            InsuranceCardImageLocator = "string",
        },
        Verified = true,
        EligibilityChecks = new List<EligibilityCheckMetadata>()
        {
            new EligibilityCheckMetadata
            {
                CheckId = "string",
                ServiceCode = ServiceTypeCode.MedicalCare,
                Status = EligibilityCheckStatus.Created,
                InitiatedBy = "string",
                InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            },
        },
        LatestEligibilityCheck = new LatestEligibilityCheck
        {
            CheckId = "string",
            Status = EligibilityStatus.Active,
            InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        },
        Benefits = new CoverageBenefits(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MutableCoverage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetAsync</a>(id) -> Coverage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

gets a specific Coverage
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<Coverage></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a coverage along with it's full history. The return list is ordered by version ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.GetHistoryAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetMultiAsync</a>(CoverageGetMultiRequest { ... }) -> IEnumerable<Coverage></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of Coverages based on the search criteria.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.GetMultiAsync(
    new CoverageGetMultiRequest { PatientId = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CoverageGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">ScanAsync</a>(CoverageScanRequest { ... }) -> IEnumerable<Coverage></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 coverage updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.ScanAsync(
    new CoverageScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CoverageScanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">CheckEligibilityAsync</a>(id, CheckEligibilityRequest { ... }) -> EligibilityCheckMetadata</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Initiates an eligibility check. Returns the metadata of the check if successfully initiated.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.CheckEligibilityAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new CheckEligibilityRequest
    {
        ServiceCode = ServiceTypeCode.MedicalCare,
        DateOfService = new DateOnly(2023, 1, 15),
        Npi = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `CheckEligibilityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetEligibilityAsync</a>(id, checkId) -> CoverageEligibilityCheckResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets the eligibility of a patient for a specific coverage if successful.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Coverages.V1.GetEligibilityAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    "string"
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**checkId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Lists V1
<details><summary><code>client.PreEncounter.Lists.V1.<a href="/src/Candid.Net/PreEncounter/Lists/V1/V1Client.cs">GetPatientListAsync</a>(PatientListRequest { ... }) -> PatientListPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets patients with dependent objects for patients that match the query parameters.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Lists.V1.GetPatientListAsync(
    new PatientListRequest
    {
        PageToken = "string",
        Limit = 1,
        SortField = "string",
        SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
        Filters = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Lists.V1.<a href="/src/Candid.Net/PreEncounter/Lists/V1/V1Client.cs">GetAppointmentListAsync</a>(AppointmentsGetListRequest { ... }) -> AppointmentListPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for appointments that match the query parameters.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Lists.V1.GetAppointmentListAsync(
    new AppointmentsGetListRequest
    {
        SortField = "string",
        SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
        Limit = 1,
        PageToken = "string",
        Filters = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AppointmentsGetListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Notes V1
<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">GetAsync</a>(id) -> Note</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a note by NoteId.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Notes.V1.GetAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">CreateAsync</a>(MutableNote { ... }) -> Note</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a new note.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Notes.V1.CreateAsync(
    new MutableNote
    {
        Value = "string",
        AuthorEmail = "string",
        AuthorName = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MutableNote` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">UpdateAsync</a>(id, version, MutableNote { ... }) -> Note</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a note. The path must contain the most recent version to prevent races.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Notes.V1.UpdateAsync(
    "string",
    "string",
    new MutableNote
    {
        Value = "string",
        AuthorEmail = "string",
        AuthorName = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MutableNote` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">DeactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets a note as deactivated. The path must contain the most recent version to prevent races.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Notes.V1.DeactivateAsync("string", "string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Patients V1
<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">CreateAsync</a>(CreatePatientRequest { ... }) -> PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a patient. VersionConflictError is returned when the patient's external ID is already in use.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.CreateAsync(
    new CreatePatientRequest
    {
        SkipDuplicateCheck = true,
        Body = new MutablePatient
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            OtherNames = new List<HumanName>()
            {
                new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
            },
            Gender = Candid.Net.PreEncounter.Gender.Man,
            BirthDate = new DateOnly(2023, 1, 15),
            SocialSecurityNumber = "string",
            BiologicalSex = Sex.Female,
            SexualOrientation = SexualOrientation.Heterosexual,
            Race = Race.AmericanIndianOrAlaskaNative,
            Ethnicity = Ethnicity.HispanicOrLatino,
            DisabilityStatus = DisabilityStatus.Disabled,
            MaritalStatus = MaritalStatus.Annulled,
            Deceased = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            MultipleBirth = 1,
            PrimaryAddress = new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
            OtherAddresses = new List<Address>()
            {
                new Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "string" },
                    City = "string",
                    State = "string",
                    PostalCode = "string",
                    Country = "string",
                    Period = new Period(),
                },
            },
            PrimaryTelecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            OtherTelecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            },
            Email = "string",
            ElectronicCommunicationOptIn = true,
            Photo = "string",
            Language = "string",
            ExternalProvenance = new ExternalProvenance
            {
                ExternalId = "string",
                SystemName = "string",
            },
            Contacts = new List<Contact>()
            {
                new Contact
                {
                    Relationship = new List<Relationship>() { Relationship.Self },
                    Name = new HumanName
                    {
                        Family = "string",
                        Given = new List<string>() { "string" },
                        Use = NameUse.Usual,
                        Period = new Period(),
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Address>()
                    {
                        new Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "string" },
                            City = "string",
                            State = "string",
                            PostalCode = "string",
                            Country = "string",
                            Period = new Period(),
                        },
                    },
                    Period = new Period(),
                    HipaaAuthorization = true,
                },
            },
            GeneralPractitioners = new List<ExternalProvider>()
            {
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "string",
                        Given = new List<string>() { "string" },
                        Use = NameUse.Usual,
                        Period = new Period(),
                    },
                    Type = ExternalProviderType.Primary,
                    Npi = "string",
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Address>() { },
                    Period = new Period(),
                    CanonicalId = "string",
                },
            },
            FilingOrder = new FilingOrder
            {
                Coverages = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
            },
            NonInsurancePayers = new List<string>() { "string" },
            NonInsurancePayerAssociations = new List<CanonicalNonInsurancePayerAssociation>()
            {
                new CanonicalNonInsurancePayerAssociation { Id = "string" },
            },
            Guarantor = new Candid.Net.PreEncounter.Patients.V1.Guarantor
            {
                Name = new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
                Telecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                Email = "string",
                BirthDate = new DateOnly(2023, 1, 15),
                Address = new Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "string" },
                    City = "string",
                    State = "string",
                    PostalCode = "string",
                    Country = "string",
                    Period = new Period(),
                },
            },
            SelfPay = true,
            Authorizations = new List<Authorization>()
            {
                new Authorization
                {
                    PayerId = "string",
                    PayerName = "string",
                    AuthorizationNumber = "string",
                    CptCode = "string",
                    Units = AuthorizationUnit.Visit,
                },
            },
            Referrals = new List<Referral>()
            {
                new Referral
                {
                    Provider = new ExternalProvider
                    {
                        Name = new HumanName
                        {
                            Family = "string",
                            Given = new List<string>() { "string" },
                            Use = NameUse.Usual,
                            Period = new Period(),
                        },
                        Type = ExternalProviderType.Primary,
                        Npi = "string",
                        Telecoms = new List<ContactPoint>()
                        {
                            new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                        },
                        Addresses = new List<Address>() { },
                        Period = new Period(),
                        CanonicalId = "string",
                    },
                    ReferralNumber = "string",
                },
            },
            PrimaryServiceFacilityId = "string",
            DoNotInvoiceReason = DoNotInvoiceReason.Bankruptcy,
            NoteIds = new List<string>() { "string" },
            TagIds = new List<string>() { "string" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreatePatientRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">CreateWithMrnAsync</a>(CreatePatientWithMrnRequest { ... }) -> PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a patient and hydrates their MRN with a pre-existing MRN. Once this patient is created their MRN will not be editable. BadRequestError is returned when the MRN is greater than 20 characters. VersionConflictError is returned when the patient's external ID is already in use.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.CreateWithMrnAsync(
    new CreatePatientWithMrnRequest
    {
        SkipDuplicateCheck = true,
        Body = new MutablePatientWithMrn
        {
            Mrn = "string",
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            OtherNames = new List<HumanName>()
            {
                new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
            },
            Gender = Candid.Net.PreEncounter.Gender.Man,
            BirthDate = new DateOnly(2023, 1, 15),
            SocialSecurityNumber = "string",
            BiologicalSex = Sex.Female,
            SexualOrientation = SexualOrientation.Heterosexual,
            Race = Race.AmericanIndianOrAlaskaNative,
            Ethnicity = Ethnicity.HispanicOrLatino,
            DisabilityStatus = DisabilityStatus.Disabled,
            MaritalStatus = MaritalStatus.Annulled,
            Deceased = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            MultipleBirth = 1,
            PrimaryAddress = new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
            OtherAddresses = new List<Address>()
            {
                new Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "string" },
                    City = "string",
                    State = "string",
                    PostalCode = "string",
                    Country = "string",
                    Period = new Period(),
                },
            },
            PrimaryTelecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            OtherTelecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            },
            Email = "string",
            ElectronicCommunicationOptIn = true,
            Photo = "string",
            Language = "string",
            ExternalProvenance = new ExternalProvenance
            {
                ExternalId = "string",
                SystemName = "string",
            },
            Contacts = new List<Contact>()
            {
                new Contact
                {
                    Relationship = new List<Relationship>() { Relationship.Self },
                    Name = new HumanName
                    {
                        Family = "string",
                        Given = new List<string>() { "string" },
                        Use = NameUse.Usual,
                        Period = new Period(),
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Address>()
                    {
                        new Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "string" },
                            City = "string",
                            State = "string",
                            PostalCode = "string",
                            Country = "string",
                            Period = new Period(),
                        },
                    },
                    Period = new Period(),
                    HipaaAuthorization = true,
                },
            },
            GeneralPractitioners = new List<ExternalProvider>()
            {
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "string",
                        Given = new List<string>() { "string" },
                        Use = NameUse.Usual,
                        Period = new Period(),
                    },
                    Type = ExternalProviderType.Primary,
                    Npi = "string",
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Address>() { },
                    Period = new Period(),
                    CanonicalId = "string",
                },
            },
            FilingOrder = new FilingOrder
            {
                Coverages = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
            },
            NonInsurancePayers = new List<string>() { "string" },
            NonInsurancePayerAssociations = new List<CanonicalNonInsurancePayerAssociation>()
            {
                new CanonicalNonInsurancePayerAssociation { Id = "string" },
            },
            Guarantor = new Candid.Net.PreEncounter.Patients.V1.Guarantor
            {
                Name = new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
                Telecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                Email = "string",
                BirthDate = new DateOnly(2023, 1, 15),
                Address = new Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "string" },
                    City = "string",
                    State = "string",
                    PostalCode = "string",
                    Country = "string",
                    Period = new Period(),
                },
            },
            SelfPay = true,
            Authorizations = new List<Authorization>()
            {
                new Authorization
                {
                    PayerId = "string",
                    PayerName = "string",
                    AuthorizationNumber = "string",
                    CptCode = "string",
                    Units = AuthorizationUnit.Visit,
                },
            },
            Referrals = new List<Referral>()
            {
                new Referral
                {
                    Provider = new ExternalProvider
                    {
                        Name = new HumanName
                        {
                            Family = "string",
                            Given = new List<string>() { "string" },
                            Use = NameUse.Usual,
                            Period = new Period(),
                        },
                        Type = ExternalProviderType.Primary,
                        Npi = "string",
                        Telecoms = new List<ContactPoint>()
                        {
                            new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                        },
                        Addresses = new List<Address>() { },
                        Period = new Period(),
                        CanonicalId = "string",
                    },
                    ReferralNumber = "string",
                },
            },
            PrimaryServiceFacilityId = "string",
            DoNotInvoiceReason = DoNotInvoiceReason.Bankruptcy,
            NoteIds = new List<string>() { "string" },
            TagIds = new List<string>() { "string" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreatePatientWithMrnRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetMultiAsync</a>(PatientsSearchRequestPaginated { ... }) -> PatientPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for patients that match the query parameters.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.GetMultiAsync(
    new PatientsSearchRequestPaginated
    {
        Limit = 1,
        Mrn = "string",
        PageToken = "string",
        SortField = "string",
        SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientsSearchRequestPaginated` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetAsync</a>(id) -> PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a patient.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.GetAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<PreEncounter.Patients.V1.Patient></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a patient along with it's full history. The return list is ordered by version ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.GetHistoryAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">UpdateAsync</a>(id, version, MutablePatient { ... }) -> PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a patient. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.UpdateAsync(
    "string",
    "string",
    new MutablePatient
    {
        Name = new HumanName
        {
            Family = "string",
            Given = new List<string>() { "string" },
            Use = NameUse.Usual,
            Period = new Period(),
        },
        OtherNames = new List<HumanName>()
        {
            new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
        },
        Gender = Candid.Net.PreEncounter.Gender.Man,
        BirthDate = new DateOnly(2023, 1, 15),
        SocialSecurityNumber = "string",
        BiologicalSex = Sex.Female,
        SexualOrientation = SexualOrientation.Heterosexual,
        Race = Race.AmericanIndianOrAlaskaNative,
        Ethnicity = Ethnicity.HispanicOrLatino,
        DisabilityStatus = DisabilityStatus.Disabled,
        MaritalStatus = MaritalStatus.Annulled,
        Deceased = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        MultipleBirth = 1,
        PrimaryAddress = new Address
        {
            Use = AddressUse.Home,
            Line = new List<string>() { "string" },
            City = "string",
            State = "string",
            PostalCode = "string",
            Country = "string",
            Period = new Period(),
        },
        OtherAddresses = new List<Address>()
        {
            new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
        },
        PrimaryTelecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
        OtherTelecoms = new List<ContactPoint>()
        {
            new ContactPoint { Value = "string", Use = ContactPointUse.Home },
        },
        Email = "string",
        ElectronicCommunicationOptIn = true,
        Photo = "string",
        Language = "string",
        ExternalProvenance = new ExternalProvenance
        {
            ExternalId = "string",
            SystemName = "string",
        },
        Contacts = new List<Contact>()
        {
            new Contact
            {
                Relationship = new List<Relationship>() { Relationship.Self },
                Name = new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                },
                Addresses = new List<Address>()
                {
                    new Address
                    {
                        Use = AddressUse.Home,
                        Line = new List<string>() { "string" },
                        City = "string",
                        State = "string",
                        PostalCode = "string",
                        Country = "string",
                        Period = new Period(),
                    },
                },
                Period = new Period(),
                HipaaAuthorization = true,
            },
        },
        GeneralPractitioners = new List<ExternalProvider>()
        {
            new ExternalProvider
            {
                Name = new HumanName
                {
                    Family = "string",
                    Given = new List<string>() { "string" },
                    Use = NameUse.Usual,
                    Period = new Period(),
                },
                Type = ExternalProviderType.Primary,
                Npi = "string",
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                },
                Addresses = new List<Address>() { },
                Period = new Period(),
                CanonicalId = "string",
            },
        },
        FilingOrder = new FilingOrder
        {
            Coverages = new List<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        },
        NonInsurancePayers = new List<string>() { "string" },
        NonInsurancePayerAssociations = new List<CanonicalNonInsurancePayerAssociation>()
        {
            new CanonicalNonInsurancePayerAssociation { Id = "string" },
        },
        Guarantor = new Candid.Net.PreEncounter.Patients.V1.Guarantor
        {
            Name = new HumanName
            {
                Family = "string",
                Given = new List<string>() { "string" },
                Use = NameUse.Usual,
                Period = new Period(),
            },
            Telecom = new ContactPoint { Value = "string", Use = ContactPointUse.Home },
            Email = "string",
            BirthDate = new DateOnly(2023, 1, 15),
            Address = new Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "string" },
                City = "string",
                State = "string",
                PostalCode = "string",
                Country = "string",
                Period = new Period(),
            },
        },
        SelfPay = true,
        Authorizations = new List<Authorization>()
        {
            new Authorization
            {
                PayerId = "string",
                PayerName = "string",
                AuthorizationNumber = "string",
                CptCode = "string",
                Units = AuthorizationUnit.Visit,
            },
        },
        Referrals = new List<Referral>()
        {
            new Referral
            {
                Provider = new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "string",
                        Given = new List<string>() { "string" },
                        Use = NameUse.Usual,
                        Period = new Period(),
                    },
                    Type = ExternalProviderType.Primary,
                    Npi = "string",
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "string", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Address>() { },
                    Period = new Period(),
                    CanonicalId = "string",
                },
                ReferralNumber = "string",
            },
        },
        PrimaryServiceFacilityId = "string",
        DoNotInvoiceReason = DoNotInvoiceReason.Bankruptcy,
        NoteIds = new List<string>() { "string" },
        TagIds = new List<string>() { "string" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MutablePatient` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">DeactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets a patient as deactivated. The path must contain the most recent version to prevent race conditions. Deactivating historic versions is not supported. Subsequent updates via PUT to the patient will "reactivate" the patient and set the deactivated flag to false.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.DeactivateAsync("string", "string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">SearchAsync</a>(PatientGetMultiRequest { ... }) -> IEnumerable<PreEncounter.Patients.V1.Patient></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a list of Patients based on the search criteria.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.SearchAsync(
    new PatientGetMultiRequest { Mrn = "string", SimilarNameOrdering = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">ScanAsync</a>(PatientScanRequest { ... }) -> IEnumerable<PreEncounter.Patients.V1.Patient></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Patients.V1.ScanAsync(
    new PatientScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PatientScanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Tags V1
<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">GetAsync</a>(id) -> PreEncounter.Tags.V1.Tag</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a tag by TagId.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Tags.V1.GetAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">GetAllAsync</a>(GetAllTagsRequest { ... }) -> TagPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets all tags. Defaults to page size of 1000.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Tags.V1.GetAllAsync(
    new GetAllTagsRequest { Limit = 1, PageToken = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetAllTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">CreateAsync</a>(MutableTag { ... }) -> PreEncounter.Tags.V1.Tag</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a new tag if it does not already exist, otherwise, returns the existing tag.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Tags.V1.CreateAsync(new MutableTag { Value = "string" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `MutableTag` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">UpdateAsync</a>(id, version, MutableTag { ... }) -> PreEncounter.Tags.V1.Tag</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a tag. The path must contain the most recent version to prevent races.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Tags.V1.UpdateAsync(
    "string",
    "string",
    new MutableTag { Value = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `MutableTag` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">DeactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets a tag as deactivated. The path must contain the most recent version to prevent races.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.PreEncounter.Tags.V1.DeactivateAsync("string", "string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**version:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Diagnoses
<details><summary><code>client.Diagnoses.<a href="/src/Candid.Net/Diagnoses/DiagnosesClient.cs">CreateAsync</a>(StandaloneDiagnosisCreate { ... }) -> Diagnosis</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Creates a new diagnosis for an encounter
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Diagnoses.CreateAsync(
    new StandaloneDiagnosisCreate
    {
        EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Name = "string",
        CodeType = DiagnosisTypeCode.Abf,
        Code = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `StandaloneDiagnosisCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Diagnoses.<a href="/src/Candid.Net/Diagnoses/DiagnosesClient.cs">UpdateAsync</a>(diagnosisId, DiagnosisUpdate { ... }) -> Diagnosis</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates the diagnosis record matching the provided `diagnosis_id`
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Diagnoses.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new DiagnosisUpdate
    {
        Name = "string",
        CodeType = DiagnosisTypeCode.Abf,
        Code = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**diagnosisId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `DiagnosisUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Diagnoses.<a href="/src/Candid.Net/Diagnoses/DiagnosesClient.cs">DeleteAsync</a>(diagnosisId)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Deletes the diagnosis record associated with the provided `diagnosis_id`
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Diagnoses.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**diagnosisId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ServiceFacility
<details><summary><code>client.ServiceFacility.<a href="/src/Candid.Net/ServiceFacility/ServiceFacilityClient.cs">UpdateAsync</a>(serviceFacilityId, EncounterServiceFacilityUpdate { ... }) -> EncounterServiceFacility</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceFacility.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new EncounterServiceFacilityUpdate
    {
        OrganizationName = "Test Organization",
        Address = new StreetAddressLongZip
        {
            Address1 = "123 Main St",
            Address2 = "Apt 1",
            City = "New York",
            State = State.Ny,
            ZipCode = "10001",
            ZipPlusFourCode = "1234",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**serviceFacilityId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `EncounterServiceFacilityUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
