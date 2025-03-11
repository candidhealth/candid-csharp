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

## ChargeCaptureBundles V1
<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">GetAsync</a>(chargeCaptureBundleId) -> ChargeCaptureBundle</code></summary>
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

**chargeCaptureBundleId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">ResubmitAsync</a>(chargeCaptureBundleId) -> ChargeCaptureBundle</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.ResubmitAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**chargeCaptureBundleId:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.ChargeCaptureBundles.V1.<a href="/src/Candid.Net/ChargeCaptureBundles/V1/V1Client.cs">GetAllAsync</a>(GetAllChargeCaptureBundlesRequest { ... }) -> ChargeCaptureBundlePage</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ChargeCaptureBundles.V1.GetAllAsync(
    new GetAllChargeCaptureBundlesRequest
    {
        Limit = 1,
        PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
        PatientExternalId = "string",
        BundleStatus = ChargeCaptureBundleStatus.InProgress,
        ChargeStatus = ChargeCaptureStatus.Planned,
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

**request:** `GetAllChargeCaptureBundlesRequest` 
    
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
        Data = new ChargeCaptureData(),
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
        Data = new ChargeCaptureData(),
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

<Tip>Candid is deprecating support for this endpoint. It is instead recommended to use [Candid's Stedi passthrough endpoint](https://docs.joincandidhealth.com/api-reference/pre-encounter/eligibility-checks/v-1/post).
For assistance with the transition, please reference the [Transitioning to Candid's New Eligibility Endpoint](https://support.joincandidhealth.com/hc/en-us/articles/34918552872980) document in the Candid Support Center.</Tip>

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
    new ReferringProviderUpdate
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
    new InitialReferringProviderUpdate
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
    new SupervisingProviderUpdate
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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
        FirstName = "string",
        LastName = "string",
        OrganizationName = "string",
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

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">GetAsync</a>(encounterId) -> Encounters.V4.Encounter</code></summary>
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

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateAsync</a>(EncounterCreate { ... }) -> Encounters.V4.Encounter</code></summary>
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
                    ClinicalTrialInfo = new List<PatientClinicalTrialInfoCreate>()
                    {
                        new PatientClinicalTrialInfoCreate
                        {
                            ClinicalTrialId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                        },
                    },
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
                RxBin = "string",
                RxPcn = "string",
                ImageUrlFront = "string",
                ImageUrlBack = "string",
                EmrPayerCrosswalk = EmrPayerCrosswalk.Healthie,
                GroupNumber = "string",
                PlanName = "string",
                PlanType = SourceOfPaymentCode.SelfPay,
                InsuranceType = Candid.Net.InsuranceTypeCode.C01,
                PayerPlanGroupId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
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
        SubscriberSecondary = new SubscriberCreate
        {
            InsuranceCard = new InsuranceCardCreate
            {
                MemberId = "string",
                PayerName = "string",
                PayerId = "string",
                RxBin = "string",
                RxPcn = "string",
                ImageUrlFront = "string",
                ImageUrlBack = "string",
                EmrPayerCrosswalk = EmrPayerCrosswalk.Healthie,
                GroupNumber = "string",
                PlanName = "string",
                PlanType = SourceOfPaymentCode.SelfPay,
                InsuranceType = Candid.Net.InsuranceTypeCode.C01,
                PayerPlanGroupId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            },
            PatientRelationshipToSubscriberCode = PatientRelationshipToInsuredCodeAll.Spouse,
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
                Notes = new List<ClinicalNote>() { },
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
                ProcedureCode = "string",
                Quantity = "string",
                Units = ServiceLineUnits.Mj,
                DiagnosisPointers = new List<int>() { },
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
        EpsdtReferral = new EpsdtReferral
        {
            ConditionIndicator1 = EpsdtReferralConditionIndicatorCode.Av,
            ConditionIndicator2 = EpsdtReferralConditionIndicatorCode.Av,
            ConditionIndicator3 = EpsdtReferralConditionIndicatorCode.Av,
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

**request:** `EncounterCreate` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">CreateFromPreEncounterPatientAsync</a>(EncounterCreateFromPreEncounter { ... }) -> Encounters.V4.Encounter</code></summary>
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
            FirstName = "string",
            LastName = "string",
            OrganizationName = "string",
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
                Notes = new List<ClinicalNote>() { },
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
                ProcedureCode = "string",
                Quantity = "string",
                Units = ServiceLineUnits.Mj,
                DiagnosisPointers = new List<int>() { },
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

<details><summary><code>client.Encounters.V4.<a href="/src/Candid.Net/Encounters/V4/V4Client.cs">UpdateAsync</a>(encounterId, EncounterUpdate { ... }) -> Encounters.V4.Encounter</code></summary>
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