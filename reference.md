# Reference
## Auth Default
<details><summary><code>client.Auth.Default.<a href="/src/Candid.Net/Auth/Default/DefaultClient.cs">GetTokenAsync</a>(Candid.Net.Auth.Default.AuthGetTokenRequest { ... }) -> Candid.Net.Auth.Default.AuthGetTokenResponse</code></summary>
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
subsequent API requests via the `/auth/v2/token` endpoint defined below, which requires you to provide your `client_id` and `client_secret`. Your `client_id` and `client_secret` can be [generated](https://support.joincandidhealth.com/hc/en-us/articles/23065219476244--Generating-Candid-API-Keys) from the "Users & Credentials" tab by your org admin.

The `/auth/v2/token` endpoint accepts both `Content-Type: application/json` and `Content-Type: application/x-www-form-urlencoded`. The request body should contain the `client_id` and `client_secret` as follows:

```json
{
  "client_id": "YOUR_CLIENT_ID",
  "client_secret": "YOUR_CLIENT_SECRET"
}
```
or as URL-encoded form data:

```
client_id=YOUR_CLIENT_ID&client_secret=YOUR_CLIENT_SECRET
```

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
await client.Auth.Default.GetTokenAsync(
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

**request:** `Candid.Net.Auth.Default.AuthGetTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## BillingNotes V2
<details><summary><code>client.BillingNotes.V2.<a href="/src/Candid.Net/BillingNotes/V2/V2Client.cs">CreateAsync</a>(Candid.Net.BillingNotes.V2.StandaloneBillingNoteCreate { ... }) -> Candid.Net.BillingNotes.V2.BillingNote</code></summary>
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
        Text = "text",
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

**request:** `Candid.Net.BillingNotes.V2.StandaloneBillingNoteCreate` 
    
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

<details><summary><code>client.BillingNotes.V2.<a href="/src/Candid.Net/BillingNotes/V2/V2Client.cs">UpdateAsync</a>(billingNoteId, Candid.Net.BillingNotes.V2.BillingNoteUpdate { ... }) -> Candid.Net.BillingNotes.V2.BillingNote</code></summary>
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
    new BillingNoteUpdate { Text = "text" }
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

**request:** `Candid.Net.BillingNotes.V2.BillingNoteUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ChargeCaptureBundles V1
<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">GetAsync</a>(chargeCaptureClaimCreationId) -> Candid.Net.ChargeCaptureBundles.V1.ChargeCaptureClaimCreation</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**chargeCaptureClaimCreationId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">GetSummaryAsync</a>() -> Candid.Net.ChargeCaptureBundles.V1.ChargeCaptureClaimCreationSummary</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.GetSummaryAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">ResolveChargeCreationErrorAsync</a>(chargeCaptureBundleErrorId, Candid.Net.ChargeCaptureBundles.V1.ChargeCaptureBundleErrorResolution { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.ResolveChargeCreationErrorAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new ChargeCaptureBundleErrorResolution()
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

**chargeCaptureBundleErrorId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Candid.Net.ChargeCaptureBundles.V1.ChargeCaptureBundleErrorResolution` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">GetAllAsync</a>(Candid.Net.ChargeCaptureBundles.V1.GetAllChargeCaptureClaimCreationsRequest { ... }) -> Candid.Net.ChargeCaptureBundles.V1.ChargeCaptureClaimCreationPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.GetAllAsync(new GetAllChargeCaptureClaimCreationsRequest());
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

**request:** `Candid.Net.ChargeCaptureBundles.V1.GetAllChargeCaptureClaimCreationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ChargeCapture V1
<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">CreateAsync</a>(Candid.Net.ChargeCapture.V1.CreateChargeCaptureRequest { ... }) -> Candid.Net.ChargeCapture.V1.ChargeCapture</code></summary>
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
        Data = new ChargeCaptureData(),
        ChargeExternalId = "charge_external_id",
        PatientExternalId = "patient_external_id",
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

**request:** `Candid.Net.ChargeCapture.V1.CreateChargeCaptureRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">CreateFromPreEncounterPatientAsync</a>(Candid.Net.ChargeCapture.V1.CreateChargeCaptureFromPreEncounterRequest { ... }) -> Candid.Net.ChargeCapture.V1.ChargeCapture</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a Charge Capture from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
of the pre-encounter service should use the standard create endpoint.

At encounter creation time, information from the provided patient and appointment objects will be populated
where applicable. In particular, the following fields are populated from the patient and appointment objects:
  - Patient
  - Referring Provider
  - Subscriber Primary
  - Subscriber Secondary
  - Referral Number
  - Responsible Party
  - Guarantor

Note that these fields should not be populated in the ChargeCaptureData property of this endpoint, as they will be overwritten at encounter creation time.

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
await client.ChargeCapture.V1.CreateFromPreEncounterPatientAsync(
    new CreateChargeCaptureFromPreEncounterRequest
    {
        Data = new ChargeCaptureData(),
        ChargeExternalId = "charge_external_id",
        PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PreEncounterAppointmentIds = new List<string>()
        {
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        },
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

**request:** `Candid.Net.ChargeCapture.V1.CreateChargeCaptureFromPreEncounterRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">UpdateAsync</a>(chargeCaptureId, Candid.Net.ChargeCapture.V1.ChargeCaptureUpdate { ... }) -> Candid.Net.ChargeCapture.V1.ChargeCapture</code></summary>
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
    new ChargeCaptureUpdate()
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

**request:** `Candid.Net.ChargeCapture.V1.ChargeCaptureUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">GetAsync</a>(chargeCaptureId) -> Candid.Net.ChargeCapture.V1.ChargeCapture</code></summary>
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

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">GetAllAsync</a>(Candid.Net.ChargeCapture.V1.GetAllChargeCapturesRequest { ... }) -> Candid.Net.ChargeCapture.V1.ChargeCapturePage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.GetAllAsync(new GetAllChargeCapturesRequest());
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

**request:** `Candid.Net.ChargeCapture.V1.GetAllChargeCapturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCapture.V1.<a href="/src/Candid.Net/ChargeCapture/V1/V1Client.cs">UpdatePostBilledChangesAsync</a>(Candid.Net.ChargeCapture.V1.ChargeCapturePostBilledChangeUpdate { ... }) -> IEnumerable<Candid.Net.ChargeCapture.V1.ChargeCapturePostBilledChange></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCapture.V1.UpdatePostBilledChangesAsync(
    new ChargeCapturePostBilledChangeUpdate
    {
        ChargeCaptureChangeIds = new List<string>()
        {
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        },
        Resolved = true,
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

**request:** `Candid.Net.ChargeCapture.V1.ChargeCapturePostBilledChangeUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Contracts V2
<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">GetAsync</a>(contractId) -> Candid.Net.Contracts.V2.ContractWithProviders</code></summary>
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

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">GetMultiAsync</a>(Candid.Net.Contracts.V2.GetMultiContractsRequest { ... }) -> Candid.Net.Contracts.V2.ContractsPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.GetMultiAsync(new GetMultiContractsRequest());
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

**request:** `Candid.Net.Contracts.V2.GetMultiContractsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">CreateAsync</a>(Candid.Net.Contracts.V2.ContractCreate { ... }) -> Candid.Net.Contracts.V2.ContractWithProviders</code></summary>
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
        EffectiveDate = "effective_date",
        Regions = new Regions(
            new Regions.States(
                new RegionStates
                {
                    States = new List<State>() { State.Aa, State.Aa },
                }
            )
        ),
        CommercialInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
        MedicareInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
        MedicaidInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
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

**request:** `Candid.Net.Contracts.V2.ContractCreate` 
    
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

<details><summary><code>client.Contracts.V2.<a href="/src/Candid.Net/Contracts/V2/V2Client.cs">UpdateAsync</a>(contractId, Candid.Net.Contracts.V2.ContractUpdate { ... }) -> Candid.Net.Contracts.V2.ContractWithProviders</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Contracts.V2.UpdateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", new ContractUpdate());
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

**request:** `Candid.Net.Contracts.V2.ContractUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Credentialing V2
<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">CreateFacilityAsync</a>(Candid.Net.Credentialing.V2.FacilityCredentialingSpanCreate { ... }) -> Candid.Net.Credentialing.V2.FacilityCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.CreateFacilityAsync(
    new FacilityCredentialingSpanCreate
    {
        ServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.Credentialing.V2.FacilityCredentialingSpanCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetFacilityAsync</a>(facilityCredentialingId) -> Candid.Net.Credentialing.V2.FacilityCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.GetFacilityAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**facilityCredentialingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetAllFacilitiesAsync</a>(Candid.Net.Credentialing.V2.GetAllFacilityCredentialingSpansRequest { ... }) -> Candid.Net.Credentialing.V2.FacilityCredentialingSpanPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.GetAllFacilitiesAsync(new GetAllFacilityCredentialingSpansRequest());
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

**request:** `Candid.Net.Credentialing.V2.GetAllFacilityCredentialingSpansRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">DeleteFacilityAsync</a>(facilityCredentialingId)</code></summary>
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
await client.Credentialing.V2.DeleteFacilityAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**facilityCredentialingId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">UpdateFacilityAsync</a>(facilityCredentialingId, Candid.Net.Credentialing.V2.FacilityCredentialingSpanUpdate { ... }) -> Candid.Net.Credentialing.V2.FacilityCredentialingSpan</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.UpdateFacilityAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new FacilityCredentialingSpanUpdate
    {
        ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**facilityCredentialingId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Candid.Net.Credentialing.V2.FacilityCredentialingSpanUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">CreateAsync</a>(Candid.Net.Credentialing.V2.ProviderCredentialingSpanCreate { ... }) -> Candid.Net.Credentialing.V2.ProviderCredentialingSpan</code></summary>
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
        Regions = new Regions(
            new Regions.States(
                new RegionStates
                {
                    States = new List<State>() { State.Aa, State.Aa },
                }
            )
        ),
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

**request:** `Candid.Net.Credentialing.V2.ProviderCredentialingSpanCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetAsync</a>(providerCredentialingId) -> Candid.Net.Credentialing.V2.ProviderCredentialingSpan</code></summary>
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

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">GetAllAsync</a>(Candid.Net.Credentialing.V2.GetAllProviderCredentialingSpansRequest { ... }) -> Candid.Net.Credentialing.V2.ProviderCredentialingSpanPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Credentialing.V2.GetAllAsync(new GetAllProviderCredentialingSpansRequest());
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

**request:** `Candid.Net.Credentialing.V2.GetAllProviderCredentialingSpansRequest` 
    
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

<details><summary><code>client.Credentialing.V2.<a href="/src/Candid.Net/Credentialing/V2/V2Client.cs">UpdateAsync</a>(providerCredentialingId, Candid.Net.Credentialing.V2.ProviderCredentialingSpanUpdate { ... }) -> Candid.Net.Credentialing.V2.ProviderCredentialingSpan</code></summary>
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
    new ProviderCredentialingSpanUpdate()
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

**request:** `Candid.Net.Credentialing.V2.ProviderCredentialingSpanUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## CustomSchemas V1
<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">GetMultiAsync</a>() -> Candid.Net.CustomSchemas.V1.SchemaGetMultiResponse</code></summary>
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

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">GetAsync</a>(schemaId) -> Candid.Net.CustomSchemas.V1.Schema</code></summary>
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

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">CreateAsync</a>(Candid.Net.CustomSchemas.V1.SchemaCreate { ... }) -> Candid.Net.CustomSchemas.V1.Schema</code></summary>
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

**request:** `Candid.Net.CustomSchemas.V1.SchemaCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.CustomSchemas.V1.<a href="/src/Candid.Net/CustomSchemas/V1/V1Client.cs">UpdateAsync</a>(schemaId, Candid.Net.CustomSchemas.V1.SchemaUpdate { ... }) -> Candid.Net.CustomSchemas.V1.Schema</code></summary>
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

**request:** `Candid.Net.CustomSchemas.V1.SchemaUpdate` 
    
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

<Tip>Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.</Tip>

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

<Tip>Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.</Tip>

**Availity has transitioned their GET endpoint to a POST endpoint. Candid has updated their pass-through integration to enable backwards compatibility for the GET endpoint so that customers do not have to immediately update their integrations.**

**Candid recommends integrations with the [POST endpoint](https://docs.joincandidhealth.com/api-reference/eligibility/v-2/submit-eligibility-check-availity-post) to ensure the best possible integration experience. Given the transition, Availity’s documentation will be out of sync with this endpoint.**

If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint

This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:

- [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
- [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)

A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)
* Note Availity requires a free developer account to access this documentation.

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

<Tip>Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.</Tip>

If you'd like access to this endpoint, please reach out to support@joincandidhealth.com with the subject line "Action: Activate Availity Eligibility API Endpoint

This API is a wrapper around Availity's coverages API. Below are some helpful documentation links:

- [Availity - Coverages 1.0.0 API](https://developer.availity.com/partner/documentation#c_coverages_references)
- [Candid Availity Eligibility Integration Guide](https://support.joincandidhealth.com/hc/en-us/articles/24218441631892--Availity-Eligibility-Integration-Guide)

A schema of the response object can be found here: [Availity Docs](https://developer.availity.com/partner/product/191210/api/190898#/Coverages_100/operation/%2Fcoverages%2F{id}/get)
* Note Availity requires a free developer account to access this documentation.

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

## EncounterAttachments V1
<details><summary><code>client.EncounterAttachments.V1.<a href="/src/Candid.Net/EncounterAttachments/V1/V1Client.cs">GetAsync</a>(encounterId) -> IEnumerable<Candid.Net.EncounterAttachments.V1.EncounterAttachment></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterAttachments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

<details><summary><code>client.EncounterAttachments.V1.<a href="/src/Candid.Net/EncounterAttachments/V1/V1Client.cs">DeleteAsync</a>(encounterId, Candid.Net.EncounterAttachments.V1.DeleteAttachmentRequest { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.EncounterAttachments.V1.DeleteAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new DeleteAttachmentRequest { AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" }
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

**request:** `Candid.Net.EncounterAttachments.V1.DeleteAttachmentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## EncounterProviders V2
<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateReferringProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.ReferringProviderUpdate { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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

**request:** `Candid.Net.EncounterProviders.V2.ReferringProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateInitialReferringProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.InitialReferringProviderUpdate { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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

**request:** `Candid.Net.EncounterProviders.V2.InitialReferringProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateSupervisingProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.SupervisingProviderUpdate { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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

**request:** `Candid.Net.EncounterProviders.V2.SupervisingProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">UpdateOrderingProviderAsync</a>(serviceLineId, Candid.Net.EncounterProviders.V2.OrderingProviderUpdate { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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
    new OrderingProviderUpdate()
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

**request:** `Candid.Net.EncounterProviders.V2.OrderingProviderUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateReferringProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.ReferringProvider { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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
    new ReferringProvider { Npi = "npi" }
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

**request:** `Candid.Net.EncounterProviders.V2.ReferringProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateInitialReferringProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.InitialReferringProvider { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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
    new InitialReferringProvider { Npi = "npi" }
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

**request:** `Candid.Net.EncounterProviders.V2.InitialReferringProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateSupervisingProviderAsync</a>(encounterId, Candid.Net.EncounterProviders.V2.SupervisingProvider { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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
    new SupervisingProvider { Npi = "npi" }
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

**request:** `Candid.Net.EncounterProviders.V2.SupervisingProvider` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.EncounterProviders.V2.<a href="/src/Candid.Net/EncounterProviders/V2/V2Client.cs">CreateOrderingProviderAsync</a>(serviceLineId, Candid.Net.EncounterProviders.V2.OrderingProvider { ... }) -> Candid.Net.EncounterProviders.V2.EncounterProvider</code></summary>
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
    new OrderingProvider { Npi = "npi" }
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

**request:** `Candid.Net.EncounterProviders.V2.OrderingProvider` 
    
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
<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">GetAllAsync</a>(Candid.Net.Encounters.V4.GetAllEncountersRequest { ... }) -> Candid.Net.Encounters.V4.EncounterPage</code></summary>
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

**request:** `Candid.Net.Encounters.V4.GetAllEncountersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">GetAsync</a>(encounterId) -> Candid.Net.Encounters.V4.Encounter</code></summary>
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

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateAsync</a>(Candid.Net.Encounters.V4.EncounterCreate { ... }) -> Candid.Net.Encounters.V4.Encounter</code></summary>
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
        BillingProvider = new BillingProvider
        {
            Address = new StreetAddressLongZip
            {
                ZipPlusFourCode = "zip_plus_four_code",
                Address1 = "address1",
                City = "city",
                State = State.Aa,
                ZipCode = "zip_code",
            },
            TaxId = "tax_id",
            Npi = "npi",
        },
        Diagnoses = new List<DiagnosisCreate>()
        {
            new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
            new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
        },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        RenderingProvider = new RenderingProvider { Npi = "npi" },
        Patient = new PatientCreate
        {
            ExternalId = "external_id",
            DateOfBirth = new DateOnly(2023, 1, 15),
            Address = new StreetAddressShortZip
            {
                Address1 = "address1",
                City = "city",
                State = State.Aa,
                ZipCode = "zip_code",
            },
            FirstName = "first_name",
            LastName = "last_name",
            Gender = Candid.Net.Individual.Gender.Male,
        },
        ResponsibleParty = ResponsiblePartyType.InsurancePay,
        ExternalId = "external_id",
        PatientAuthorizedRelease = true,
        BenefitsAssignedToProvider = true,
        ProviderAcceptsAssignment = true,
        BillableStatus = BillableStatusType.Billable,
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

**request:** `Candid.Net.Encounters.V4.EncounterCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateFromPreEncounterPatientAsync</a>(Candid.Net.Encounters.V4.EncounterCreateFromPreEncounter { ... }) -> Candid.Net.Encounters.V4.Encounter</code></summary>
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
        RenderingProvider = new RenderingProvider { Npi = "npi" },
        PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
        Diagnoses = new List<DiagnosisCreate>()
        {
            new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
            new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
        },
        PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PreEncounterAppointmentIds = new List<string>()
        {
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        },
        BillingProvider = new BillingProvider
        {
            Address = new StreetAddressLongZip
            {
                ZipPlusFourCode = "zip_plus_four_code",
                Address1 = "address1",
                City = "city",
                State = State.Aa,
                ZipCode = "zip_code",
            },
            TaxId = "tax_id",
            Npi = "npi",
        },
        ExternalId = "external_id",
        PatientAuthorizedRelease = true,
        BenefitsAssignedToProvider = true,
        ProviderAcceptsAssignment = true,
        BillableStatus = BillableStatusType.Billable,
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

**request:** `Candid.Net.Encounters.V4.EncounterCreateFromPreEncounter` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">UpdateAsync</a>(encounterId, Candid.Net.Encounters.V4.EncounterUpdate { ... }) -> Candid.Net.Encounters.V4.Encounter</code></summary>
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
    new EncounterUpdate()
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

**request:** `Candid.Net.Encounters.V4.EncounterUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExpectedNetworkStatus V1
<details><summary><code>client.ExpectedNetworkStatus.V1.<a href="/src/Candid.Net/ExpectedNetworkStatus/V1/V1Client.cs">ComputeAsync</a>(Candid.Net.ExpectedNetworkStatus.V1.ExpectedNetworkStatusRequest { ... }) -> Candid.Net.ExpectedNetworkStatus.V1.ExpectedNetworkStatusResponse</code></summary>
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
        SubscriberPayerId = "subscriber_payer_id",
        SubscriberPayerName = "subscriber_payer_name",
        BillingProviderNpi = "billing_provider_npi",
        BillingProviderTin = "billing_provider_tin",
        RenderingProviderNpi = "rendering_provider_npi",
        ContractedState = State.Aa,
        DateOfService = "date_of_service",
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

**request:** `Candid.Net.ExpectedNetworkStatus.V1.ExpectedNetworkStatusRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExpectedNetworkStatus V2
<details><summary><code>client.ExpectedNetworkStatus.V2.<a href="/src/Candid.Net/ExpectedNetworkStatus/V2/V2Client.cs">ComputeForRenderingProviderAsync</a>(renderingProviderId, Candid.Net.ExpectedNetworkStatus.V2.ExpectedNetworkStatusRequestV2 { ... }) -> Candid.Net.ExpectedNetworkStatus.V2.ExpectedNetworkStatusResponseV2</code></summary>
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
            MemberId = "member_id",
            InsuranceType = new InsuranceType
            {
                LineOfBusiness = LineOfBusiness.Medicare,
                InsuranceTypeCodes = new InsuranceTypeCodes(
                    new Candid.Net.ExpectedNetworkStatus.V2.InsuranceTypeCodes.InsuranceTypeCode(
                        Candid.Net.Commons.InsuranceTypeCode.C01
                    )
                ),
            },
        },
        PatientAddress = new StreetAddressShortZip
        {
            Address1 = "address1",
            City = "city",
            State = State.Aa,
            ZipCode = "zip_code",
        },
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.ExpectedNetworkStatus.V2.ExpectedNetworkStatusRequestV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ExpectedNetworkStatus.V2.<a href="/src/Candid.Net/ExpectedNetworkStatus/V2/V2Client.cs">ComputeAllInNetworkProvidersAsync</a>(Candid.Net.ExpectedNetworkStatus.V2.ComputeAllInNetworkProvidersRequest { ... }) -> Candid.Net.ExpectedNetworkStatus.V2.ComputeAllInNetworkProvidersResponse</code></summary>
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
            MemberId = "member_id",
            InsuranceType = new InsuranceType
            {
                LineOfBusiness = LineOfBusiness.Medicare,
                InsuranceTypeCodes = new InsuranceTypeCodes(
                    new Candid.Net.ExpectedNetworkStatus.V2.InsuranceTypeCodes.InsuranceTypeCode(
                        Candid.Net.Commons.InsuranceTypeCode.C01
                    )
                ),
            },
        },
        PatientAddress = new StreetAddressShortZip
        {
            Address1 = "address1",
            City = "city",
            State = State.Aa,
            ZipCode = "zip_code",
        },
        BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        OrganizationServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.ExpectedNetworkStatus.V2.ComputeAllInNetworkProvidersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Exports V3
<details><summary><code>client.Exports.V3.<a href="/src/Candid.Net/Exports/V3/V3Client.cs">GetExportsAsync</a>(Candid.Net.Exports.V3.GetExportsRequest { ... }) -> Candid.Net.Exports.V3.GetExportsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

<Warning>
API-based exports are in the process of being deprecated in favor of Candid Data Share and are not being offered to new customers.
Please see the [Candid Data Share docs](https://docs.joincandidhealth.com/introduction/candid-data-share) for more information.
</Warning>

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

**request:** `Candid.Net.Exports.V3.GetExportsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ExternalPaymentAccountConfig V1
<details><summary><code>client.ExternalPaymentAccountConfig.V1.<a href="/src/Candid.Net/ExternalPaymentAccountConfig/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.ExternalPaymentAccountConfig.V1.GetExternalPaymentAccountConfigsRequest { ... }) -> Candid.Net.ExternalPaymentAccountConfig.V1.ExternalPaymentAccountConfigPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ExternalPaymentAccountConfig.V1.GetMultiAsync(
    new GetExternalPaymentAccountConfigsRequest()
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

**request:** `Candid.Net.ExternalPaymentAccountConfig.V1.GetExternalPaymentAccountConfigsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## FeeSchedules V3
<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetMatchAsync</a>(serviceLineId) -> Candid.Net.FeeSchedules.V3.MatchResult?</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets the rate that matches a service line.  No result means no rate exists matching the service line's dimensions.
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

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">TestMatchAsync</a>(serviceLineId, rateId) -> Candid.Net.FeeSchedules.V3.MatchTestResult</code></summary>
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

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetMultiAsync</a>(Candid.Net.FeeSchedules.V3.GetMultiRequest { ... }) -> Candid.Net.FeeSchedules.V3.RatesPage</code></summary>
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
await client.FeeSchedules.V3.GetMultiAsync(new GetMultiRequest());
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

**request:** `Candid.Net.FeeSchedules.V3.GetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetUniqueValuesForDimensionAsync</a>(Candid.Net.FeeSchedules.V3.GetUniqueDimensionValuesRequest { ... }) -> Candid.Net.FeeSchedules.V3.DimensionsPage</code></summary>
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
    new GetUniqueDimensionValuesRequest { PivotDimension = DimensionName.PayerUuid }
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

**request:** `Candid.Net.FeeSchedules.V3.GetUniqueDimensionValuesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetRateHistoryAsync</a>(rateId) -> IEnumerable<Candid.Net.FeeSchedules.V3.Rate></code></summary>
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

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">UploadFeeScheduleAsync</a>(Candid.Net.FeeSchedules.V3.FeeScheduleUploadRequest { ... }) -> IEnumerable<Candid.Net.FeeSchedules.V3.Rate></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Uploads a new fee schedule.\n Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.\n If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will be returned.\n Use the dry run flag to discover already existing rates and to run validations.  If validations for any rate fail, no rates will be saved to the system.
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
        Rates = new List<RateUpload>()
        {
            new RateUpload(
                new RateUpload.NewRate(
                    new NewRate
                    {
                        Dimensions = new Dimensions
                        {
                            PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            States = new HashSet<State>() { State.Aa },
                            ZipCodes = new HashSet<string>() { "zip_codes" },
                            LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                            FacilityTypeCodes = new HashSet<FacilityTypeCode>()
                            {
                                FacilityTypeCode.Pharmacy,
                            },
                            NetworkTypes = new HashSet<Candid.Net.Commons.NetworkType>()
                            {
                                Candid.Net.Commons.NetworkType.Ppo,
                            },
                            PayerPlanGroupIds = new HashSet<string>()
                            {
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            },
                            CptCode = "cpt_code",
                            Modifiers = new HashSet<ProcedureModifier>() { ProcedureModifier.Av },
                        },
                        Entries = new List<RateEntry>()
                        {
                            new RateEntry
                            {
                                StartDate = new DateOnly(2023, 1, 15),
                                RateCents = 1,
                                IsDeactivated = true,
                            },
                            new RateEntry
                            {
                                StartDate = new DateOnly(2023, 1, 15),
                                RateCents = 1,
                                IsDeactivated = true,
                            },
                        },
                    }
                )
            ),
            new RateUpload(
                new RateUpload.NewRate(
                    new NewRate
                    {
                        Dimensions = new Dimensions
                        {
                            PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            States = new HashSet<State>() { State.Aa },
                            ZipCodes = new HashSet<string>() { "zip_codes" },
                            LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
                            FacilityTypeCodes = new HashSet<FacilityTypeCode>()
                            {
                                FacilityTypeCode.Pharmacy,
                            },
                            NetworkTypes = new HashSet<Candid.Net.Commons.NetworkType>()
                            {
                                Candid.Net.Commons.NetworkType.Ppo,
                            },
                            PayerPlanGroupIds = new HashSet<string>()
                            {
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                            },
                            CptCode = "cpt_code",
                            Modifiers = new HashSet<ProcedureModifier>() { ProcedureModifier.Av },
                        },
                        Entries = new List<RateEntry>()
                        {
                            new RateEntry
                            {
                                StartDate = new DateOnly(2023, 1, 15),
                                RateCents = 1,
                                IsDeactivated = true,
                            },
                            new RateEntry
                            {
                                StartDate = new DateOnly(2023, 1, 15),
                                RateCents = 1,
                                IsDeactivated = true,
                            },
                        },
                    }
                )
            ),
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

**request:** `Candid.Net.FeeSchedules.V3.FeeScheduleUploadRequest` 
    
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

Soft deletes a rate from the system.  Only the most recent version of a rate can be deleted.
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

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetPayerThresholdsDefaultAsync</a>() -> Candid.Net.FeeSchedules.V3.PayerThreshold</code></summary>
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

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">GetPayerThresholdsAsync</a>(Candid.Net.FeeSchedules.V3.PayerThresholdGetRequest { ... }) -> Candid.Net.FeeSchedules.V3.PayerThresholdsPage</code></summary>
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

**request:** `Candid.Net.FeeSchedules.V3.PayerThresholdGetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">SetPayerThresholdAsync</a>(payerUuid, Candid.Net.FeeSchedules.V3.PayerThreshold { ... }) -> Candid.Net.FeeSchedules.V3.PayerThreshold</code></summary>
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
    new PayerThreshold { DisablePaidIncorrectly = true }
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

**request:** `Candid.Net.FeeSchedules.V3.PayerThreshold` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">HardDeleteRatesAsync</a>(Candid.Net.FeeSchedules.V3.OptionalDimensions { ... }) -> int</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Hard deletes rates from the system that match the provided dimensions.  This is a destructive operation and cannot be undone.  If an empty dimensions object is provided, all rates will be hard deleted.  The maximum number of rates this API will delete at a time is 10000.  Returns the number of rates deleted and if that number is the maximum, the caller should call this API again to continue deleting rates.
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
await client.FeeSchedules.V3.HardDeleteRatesAsync(
    new OptionalDimensions
    {
        States = new HashSet<State>() { State.Aa },
        ZipCodes = new HashSet<string>() { "zip_codes" },
        LicenseTypes = new HashSet<LicenseType>() { LicenseType.Md },
        FacilityTypeCodes = new HashSet<FacilityTypeCode>() { FacilityTypeCode.Pharmacy },
        NetworkTypes = new HashSet<Candid.Net.Commons.NetworkType>()
        {
            Candid.Net.Commons.NetworkType.Ppo,
        },
        PayerPlanGroupIds = new HashSet<string>() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
        Modifiers = new HashSet<ProcedureModifier>() { ProcedureModifier.Av },
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

**request:** `Candid.Net.FeeSchedules.V3.OptionalDimensions` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.FeeSchedules.V3.<a href="/src/Candid.Net/FeeSchedules/V3/V3Client.cs">HardDeleteRatesByIdsAsync</a>(Candid.Net.FeeSchedules.V3.HardDeleteRatesByIdsRequest { ... }) -> int</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Hard deletes specific rates from the system by their IDs. This is a destructive operation and cannot be undone. Limited to 100 rate IDs maximum per request. For bulk deletion of more than 100 rates, use the hard_delete_rates endpoint with dimension filters. Returns the number of rates deleted.
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
await client.FeeSchedules.V3.HardDeleteRatesByIdsAsync(
    new HardDeleteRatesByIdsRequest
    {
        RateIds = new List<string>()
        {
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.FeeSchedules.V3.HardDeleteRatesByIdsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Guarantor V1
<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">CreateAsync</a>(encounterId, Candid.Net.Guarantor.V1.GuarantorCreate { ... }) -> Candid.Net.Guarantor.V1.Guarantor</code></summary>
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
        FirstName = "first_name",
        LastName = "last_name",
        ExternalId = "external_id",
        Address = new StreetAddressShortZip
        {
            Address1 = "address1",
            City = "city",
            State = State.Aa,
            ZipCode = "zip_code",
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

**request:** `Candid.Net.Guarantor.V1.GuarantorCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">GetAsync</a>(guarantorId) -> Candid.Net.Guarantor.V1.Guarantor</code></summary>
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

<details><summary><code>client.Guarantor.V1.<a href="/src/Candid.Net/Guarantor/V1/V1Client.cs">UpdateAsync</a>(guarantorId, Candid.Net.Guarantor.V1.GuarantorUpdate { ... }) -> Candid.Net.Guarantor.V1.Guarantor</code></summary>
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

**request:** `Candid.Net.Guarantor.V1.GuarantorUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## HealthCareCodeInformation V1
<details><summary><code>client.HealthCareCodeInformation.V1.<a href="/src/Candid.Net/HealthCareCodeInformation/V1/V1Client.cs">UpdateAsync</a>(encounterId, Candid.Net.HealthCareCodeInformation.V1.HealthCareCodeInformationUpdate { ... }) -> Candid.Net.HealthCareCodeInformation.V1.HealthCareCodeInformationGetAllResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.HealthCareCodeInformation.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new HealthCareCodeInformationUpdate()
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

**request:** `Candid.Net.HealthCareCodeInformation.V1.HealthCareCodeInformationUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.HealthCareCodeInformation.V1.<a href="/src/Candid.Net/HealthCareCodeInformation/V1/V1Client.cs">GetAllForEncounterAsync</a>(encounterId) -> Candid.Net.HealthCareCodeInformation.V1.HealthCareCodeInformationGetAllResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.HealthCareCodeInformation.V1.GetAllForEncounterAsync(
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

## ImportInvoice V1
<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">ImportInvoiceAsync</a>(Candid.Net.ImportInvoice.V1.CreateImportInvoiceRequest { ... }) -> Candid.Net.ImportInvoice.V1.ImportInvoice</code></summary>
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
        PatientExternalId = "patient_external_id",
        ExternalCustomerIdentifier = "external_customer_identifier",
        Items = new List<InvoiceItemCreate>()
        {
            new InvoiceItemCreate
            {
                Attribution = new InvoiceItemAttributionCreate(
                    new InvoiceItemAttributionCreate.ServiceLineId(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
                AmountCents = 1,
            },
            new InvoiceItemCreate
            {
                Attribution = new InvoiceItemAttributionCreate(
                    new InvoiceItemAttributionCreate.ServiceLineId(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
                AmountCents = 1,
            },
        },
        Status = Candid.Net.Invoices.V2.InvoiceStatus.Draft,
        ExternalIdentifier = "external_identifier",
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

**request:** `Candid.Net.ImportInvoice.V1.CreateImportInvoiceRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.ImportInvoice.V1.SearchImportedInvoicesRequest { ... }) -> Candid.Net.ImportInvoice.V1.ImportInvoicesPage</code></summary>
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
await client.ImportInvoice.V1.GetMultiAsync(new SearchImportedInvoicesRequest());
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

**request:** `Candid.Net.ImportInvoice.V1.SearchImportedInvoicesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">GetAsync</a>(invoiceId) -> Candid.Net.ImportInvoice.V1.ImportInvoice</code></summary>
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

<details><summary><code>client.ImportInvoice.V1.<a href="/src/Candid.Net/ImportInvoice/V1/V1Client.cs">UpdateAsync</a>(invoiceId, Candid.Net.ImportInvoice.V1.ImportInvoiceUpdateRequest { ... }) -> Candid.Net.ImportInvoice.V1.ImportInvoice</code></summary>
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
    new ImportInvoiceUpdateRequest()
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

**request:** `Candid.Net.ImportInvoice.V1.ImportInvoiceUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## InsuranceAdjudications V1
<details><summary><code>client.InsuranceAdjudications.V1.<a href="/src/Candid.Net/InsuranceAdjudications/V1/V1Client.cs">GetAsync</a>(insuranceAdjudicationId) -> Candid.Net.InsuranceAdjudications.V1.InsuranceAdjudication</code></summary>
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

<details><summary><code>client.InsuranceAdjudications.V1.<a href="/src/Candid.Net/InsuranceAdjudications/V1/V1Client.cs">CreateAsync</a>(Candid.Net.InsuranceAdjudications.V1.InsuranceAdjudicationCreate { ... }) -> Candid.Net.InsuranceAdjudications.V1.InsuranceAdjudication</code></summary>
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
        PayerIdentifier = new PayerIdentifier(
            new PayerIdentifier.PayerInfo(
                new PayerInfo { PayerId = "payer_id", PayerName = "payer_name" }
            )
        ),
        Payee = new Payee
        {
            PayeeName = "payee_name",
            PayeeIdentifier = new PayeeIdentifier(new PayeeIdentifier.Npi("payee_identifier")),
        },
        CheckDate = new DateOnly(2023, 1, 15),
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
                        {
                            {
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                new List<ServiceLineAdjudicationCreate>()
                                {
                                    new ServiceLineAdjudicationCreate
                                    {
                                        Carcs = new List<ClaimAdjustmentReasonCode>()
                                        {
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                        },
                                        Rarcs = new List<RemittanceAdviceRemarkCode>()
                                        {
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                        },
                                    },
                                    new ServiceLineAdjudicationCreate
                                    {
                                        Carcs = new List<ClaimAdjustmentReasonCode>()
                                        {
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                        },
                                        Rarcs = new List<RemittanceAdviceRemarkCode>()
                                        {
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                        },
                                    },
                                }
                            },
                        },
                        Carcs = new List<ClaimAdjustmentReasonCode>()
                        {
                            new ClaimAdjustmentReasonCode
                            {
                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                ReasonCode = Carc.Carc1,
                                AmountCents = 1,
                            },
                            new ClaimAdjustmentReasonCode
                            {
                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                ReasonCode = Carc.Carc1,
                                AmountCents = 1,
                            },
                        },
                    },
                    new ClaimAdjudicationCreate
                    {
                        ClaimStatusCode = ClaimStatusCodeCreate.ProcessedAsPrimary,
                        ServiceLines = new Dictionary<
                            string,
                            IEnumerable<ServiceLineAdjudicationCreate>
                        >()
                        {
                            {
                                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                                new List<ServiceLineAdjudicationCreate>()
                                {
                                    new ServiceLineAdjudicationCreate
                                    {
                                        Carcs = new List<ClaimAdjustmentReasonCode>()
                                        {
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                        },
                                        Rarcs = new List<RemittanceAdviceRemarkCode>()
                                        {
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                        },
                                    },
                                    new ServiceLineAdjudicationCreate
                                    {
                                        Carcs = new List<ClaimAdjustmentReasonCode>()
                                        {
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                            new ClaimAdjustmentReasonCode
                                            {
                                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                                ReasonCode = Carc.Carc1,
                                                AmountCents = 1,
                                            },
                                        },
                                        Rarcs = new List<RemittanceAdviceRemarkCode>()
                                        {
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                            new RemittanceAdviceRemarkCode { ReasonCode = Rarc.M1 },
                                        },
                                    },
                                }
                            },
                        },
                        Carcs = new List<ClaimAdjustmentReasonCode>()
                        {
                            new ClaimAdjustmentReasonCode
                            {
                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                ReasonCode = Carc.Carc1,
                                AmountCents = 1,
                            },
                            new ClaimAdjustmentReasonCode
                            {
                                GroupCode = ClaimAdjustmentGroupCodes.Co,
                                ReasonCode = Carc.Carc1,
                                AmountCents = 1,
                            },
                        },
                    },
                }
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

**request:** `Candid.Net.InsuranceAdjudications.V1.InsuranceAdjudicationCreate` 
    
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
<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.InsurancePayments.V1.GetMultiInsurancePaymentRequest { ... }) -> Candid.Net.InsurancePayments.V1.InsurancePaymentsPage</code></summary>
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
await client.InsurancePayments.V1.GetMultiAsync(new GetMultiInsurancePaymentRequest());
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

**request:** `Candid.Net.InsurancePayments.V1.GetMultiInsurancePaymentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsurancePayments.V1.<a href="/src/Candid.Net/InsurancePayments/V1/V1Client.cs">GetAsync</a>(insurancePaymentId) -> Candid.Net.InsurancePayments.V1.InsurancePayment</code></summary>
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

## InsuranceRefunds V1
<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.InsuranceRefunds.V1.GetMultiInsuranceRefundsRequest { ... }) -> Candid.Net.InsuranceRefunds.V1.InsuranceRefundsPage</code></summary>
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
await client.InsuranceRefunds.V1.GetMultiAsync(new GetMultiInsuranceRefundsRequest());
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

**request:** `Candid.Net.InsuranceRefunds.V1.GetMultiInsuranceRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">GetAsync</a>(insuranceRefundId) -> Candid.Net.InsuranceRefunds.V1.InsuranceRefund</code></summary>
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

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">CreateAsync</a>(Candid.Net.InsuranceRefunds.V1.InsuranceRefundCreate { ... }) -> Candid.Net.InsuranceRefunds.V1.InsuranceRefund</code></summary>
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
        PayerIdentifier = new PayerIdentifier(
            new PayerIdentifier.PayerInfo(
                new PayerInfo { PayerId = "payer_id", PayerName = "payer_name" }
            )
        ),
        AmountCents = 1,
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
            },
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
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

**request:** `Candid.Net.InsuranceRefunds.V1.InsuranceRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.InsuranceRefunds.V1.<a href="/src/Candid.Net/InsuranceRefunds/V1/V1Client.cs">UpdateAsync</a>(insuranceRefundId, Candid.Net.InsuranceRefunds.V1.InsuranceRefundUpdate { ... }) -> Candid.Net.InsuranceRefunds.V1.InsuranceRefund</code></summary>
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
    new InsuranceRefundUpdate()
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

**request:** `Candid.Net.InsuranceRefunds.V1.InsuranceRefundUpdate` 
    
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
<details><summary><code>client.MedicationDispense.V1.<a href="/src/Candid.Net/MedicationDispense/V1/V1Client.cs">CreateAsync</a>(Candid.Net.MedicationDispense.V1.MedicationDispenseCreate { ... }) -> Candid.Net.Encounters.V4.Encounter</code></summary>
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
        MedicationDispenseExternalId = "medication_dispense_external_id",
        PatientExternalId = "patient_external_id",
        ProcedureCode = "procedure_code",
        Quantity = "quantity",
        Units = ServiceLineUnits.Mj,
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

**request:** `Candid.Net.MedicationDispense.V1.MedicationDispenseCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NonInsurancePayerPayments V1
<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.NonInsurancePayerPayments.V1.GetMultiNonInsurancePayerPaymentRequest { ... }) -> Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPaymentsPage</code></summary>
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
    new GetMultiNonInsurancePayerPaymentRequest()
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

**request:** `Candid.Net.NonInsurancePayerPayments.V1.GetMultiNonInsurancePayerPaymentRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerPaymentId) -> Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPayment</code></summary>
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

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">CreateAsync</a>(Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPaymentCreate { ... }) -> Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPayment</code></summary>
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
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
            },
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
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

**request:** `Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPaymentCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerPayments.V1.<a href="/src/Candid.Net/NonInsurancePayerPayments/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerPaymentId, Candid.Net.NonInsurancePayerPayments.V1.UpdateNonInsurancePayerPaymentRequest { ... }) -> Candid.Net.NonInsurancePayerPayments.V1.NonInsurancePayerPayment</code></summary>
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
    new UpdateNonInsurancePayerPaymentRequest()
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

**request:** `Candid.Net.NonInsurancePayerPayments.V1.UpdateNonInsurancePayerPaymentRequest` 
    
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
<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.NonInsurancePayerRefunds.V1.GetMultiNonInsurancePayerRefundsRequest { ... }) -> Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefundsPage</code></summary>
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
    new GetMultiNonInsurancePayerRefundsRequest()
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

**request:** `Candid.Net.NonInsurancePayerRefunds.V1.GetMultiNonInsurancePayerRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerRefundId) -> Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefund</code></summary>
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

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">CreateAsync</a>(Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefundCreate { ... }) -> Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefund</code></summary>
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
        AmountCents = 1,
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
            },
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
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

**request:** `Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayerRefunds.V1.<a href="/src/Candid.Net/NonInsurancePayerRefunds/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerRefundId, Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefundUpdate { ... }) -> Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefund</code></summary>
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
    new NonInsurancePayerRefundUpdate()
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

**request:** `Candid.Net.NonInsurancePayerRefunds.V1.NonInsurancePayerRefundUpdate` 
    
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
<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">CreateAsync</a>(Candid.Net.NonInsurancePayers.V1.CreateNonInsurancePayerRequest { ... }) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.CreateAsync(
    new CreateNonInsurancePayerRequest { Name = "name" }
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

**request:** `Candid.Net.NonInsurancePayers.V1.CreateNonInsurancePayerRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">ToggleEnablementAsync</a>(nonInsurancePayerId, Candid.Net.NonInsurancePayers.V1.ToggleNonInsurancePayerEnablementRequest { ... }) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayer</code></summary>
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

**request:** `Candid.Net.NonInsurancePayers.V1.ToggleNonInsurancePayerEnablementRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.NonInsurancePayers.V1.GetMultiNonInsurancePayersRequest { ... }) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayerPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NonInsurancePayers.V1.GetMultiAsync(new GetMultiNonInsurancePayersRequest());
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

**request:** `Candid.Net.NonInsurancePayers.V1.GetMultiNonInsurancePayersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">GetCategoriesAsync</a>(Candid.Net.NonInsurancePayers.V1.GetNonInsurancePayersCategoriesRequest { ... }) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayerCategoriesPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a paginated list of all non-insurance payer categories.

Non-insurance payer categories are simply strings and are not stored as a
separate object in Candid. They are created when added to at least one
non-insurance payer's `category` field and are deleted when there are no
longer any non-insurance payers that contain them.
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
await client.NonInsurancePayers.V1.GetCategoriesAsync(new GetNonInsurancePayersCategoriesRequest());
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

**request:** `Candid.Net.NonInsurancePayers.V1.GetNonInsurancePayersCategoriesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">GetAsync</a>(nonInsurancePayerId) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayer</code></summary>
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

<details><summary><code>client.NonInsurancePayers.V1.<a href="/src/Candid.Net/NonInsurancePayers/V1/V1Client.cs">UpdateAsync</a>(nonInsurancePayerId, Candid.Net.NonInsurancePayers.V1.NonInsurancePayerUpdateRequest { ... }) -> Candid.Net.NonInsurancePayers.V1.NonInsurancePayer</code></summary>
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
    new NonInsurancePayerUpdateRequest()
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

**request:** `Candid.Net.NonInsurancePayers.V1.NonInsurancePayerUpdateRequest` 
    
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

## OrganizationProviders V3
<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">GetAsync</a>(organizationProviderId) -> Candid.Net.OrganizationProviders.V3.OrganizationProviderV2</code></summary>
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

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">GetMultiAsync</a>(Candid.Net.OrganizationProviders.V3.GetAllOrganizationProvidersRequestV2 { ... }) -> Candid.Net.OrganizationProviders.V3.OrganizationProviderPageV2</code></summary>
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

**request:** `Candid.Net.OrganizationProviders.V3.GetAllOrganizationProvidersRequestV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">CreateAsync</a>(Candid.Net.OrganizationProviders.V3.OrganizationProviderCreateV2 { ... }) -> Candid.Net.OrganizationProviders.V3.OrganizationProviderV2</code></summary>
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
        Npi = "npi",
        IsRendering = true,
        IsBilling = true,
        ProviderType = ProviderType.Individual,
        LicenseType = LicenseType.Md,
        Qualifications = new List<IdentifierCreate>()
        {
            new IdentifierCreate
            {
                IdentifierCode = IdentifierCode.Mcr,
                IdentifierValue = new IdentifierValue(
                    new IdentifierValue.MedicareProviderIdentifier(
                        new MedicareProviderIdentifier
                        {
                            State = State.Aa,
                            ProviderNumber = "provider_number",
                        }
                    )
                ),
            },
            new IdentifierCreate
            {
                IdentifierCode = IdentifierCode.Mcr,
                IdentifierValue = new IdentifierValue(
                    new IdentifierValue.MedicareProviderIdentifier(
                        new MedicareProviderIdentifier
                        {
                            State = State.Aa,
                            ProviderNumber = "provider_number",
                        }
                    )
                ),
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

**request:** `Candid.Net.OrganizationProviders.V3.OrganizationProviderCreateV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationProviders.V3.<a href="/src/Candid.Net/OrganizationProviders/V3/V3Client.cs">UpdateAsync</a>(organizationProviderId, Candid.Net.OrganizationProviders.V3.OrganizationProviderUpdateV2 { ... }) -> Candid.Net.OrganizationProviders.V3.OrganizationProviderV2</code></summary>
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
    new OrganizationProviderUpdateV2()
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

**request:** `Candid.Net.OrganizationProviders.V3.OrganizationProviderUpdateV2` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## OrganizationServiceFacilities V2
<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">GetAsync</a>(organizationServiceFacilityId) -> Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacility</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.OrganizationServiceFacilities.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">GetMultiAsync</a>(Candid.Net.OrganizationServiceFacilities.V2.GetAllOrganizationServiceFacilitiesRequest { ... }) -> Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacilityPage</code></summary>
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

**request:** `Candid.Net.OrganizationServiceFacilities.V2.GetAllOrganizationServiceFacilitiesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">GetByExternalIdAsync</a>(externalId) -> Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacility</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Looks up a single organization service facility by its `external_id` field. This can be useful
for finding service facilities within Candid which are associated with service facilities in
an external system.
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
await client.OrganizationServiceFacilities.V2.GetByExternalIdAsync("external_id");
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

**externalId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">CreateAsync</a>(Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacilityCreate { ... }) -> Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacility</code></summary>
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

**request:** `Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacilityCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.OrganizationServiceFacilities.V2.<a href="/src/Candid.Net/OrganizationServiceFacilities/V2/V2Client.cs">UpdateAsync</a>(organizationServiceFacilityId, Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacilityUpdate { ... }) -> Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacility</code></summary>
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

**request:** `Candid.Net.OrganizationServiceFacilities.V2.OrganizationServiceFacilityUpdate` 
    
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

## PatientAr V1
<details><summary><code>client.PatientAr.V1.<a href="/src/Candid.Net/PatientAr/V1/V1Client.cs">ListInventoryAsync</a>(Candid.Net.PatientAr.V1.GetInventoryRecordsRequest { ... }) -> Candid.Net.PatientAr.V1.ListInventoryPagedResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

NOTE: This service is in-development and can only be used by select partners. Please contact Candid Health to request access.

Retrieve a list of inventory records based on the provided filters. Each inventory record provides the latest invoiceable status of the associated claim.
The response is paginated, and the `page_token` can be used to retrieve subsequent pages. Initial requests should not include `page_token`.
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
await client.PatientAr.V1.ListInventoryAsync(new GetInventoryRecordsRequest());
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

**request:** `Candid.Net.PatientAr.V1.GetInventoryRecordsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientAr.V1.<a href="/src/Candid.Net/PatientAr/V1/V1Client.cs">ItemizeAsync</a>(claimId) -> Candid.Net.PatientAr.V1.InvoiceItemizationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

NOTE: This service is in-development and can only be used by select partners. Please contact Candid Health to request access.

Provides detailed itemization of invoice data for a specific claim.
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
await client.PatientAr.V1.ItemizeAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**claimId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PatientPayments V4
<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">GetMultiAsync</a>(Candid.Net.PatientPayments.V4.GetMultiPatientPaymentsRequest { ... }) -> Candid.Net.PatientPayments.V4.PatientPaymentsPage</code></summary>
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
await client.PatientPayments.V4.GetMultiAsync(new GetMultiPatientPaymentsRequest());
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

**request:** `Candid.Net.PatientPayments.V4.GetMultiPatientPaymentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">GetAsync</a>(patientPaymentId) -> Candid.Net.PatientPayments.V4.PatientPayment</code></summary>
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

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">CreateAsync</a>(Candid.Net.PatientPayments.V4.PatientPaymentCreate { ... }) -> Candid.Net.PatientPayments.V4.PatientPayment</code></summary>
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
        PatientExternalId = "patient_external_id",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
            },
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
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

**request:** `Candid.Net.PatientPayments.V4.PatientPaymentCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientPayments.V4.<a href="/src/Candid.Net/PatientPayments/V4/V4Client.cs">UpdateAsync</a>(patientPaymentId, Candid.Net.PatientPayments.V4.PatientPaymentUpdate { ... }) -> Candid.Net.PatientPayments.V4.PatientPayment</code></summary>
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
    new PatientPaymentUpdate()
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

**request:** `Candid.Net.PatientPayments.V4.PatientPaymentUpdate` 
    
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
<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.PatientRefunds.V1.GetMultiPatientRefundsRequest { ... }) -> Candid.Net.PatientRefunds.V1.PatientRefundsPage</code></summary>
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
await client.PatientRefunds.V1.GetMultiAsync(new GetMultiPatientRefundsRequest());
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

**request:** `Candid.Net.PatientRefunds.V1.GetMultiPatientRefundsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">GetAsync</a>(patientRefundId) -> Candid.Net.PatientRefunds.V1.PatientRefund</code></summary>
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

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PatientRefunds.V1.PatientRefundCreate { ... }) -> Candid.Net.PatientRefunds.V1.PatientRefund</code></summary>
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
        PatientExternalId = "patient_external_id",
        Allocations = new List<AllocationCreate>()
        {
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
            },
            new AllocationCreate
            {
                AmountCents = 1,
                Target = new AllocationTargetCreate(
                    new AllocationTargetCreate.ServiceLineById(
                        "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
                    )
                ),
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

**request:** `Candid.Net.PatientRefunds.V1.PatientRefundCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PatientRefunds.V1.<a href="/src/Candid.Net/PatientRefunds/V1/V1Client.cs">UpdateAsync</a>(patientRefundId, Candid.Net.PatientRefunds.V1.PatientRefundUpdate { ... }) -> Candid.Net.PatientRefunds.V1.PatientRefund</code></summary>
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
    new PatientRefundUpdate()
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

**request:** `Candid.Net.PatientRefunds.V1.PatientRefundUpdate` 
    
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

## PayerPlanGroups V1
<details><summary><code>client.PayerPlanGroups.V1.<a href="/src/Candid.Net/PayerPlanGroups/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.PayerPlanGroups.V1.PayerPlanGroupGetMultiRequest { ... }) -> Candid.Net.PayerPlanGroups.V1.PayerPlanGroupPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns all payer plan groups matching filter criteria.
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
await client.PayerPlanGroups.V1.GetMultiAsync(new PayerPlanGroupGetMultiRequest());
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

**request:** `Candid.Net.PayerPlanGroups.V1.PayerPlanGroupGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PayerPlanGroups.V1.<a href="/src/Candid.Net/PayerPlanGroups/V1/V1Client.cs">GetAsync</a>(payerPlanGroupId) -> Candid.Net.PayerPlanGroups.V1.PayerPlanGroup</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Return a plan group with a given ID.
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
await client.PayerPlanGroups.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**payerPlanGroupId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PayerPlanGroups.V1.<a href="/src/Candid.Net/PayerPlanGroups/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PayerPlanGroups.V1.MutablePayerPlanGroup { ... }) -> Candid.Net.PayerPlanGroups.V1.PayerPlanGroup</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a payer plan group
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
await client.PayerPlanGroups.V1.CreateAsync(
    new MutablePayerPlanGroup
    {
        PlanGroupName = "plan_group_name",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PlanType = SourceOfPaymentCode.SelfPay,
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

**request:** `Candid.Net.PayerPlanGroups.V1.MutablePayerPlanGroup` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PayerPlanGroups.V1.<a href="/src/Candid.Net/PayerPlanGroups/V1/V1Client.cs">UpdateAsync</a>(payerPlanGroupId, Candid.Net.PayerPlanGroups.V1.MutablePayerPlanGroup { ... }) -> Candid.Net.PayerPlanGroups.V1.PayerPlanGroup</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update any of the fields on a payer plan group
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
await client.PayerPlanGroups.V1.UpdateAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new MutablePayerPlanGroup
    {
        PlanGroupName = "plan_group_name",
        PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PlanType = SourceOfPaymentCode.SelfPay,
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

**payerPlanGroupId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Candid.Net.PayerPlanGroups.V1.MutablePayerPlanGroup` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PayerPlanGroups.V1.<a href="/src/Candid.Net/PayerPlanGroups/V1/V1Client.cs">DeactivateAsync</a>(payerPlanGroupId) -> Candid.Net.PayerPlanGroups.V1.PayerPlanGroup</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Marks the payer plan group as deactivated
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
await client.PayerPlanGroups.V1.DeactivateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

**payerPlanGroupId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Payers V3
<details><summary><code>client.Payers.V3.<a href="/src/Candid.Net/Payers/V3/V3Client.cs">GetAsync</a>(payerUuid) -> Candid.Net.Payers.V3.Payer</code></summary>
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

<details><summary><code>client.Payers.V3.<a href="/src/Candid.Net/Payers/V3/V3Client.cs">GetAllAsync</a>(Candid.Net.Payers.V3.GetAllPayersRequest { ... }) -> Candid.Net.Payers.V3.PayerPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payers.V3.GetAllAsync(
    new Candid.Net.Payers.V3.GetAllPayersRequest
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

**request:** `Candid.Net.Payers.V3.GetAllPayersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Payers V4
<details><summary><code>client.Payers.V4.<a href="/src/Candid.Net/Payers/V4/V4Client.cs">GetAsync</a>(payerUuid) -> Candid.Net.Payers.V4.Payer</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payers.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
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

<details><summary><code>client.Payers.V4.<a href="/src/Candid.Net/Payers/V4/V4Client.cs">GetAllAsync</a>(Candid.Net.Payers.V4.GetAllPayersRequest { ... }) -> Candid.Net.Payers.V4.PayerPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Payers.V4.GetAllAsync(new Candid.Net.Payers.V4.GetAllPayersRequest());
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

**request:** `Candid.Net.Payers.V4.GetAllPayersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ServiceLines V2
<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">CreateAsync</a>(Candid.Net.ServiceLines.V2.ServiceLineCreateStandalone { ... }) -> Candid.Net.ServiceLines.V2.ServiceLine</code></summary>
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
        ProcedureCode = "procedure_code",
        Quantity = "quantity",
        Units = ServiceLineUnits.Mj,
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.ServiceLines.V2.ServiceLineCreateStandalone` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">CreateUniversalAsync</a>(Candid.Net.ServiceLines.V2.UniversalServiceLineCreateStandalone { ... }) -> Candid.Net.ServiceLines.V2.ServiceLine</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceLines.V2.CreateUniversalAsync(
    new UniversalServiceLineCreateStandalone
    {
        Quantity = "quantity",
        Units = ServiceLineUnits.Mj,
        ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.ServiceLines.V2.UniversalServiceLineCreateStandalone` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">UpdateUniversalAsync</a>(serviceLineId, Candid.Net.ServiceLines.V2.UniversalServiceLineUpdate { ... }) -> Candid.Net.ServiceLines.V2.ServiceLine</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ServiceLines.V2.UpdateUniversalAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new UniversalServiceLineUpdate()
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

**request:** `Candid.Net.ServiceLines.V2.UniversalServiceLineUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ServiceLines.V2.<a href="/src/Candid.Net/ServiceLines/V2/V2Client.cs">UpdateAsync</a>(serviceLineId, Candid.Net.ServiceLines.V2.ServiceLineUpdate { ... }) -> Candid.Net.ServiceLines.V2.ServiceLine</code></summary>
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
    new ServiceLineUpdate()
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

**request:** `Candid.Net.ServiceLines.V2.ServiceLineUpdate` 
    
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

## Superbills V1
<details><summary><code>client.Superbills.V1.<a href="/src/Candid.Net/Superbills/V1/V1Client.cs">CreateSuperbillAsync</a>(Candid.Net.Superbills.V1.CreateSuperbillRequest { ... }) -> Candid.Net.Superbills.V1.SuperbillResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Superbills.V1.CreateSuperbillAsync(
    new CreateSuperbillRequest
    {
        PatientExternalId = "patient_external_id",
        DateRangeMin = new DateOnly(2023, 1, 15),
        DateRangeMax = new DateOnly(2023, 1, 15),
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

**request:** `Candid.Net.Superbills.V1.CreateSuperbillRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tasks V3
<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetActionsAsync</a>(taskId) -> Candid.Net.Tasks.V3.TaskActions</code></summary>
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

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetMultiAsync</a>(Candid.Net.Tasks.V3.GetAllTasksRequest { ... }) -> Candid.Net.Tasks.V3.TaskPage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.GetMultiAsync(new GetAllTasksRequest());
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

**request:** `Candid.Net.Tasks.V3.GetAllTasksRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">GetAsync</a>(taskId) -> Candid.Net.Tasks.V3.Task</code></summary>
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

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">CreateAsync</a>(Candid.Net.Tasks.V3.TaskCreateV3 { ... }) -> Candid.Net.Tasks.V3.Task</code></summary>
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
        Description = "description",
        WorkQueueId = "work_queue_id",
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

**request:** `Candid.Net.Tasks.V3.TaskCreateV3` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tasks.V3.<a href="/src/Candid.Net/Tasks/V3/V3Client.cs">UpdateAsync</a>(taskId, Candid.Net.Tasks.V3.TaskUpdateV3 { ... }) -> Candid.Net.Tasks.V3.Task</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tasks.V3.UpdateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", new TaskUpdateV3());
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

**request:** `Candid.Net.Tasks.V3.TaskUpdateV3` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## WriteOffs V1
<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.WriteOffs.V1.GetMultiWriteOffsRequest { ... }) -> Candid.Net.WriteOffs.V1.WriteOffsPage</code></summary>
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
await client.WriteOffs.V1.GetMultiAsync(new GetMultiWriteOffsRequest());
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

**request:** `Candid.Net.WriteOffs.V1.GetMultiWriteOffsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">GetAsync</a>(writeOffId) -> Candid.Net.WriteOffs.V1.WriteOff</code></summary>
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

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">CreateAsync</a>(Candid.Net.WriteOffs.V1.CreateWriteOffsRequest { ... }) -> Candid.Net.WriteOffs.V1.CreateWriteOffsResponse</code></summary>
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
        WriteOffs = new List<WriteOffCreate>()
        {
            new WriteOffCreate(
                new Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
                    new PatientWriteOffCreate
                    {
                        WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                        WriteOffReason = PatientWriteOffReason.SmallBalance,
                        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        AmountCents = 1,
                    }
                )
            ),
            new WriteOffCreate(
                new Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
                    new PatientWriteOffCreate
                    {
                        WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                        WriteOffReason = PatientWriteOffReason.SmallBalance,
                        ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        AmountCents = 1,
                    }
                )
            ),
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

**request:** `Candid.Net.WriteOffs.V1.CreateWriteOffsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">RevertAsync</a>(writeOffId) -> Candid.Net.WriteOffs.V1.WriteOff</code></summary>
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

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">RevertInsuranceBalanceAdjustmentAsync</a>(adjustmentId) -> Candid.Net.WriteOffs.V1.WriteOff</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reverts an Insurance Balance Adjustment given an `adjustment_id`
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
await client.WriteOffs.V1.RevertInsuranceBalanceAdjustmentAsync(
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

**adjustmentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.WriteOffs.V1.<a href="/src/Candid.Net/WriteOffs/V1/V1Client.cs">RevertEraOriginatedInsuranceBalanceAdjustmentAsync</a>(adjustmentId) -> string</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Reverts an ERA-originated Insurance Balance Adjustment given an `adjustment_id`
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
await client.WriteOffs.V1.RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
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

**adjustmentId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Appointments V1
<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Appointments.V1.MutableAppointment { ... }) -> Candid.Net.PreEncounter.Appointments.V1.Appointment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an appointment.  VersionConflictError is returned when the placer_appointment_id is already in use.
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
        PatientId = "patient_id",
        StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        ServiceDuration = 1,
        Services = new List<Service>() { new Service(), new Service() },
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

**request:** `Candid.Net.PreEncounter.Appointments.V1.MutableAppointment` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">GetVisitsAsync</a>(Candid.Net.PreEncounter.Appointments.V1.VisitsRequest { ... }) -> Candid.Net.PreEncounter.Appointments.V1.VisitsPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets all Visits within a given time range. The return list is ordered by start_time ascending.
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
await client.PreEncounter.Appointments.V1.GetVisitsAsync(new VisitsRequest());
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

**request:** `Candid.Net.PreEncounter.Appointments.V1.VisitsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Appointments.V1.Appointment</code></summary>
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
await client.PreEncounter.Appointments.V1.GetAsync("id");
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

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<Candid.Net.PreEncounter.Appointments.V1.Appointment></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets an appointment along with it's full history.  The return list is ordered by version ascending.
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
await client.PreEncounter.Appointments.V1.GetHistoryAsync("id");
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

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Appointments.V1.MutableAppointment { ... }) -> Candid.Net.PreEncounter.Appointments.V1.Appointment</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an appointment. The path must contain the next version number to prevent race conditions. For example, if the current version of the appointment is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the appointment. Updating historic versions is not supported.
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
    "id",
    "version",
    new MutableAppointment
    {
        PatientId = "patient_id",
        StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        ServiceDuration = 1,
        Services = new List<Service>() { new Service(), new Service() },
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

**request:** `Candid.Net.PreEncounter.Appointments.V1.MutableAppointment` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Appointments.V1.<a href="/src/Candid.Net/PreEncounter/Appointments/V1/V1Client.cs">ScanAsync</a>(Candid.Net.PreEncounter.Appointments.V1.AppointmentScanRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Appointments.V1.Appointment></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 appointment updates.  The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
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

**request:** `Candid.Net.PreEncounter.Appointments.V1.AppointmentScanRequest` 
    
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

Sets an appointment as deactivated.  The path must contain the most recent version to prevent race conditions.  Deactivating historic versions is not supported. Subsequent updates via PUT to the appointment will "reactivate" the appointment and set the deactivated flag to false.
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
await client.PreEncounter.Appointments.V1.DeactivateAsync("id", "version");
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
<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Coverages.V1.MutableCoverage { ... }) -> Candid.Net.PreEncounter.Coverages.V1.Coverage</code></summary>
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
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
            BiologicalSex = Sex.Female,
        },
        Relationship = Relationship.Self,
        Patient = "patient",
        InsurancePlan = new InsurancePlan
        {
            MemberId = "member_id",
            PayerId = "payer_id",
            PayerName = "payer_name",
        },
        Verified = true,
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.MutableCoverage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Coverages.V1.MutableCoverage { ... }) -> Candid.Net.PreEncounter.Coverages.V1.Coverage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a Coverage. The path must contain the next version number to prevent race conditions. For example, if the current version of the coverage is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the coverage. Updating historic versions is not supported.
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
    "version",
    new MutableCoverage
    {
        Status = CoverageStatus.Active,
        Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
        {
            Name = new HumanName
            {
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
            BiologicalSex = Sex.Female,
        },
        Relationship = Relationship.Self,
        Patient = "patient",
        InsurancePlan = new InsurancePlan
        {
            MemberId = "member_id",
            PayerId = "payer_id",
            PayerName = "payer_name",
        },
        Verified = true,
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.MutableCoverage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetMultiPaginatedAsync</a>(Candid.Net.PreEncounter.Coverages.V1.CoverageGetMultiPaginatedRequest { ... }) -> Candid.Net.PreEncounter.Coverages.V1.CoveragesPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns a page of Coverages based on the search criteria.
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
await client.PreEncounter.Coverages.V1.GetMultiPaginatedAsync(
    new CoverageGetMultiPaginatedRequest()
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.CoverageGetMultiPaginatedRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Coverages.V1.Coverage</code></summary>
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

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<Candid.Net.PreEncounter.Coverages.V1.Coverage></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a coverage along with it's full history.  The return list is ordered by version ascending.
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

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.PreEncounter.Coverages.V1.CoverageGetMultiRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Coverages.V1.Coverage></code></summary>
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
await client.PreEncounter.Coverages.V1.GetMultiAsync(new CoverageGetMultiRequest());
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.CoverageGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">ScanAsync</a>(Candid.Net.PreEncounter.Coverages.V1.CoverageScanRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Coverages.V1.Coverage></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 coverage updates.  The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.CoverageScanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">BatchUpdatePpgAsync</a>(ppgId, Candid.Net.PreEncounter.Coverages.V1.PayerPlanGroupFields { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Finds all coverages associated with the given ppg_id and updates the ppg_fields for each coverage.
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
await client.PreEncounter.Coverages.V1.BatchUpdatePpgAsync(
    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    new PayerPlanGroupFields
    {
        PayerPlanGroupId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        PayerId = "payer_id",
        PayerName = "payer_name",
        PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
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

**ppgId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Candid.Net.PreEncounter.Coverages.V1.PayerPlanGroupFields` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">CheckEligibilityAsync</a>(id, Candid.Net.PreEncounter.Coverages.V1.CheckEligibilityRequest { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityCheckMetadata</code></summary>
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
        Npi = "npi",
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

**request:** `Candid.Net.PreEncounter.Coverages.V1.CheckEligibilityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Coverages.V1.<a href="/src/Candid.Net/PreEncounter/Coverages/V1/V1Client.cs">GetEligibilityAsync</a>(id, checkId) -> Candid.Net.PreEncounter.Coverages.V1.CoverageEligibilityCheckResponse</code></summary>
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
    "check_id"
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

## PreEncounter EligibilityChecks V1
<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">PostAsync</a>(Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRequest { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityCheck</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sends real-time eligibility checks to payers through Stedi.
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
await client.PreEncounter.EligibilityChecks.V1.PostAsync(
    new EligibilityRequest
    {
        PayerId = "payer_id",
        Provider = new IndividualProvider { Npi = "npi" },
        Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
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

**request:** `Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">BatchAsync</a>(IEnumerable<Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRequest> { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.BatchEligibilityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sends a batch of eligibility checks to payers through Stedi.
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
await client.PreEncounter.EligibilityChecks.V1.BatchAsync(
    new List<EligibilityRequest>()
    {
        new EligibilityRequest
        {
            PayerId = "payer_id",
            Provider = new IndividualProvider { Npi = "npi" },
            Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
        },
        new EligibilityRequest
        {
            PayerId = "payer_id",
            Provider = new IndividualProvider { Npi = "npi" },
            Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
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

**request:** `IEnumerable<Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRequest>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">PollBatchAsync</a>(batchId, Candid.Net.PreEncounter.EligibilityChecks.V1.BatchEligibilityPollRequest { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityCheckPage</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Polls the status of a batch eligibility check.
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
await client.PreEncounter.EligibilityChecks.V1.PollBatchAsync(
    "batch_id",
    new BatchEligibilityPollRequest()
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

**batchId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Candid.Net.PreEncounter.EligibilityChecks.V1.BatchEligibilityPollRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">PayerSearchAsync</a>(Candid.Net.PreEncounter.EligibilityChecks.V1.PayerSearchRequest { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.PayerSearchResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for payers that match the query parameters.
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
await client.PreEncounter.EligibilityChecks.V1.PayerSearchAsync(new PayerSearchRequest());
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

**request:** `Candid.Net.PreEncounter.EligibilityChecks.V1.PayerSearchRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">RecommendationAsync</a>(Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRecommendationRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRecommendation></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets recommendation for eligibility checks based on the request.
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
await client.PreEncounter.EligibilityChecks.V1.RecommendationAsync(
    new EligibilityRecommendationRequest()
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

**request:** `Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRecommendationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.EligibilityChecks.V1.<a href="/src/Candid.Net/PreEncounter/EligibilityChecks/V1/V1Client.cs">CreateRecommendationAsync</a>(Candid.Net.PreEncounter.EligibilityChecks.V1.PostEligibilityRecommendationRequest { ... }) -> Candid.Net.PreEncounter.EligibilityChecks.V1.EligibilityRecommendation</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create an eligibiilty recommendation based on the request.
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
await client.PreEncounter.EligibilityChecks.V1.CreateRecommendationAsync(
    new PostEligibilityRecommendationRequest
    {
        EligibilityCheckId = "eligibility_check_id",
        Patient = new EligibilityRecommendationPatientInfo(),
        Recommendation = new EligibilityRecommendationPayload(
            new EligibilityRecommendationPayload.MedicareAdvantage(
                new MedicareAdvantageRecommendation
                {
                    Payload = new MedicareAdvantageRecommendationPayload(),
                }
            )
        ),
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

**request:** `Candid.Net.PreEncounter.EligibilityChecks.V1.PostEligibilityRecommendationRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Images V1
<details><summary><code>client.PreEncounter.Images.V1.<a href="/src/Candid.Net/PreEncounter/Images/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Images.V1.MutableImage { ... }) -> Candid.Net.PreEncounter.Images.V1.Image</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds an image.  VersionConflictError is returned if a front or back of this coverage already exists.
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
await client.PreEncounter.Images.V1.CreateAsync(
    new MutableImage
    {
        FileName = "file_name",
        DisplayName = "display_name",
        FileType = "file_type",
        Status = ImageStatus.Pending,
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

**request:** `Candid.Net.PreEncounter.Images.V1.MutableImage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Images.V1.<a href="/src/Candid.Net/PreEncounter/Images/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Images.V1.Image</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets an image by imageId.
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
await client.PreEncounter.Images.V1.GetAsync("id");
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

<details><summary><code>client.PreEncounter.Images.V1.<a href="/src/Candid.Net/PreEncounter/Images/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Images.V1.MutableImage { ... }) -> Candid.Net.PreEncounter.Images.V1.Image</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates an Image.  The path must contain the most recent version to prevent races.
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
await client.PreEncounter.Images.V1.UpdateAsync(
    "id",
    "version",
    new MutableImage
    {
        FileName = "file_name",
        DisplayName = "display_name",
        FileType = "file_type",
        Status = ImageStatus.Pending,
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

**request:** `Candid.Net.PreEncounter.Images.V1.MutableImage` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Images.V1.<a href="/src/Candid.Net/PreEncounter/Images/V1/V1Client.cs">DeactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Sets an Image as deactivated.  The path must contain the most recent version to prevent races.
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
await client.PreEncounter.Images.V1.DeactivateAsync("id", "version");
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

<details><summary><code>client.PreEncounter.Images.V1.<a href="/src/Candid.Net/PreEncounter/Images/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.PreEncounter.Images.V1.ImageGetMultiRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Images.V1.Image></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for images that match the query parameters.
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
await client.PreEncounter.Images.V1.GetMultiAsync(new ImageGetMultiRequest());
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

**request:** `Candid.Net.PreEncounter.Images.V1.ImageGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Lists V1
<details><summary><code>client.PreEncounter.Lists.V1.<a href="/src/Candid.Net/PreEncounter/Lists/V1/V1Client.cs">GetPatientListAsync</a>(Candid.Net.PreEncounter.Lists.V1.PatientListRequest { ... }) -> Candid.Net.PreEncounter.Lists.V1.PatientListPage</code></summary>
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
await client.PreEncounter.Lists.V1.GetPatientListAsync(new PatientListRequest());
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

**request:** `Candid.Net.PreEncounter.Lists.V1.PatientListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Lists.V1.<a href="/src/Candid.Net/PreEncounter/Lists/V1/V1Client.cs">GetAppointmentListAsync</a>(Candid.Net.PreEncounter.Lists.V1.AppointmentsGetListRequest { ... }) -> Candid.Net.PreEncounter.Lists.V1.AppointmentListPage</code></summary>
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
await client.PreEncounter.Lists.V1.GetAppointmentListAsync(new AppointmentsGetListRequest());
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

**request:** `Candid.Net.PreEncounter.Lists.V1.AppointmentsGetListRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Notes V1
<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Notes.V1.Note</code></summary>
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
await client.PreEncounter.Notes.V1.GetAsync("id");
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

<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Notes.V1.MutableNote { ... }) -> Candid.Net.PreEncounter.Notes.V1.Note</code></summary>
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
await client.PreEncounter.Notes.V1.CreateAsync(new MutableNote { Value = "value" });
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

**request:** `Candid.Net.PreEncounter.Notes.V1.MutableNote` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Notes.V1.<a href="/src/Candid.Net/PreEncounter/Notes/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Notes.V1.MutableNote { ... }) -> Candid.Net.PreEncounter.Notes.V1.Note</code></summary>
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
    "id",
    "version",
    new MutableNote { Value = "value" }
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

**request:** `Candid.Net.PreEncounter.Notes.V1.MutableNote` 
    
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

Sets a note as deactivated.  The path must contain the most recent version to prevent races.
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
await client.PreEncounter.Notes.V1.DeactivateAsync("id", "version");
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
<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Patients.V1.CreatePatientRequest { ... }) -> Candid.Net.PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a patient.  VersionConflictError is returned when the patient's external ID is already in use.
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
        Body = new MutablePatient
        {
            Name = new HumanName
            {
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
            OtherNames = new List<HumanName>()
            {
                new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
            },
            BirthDate = new DateOnly(2023, 1, 15),
            BiologicalSex = Sex.Female,
            PrimaryAddress = new Candid.Net.PreEncounter.Common.Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "line", "line" },
                City = "city",
                State = "state",
                PostalCode = "postal_code",
                Country = "country",
            },
            OtherAddresses = new List<Candid.Net.PreEncounter.Common.Address>()
            {
                new Candid.Net.PreEncounter.Common.Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "line", "line" },
                    City = "city",
                    State = "state",
                    PostalCode = "postal_code",
                    Country = "country",
                },
                new Candid.Net.PreEncounter.Common.Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "line", "line" },
                    City = "city",
                    State = "state",
                    PostalCode = "postal_code",
                    Country = "country",
                },
            },
            OtherTelecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                new ContactPoint { Value = "value", Use = ContactPointUse.Home },
            },
            Contacts = new List<Contact>()
            {
                new Contact
                {
                    Relationship = new List<Relationship>()
                    {
                        Relationship.Self,
                        Relationship.Self,
                    },
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                    {
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                    },
                },
                new Contact
                {
                    Relationship = new List<Relationship>()
                    {
                        Relationship.Self,
                        Relationship.Self,
                    },
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                    {
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                    },
                },
            },
            GeneralPractitioners = new List<ExternalProvider>()
            {
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                },
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                },
            },
            FilingOrder = new FilingOrder
            {
                Coverages = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.PreEncounter.Patients.V1.CreatePatientRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">CreateWithMrnAsync</a>(Candid.Net.PreEncounter.Patients.V1.CreatePatientWithMrnRequest { ... }) -> Candid.Net.PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Adds a patient and hydrates their MRN with a pre-existing MRN.  Once this patient is created their MRN will not be editable. BadRequestError is returned when the MRN is greater than 20 characters. VersionConflictError is returned when the patient's external ID is already in use.
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
        Body = new MutablePatientWithMrn
        {
            Mrn = "mrn",
            Name = new HumanName
            {
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
            OtherNames = new List<HumanName>()
            {
                new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
            },
            BirthDate = new DateOnly(2023, 1, 15),
            BiologicalSex = Sex.Female,
            PrimaryAddress = new Candid.Net.PreEncounter.Common.Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "line", "line" },
                City = "city",
                State = "state",
                PostalCode = "postal_code",
                Country = "country",
            },
            OtherAddresses = new List<Candid.Net.PreEncounter.Common.Address>()
            {
                new Candid.Net.PreEncounter.Common.Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "line", "line" },
                    City = "city",
                    State = "state",
                    PostalCode = "postal_code",
                    Country = "country",
                },
                new Candid.Net.PreEncounter.Common.Address
                {
                    Use = AddressUse.Home,
                    Line = new List<string>() { "line", "line" },
                    City = "city",
                    State = "state",
                    PostalCode = "postal_code",
                    Country = "country",
                },
            },
            OtherTelecoms = new List<ContactPoint>()
            {
                new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                new ContactPoint { Value = "value", Use = ContactPointUse.Home },
            },
            Contacts = new List<Contact>()
            {
                new Contact
                {
                    Relationship = new List<Relationship>()
                    {
                        Relationship.Self,
                        Relationship.Self,
                    },
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                    {
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                    },
                },
                new Contact
                {
                    Relationship = new List<Relationship>()
                    {
                        Relationship.Self,
                        Relationship.Self,
                    },
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                    Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                    {
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                        new Candid.Net.PreEncounter.Common.Address
                        {
                            Use = AddressUse.Home,
                            Line = new List<string>() { "line", "line" },
                            City = "city",
                            State = "state",
                            PostalCode = "postal_code",
                            Country = "country",
                        },
                    },
                },
            },
            GeneralPractitioners = new List<ExternalProvider>()
            {
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                },
                new ExternalProvider
                {
                    Name = new HumanName
                    {
                        Family = "family",
                        Given = new List<string>() { "given", "given" },
                        Use = NameUse.Usual,
                    },
                    Telecoms = new List<ContactPoint>()
                    {
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                        new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    },
                },
            },
            FilingOrder = new FilingOrder
            {
                Coverages = new List<string>()
                {
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.PreEncounter.Patients.V1.CreatePatientWithMrnRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetMultiAsync</a>(Candid.Net.PreEncounter.Patients.V1.PatientsSearchRequestPaginated { ... }) -> Candid.Net.PreEncounter.Patients.V1.PatientPage</code></summary>
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
await client.PreEncounter.Patients.V1.GetMultiAsync(new PatientsSearchRequestPaginated());
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

**request:** `Candid.Net.PreEncounter.Patients.V1.PatientsSearchRequestPaginated` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">SearchProvidersAsync</a>(Candid.Net.PreEncounter.Patients.V1.SearchProvidersRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Common.ExternalProvider></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Searches for referring providers that match the query parameters.  The search is case-insensitive, supports fuzzy matching, and matches against provider name and NPI. The search criteria must be an alphanumeric string, and the search is limited to the first 20 results.
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
await client.PreEncounter.Patients.V1.SearchProvidersAsync(
    new SearchProvidersRequest { SearchCriteria = "search_criteria" }
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

**request:** `Candid.Net.PreEncounter.Patients.V1.SearchProvidersRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Patients.V1.Patient</code></summary>
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
await client.PreEncounter.Patients.V1.GetAsync("id");
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

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetByMrnAsync</a>(mrn) -> Candid.Net.PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a patient by mrn.
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
await client.PreEncounter.Patients.V1.GetByMrnAsync("mrn");
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

**mrn:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">GetHistoryAsync</a>(id) -> IEnumerable<Candid.Net.PreEncounter.Patients.V1.Patient></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Gets a patient along with it's full history.  The return list is ordered by version ascending.
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
await client.PreEncounter.Patients.V1.GetHistoryAsync("id");
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

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Patients.V1.MutablePatient { ... }) -> Candid.Net.PreEncounter.Patients.V1.Patient</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Updates a patient. The path must contain the next version number to prevent race conditions. For example, if the current version of the patient is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the patient. Updating historic versions is not supported.
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
    "id",
    "version",
    new MutablePatient
    {
        Name = new HumanName
        {
            Family = "family",
            Given = new List<string>() { "given", "given" },
            Use = NameUse.Usual,
        },
        OtherNames = new List<HumanName>()
        {
            new HumanName
            {
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
            new HumanName
            {
                Family = "family",
                Given = new List<string>() { "given", "given" },
                Use = NameUse.Usual,
            },
        },
        BirthDate = new DateOnly(2023, 1, 15),
        BiologicalSex = Sex.Female,
        PrimaryAddress = new Candid.Net.PreEncounter.Common.Address
        {
            Use = AddressUse.Home,
            Line = new List<string>() { "line", "line" },
            City = "city",
            State = "state",
            PostalCode = "postal_code",
            Country = "country",
        },
        OtherAddresses = new List<Candid.Net.PreEncounter.Common.Address>()
        {
            new Candid.Net.PreEncounter.Common.Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "line", "line" },
                City = "city",
                State = "state",
                PostalCode = "postal_code",
                Country = "country",
            },
            new Candid.Net.PreEncounter.Common.Address
            {
                Use = AddressUse.Home,
                Line = new List<string>() { "line", "line" },
                City = "city",
                State = "state",
                PostalCode = "postal_code",
                Country = "country",
            },
        },
        OtherTelecoms = new List<ContactPoint>()
        {
            new ContactPoint { Value = "value", Use = ContactPointUse.Home },
            new ContactPoint { Value = "value", Use = ContactPointUse.Home },
        },
        Contacts = new List<Contact>()
        {
            new Contact
            {
                Relationship = new List<Relationship>() { Relationship.Self, Relationship.Self },
                Name = new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                },
                Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                {
                    new Candid.Net.PreEncounter.Common.Address
                    {
                        Use = AddressUse.Home,
                        Line = new List<string>() { "line", "line" },
                        City = "city",
                        State = "state",
                        PostalCode = "postal_code",
                        Country = "country",
                    },
                    new Candid.Net.PreEncounter.Common.Address
                    {
                        Use = AddressUse.Home,
                        Line = new List<string>() { "line", "line" },
                        City = "city",
                        State = "state",
                        PostalCode = "postal_code",
                        Country = "country",
                    },
                },
            },
            new Contact
            {
                Relationship = new List<Relationship>() { Relationship.Self, Relationship.Self },
                Name = new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                },
                Addresses = new List<Candid.Net.PreEncounter.Common.Address>()
                {
                    new Candid.Net.PreEncounter.Common.Address
                    {
                        Use = AddressUse.Home,
                        Line = new List<string>() { "line", "line" },
                        City = "city",
                        State = "state",
                        PostalCode = "postal_code",
                        Country = "country",
                    },
                    new Candid.Net.PreEncounter.Common.Address
                    {
                        Use = AddressUse.Home,
                        Line = new List<string>() { "line", "line" },
                        City = "city",
                        State = "state",
                        PostalCode = "postal_code",
                        Country = "country",
                    },
                },
            },
        },
        GeneralPractitioners = new List<ExternalProvider>()
        {
            new ExternalProvider
            {
                Name = new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                },
            },
            new ExternalProvider
            {
                Name = new HumanName
                {
                    Family = "family",
                    Given = new List<string>() { "given", "given" },
                    Use = NameUse.Usual,
                },
                Telecoms = new List<ContactPoint>()
                {
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                    new ContactPoint { Value = "value", Use = ContactPointUse.Home },
                },
            },
        },
        FilingOrder = new FilingOrder
        {
            Coverages = new List<string>()
            {
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
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

**request:** `Candid.Net.PreEncounter.Patients.V1.MutablePatient` 
    
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

Sets a patient as deactivated.  The path must contain the most recent version plus 1 to prevent race conditions.  Deactivating historic versions is not supported.
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
await client.PreEncounter.Patients.V1.DeactivateAsync("id", "version");
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

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">ReactivateAsync</a>(id, version)</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Removes the deactivated flag for a patient.  The path must contain the most recent version plus 1 to prevent race conditions.  Reactivating historic versions is not supported.
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
await client.PreEncounter.Patients.V1.ReactivateAsync("id", "version");
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

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">SearchAsync</a>(Candid.Net.PreEncounter.Patients.V1.PatientGetMultiRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Patients.V1.Patient></code></summary>
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
await client.PreEncounter.Patients.V1.SearchAsync(new PatientGetMultiRequest());
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

**request:** `Candid.Net.PreEncounter.Patients.V1.PatientGetMultiRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Patients.V1.<a href="/src/Candid.Net/PreEncounter/Patients/V1/V1Client.cs">ScanAsync</a>(Candid.Net.PreEncounter.Patients.V1.PatientScanRequest { ... }) -> IEnumerable<Candid.Net.PreEncounter.Patients.V1.Patient></code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Scans up to 100 patient updates.  The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
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

**request:** `Candid.Net.PreEncounter.Patients.V1.PatientScanRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## PreEncounter Tags V1
<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">GetAsync</a>(id) -> Candid.Net.PreEncounter.Tags.V1.Tag</code></summary>
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
await client.PreEncounter.Tags.V1.GetAsync("id");
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

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">GetAllAsync</a>(Candid.Net.PreEncounter.Tags.V1.GetAllTagsRequest { ... }) -> Candid.Net.PreEncounter.Tags.V1.TagPage</code></summary>
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
await client.PreEncounter.Tags.V1.GetAllAsync(new GetAllTagsRequest());
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

**request:** `Candid.Net.PreEncounter.Tags.V1.GetAllTagsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">CreateAsync</a>(Candid.Net.PreEncounter.Tags.V1.MutableTag { ... }) -> Candid.Net.PreEncounter.Tags.V1.Tag</code></summary>
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
await client.PreEncounter.Tags.V1.CreateAsync(new MutableTag { Value = "value" });
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

**request:** `Candid.Net.PreEncounter.Tags.V1.MutableTag` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.PreEncounter.Tags.V1.<a href="/src/Candid.Net/PreEncounter/Tags/V1/V1Client.cs">UpdateAsync</a>(id, version, Candid.Net.PreEncounter.Tags.V1.MutableTag { ... }) -> Candid.Net.PreEncounter.Tags.V1.Tag</code></summary>
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
await client.PreEncounter.Tags.V1.UpdateAsync("id", "version", new MutableTag { Value = "value" });
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

**request:** `Candid.Net.PreEncounter.Tags.V1.MutableTag` 
    
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

Sets a tag as deactivated.  The path must contain the most recent version to prevent races.
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
await client.PreEncounter.Tags.V1.DeactivateAsync("id", "version");
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
<details><summary><code>client.Diagnoses.<a href="/src/Candid.Net/Diagnoses/DiagnosesClient.cs">CreateAsync</a>(Diagnoses.StandaloneDiagnosisCreate { ... }) -> Diagnoses.Diagnosis</code></summary>
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
        CodeType = DiagnosisTypeCode.Abf,
        Code = "code",
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

**request:** `Diagnoses.StandaloneDiagnosisCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Diagnoses.<a href="/src/Candid.Net/Diagnoses/DiagnosesClient.cs">UpdateAsync</a>(diagnosisId, Diagnoses.DiagnosisUpdate { ... }) -> Diagnoses.Diagnosis</code></summary>
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
await client.Diagnoses.UpdateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", new DiagnosisUpdate());
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

**request:** `Diagnoses.DiagnosisUpdate` 
    
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
<details><summary><code>client.ServiceFacility.<a href="/src/Candid.Net/ServiceFacility/ServiceFacilityClient.cs">UpdateAsync</a>(serviceFacilityId, ServiceFacility.EncounterServiceFacilityUpdate { ... }) -> ServiceFacility.EncounterServiceFacility</code></summary>
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
    new EncounterServiceFacilityUpdate()
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

**request:** `ServiceFacility.EncounterServiceFacilityUpdate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
