# Candid Health .NET Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-SDK%20generated%20by%20Fern-brightgreen)](https://github.com/fern-api/fern)
![NuGet Version](https://img.shields.io/nuget/v/Candid.Net)

The official Candid Health C# library, supporting .NET Standard, .NET Core, and .NET Framework.

## Installation

Using the .NET Core command-line interface (CLI) tools:

```sh
dotnet add package Candid.Net
```

Using the NuGet Command Line Interface (CLI):

```sh
nuget install Candid.Net
```

## Documentation

API reference documentation is available [here](https://candid.docs.buildwithfern.com/introduction/getting-started).

## Usage

Below are code snippets of how you can use the C# SDK.

### Get Guarantor

```csharp
using Candid.Net;

var candid = new CandidClient("YOUR_CLIENT_ID", "YOUR_CLIENT_SECRET");

var guarantor = candid.Guarantor.V1.GetAsync(Guid.Parse("guarantor-id")).Result;
```

## Advanced

### Retries

429 Rate Limit, and >=500 Internal errors will all be
retried twice with exponential backoff. You can override this behavior
globally or per-request.

```csharp
var candid = new CandidClient("...", new ClientOptions {
    MaxRetries = 1 // Only retry once
});
```

### Timeouts

The SDK defaults to a 60s timeout. You can override this behaviour
globally or per-request.

```csharp
var candid = new CandidClient("...", new ClientOptions {
    TimeoutInSeconds = 20 // Lower timeout
});
```

### HTTP Client

You can override the HttpClient by passing in `ClientOptions`.

```csharp
var candid = new CandidClient("YOUR_API_KEY", new ClientOptions {
    HttpClient = ... // Override the Http Client
    BaseURL = ... // Override the Base URL
})
```

## Contributing

While we value open-source contributions to this SDK, this library
is generated programmatically. Additions made directly to this library
would have to be moved over to our generation code, otherwise they would
be overwritten upon the next generated release. Feel free to open a PR as a
proof of concept, but know that we will not be able to Candid it as-is.
We suggest opening an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!
