using global::Candid.Net.Core;
using NUnit.Framework;
using WireMock.Logging;
using WireMock.Server;
using WireMock.Settings;

namespace Candid.Net.Test.Unit.MockServer;

public class BaseMockServerTest
{
    protected WireMockServer Server { get; set; } = null!;

    protected global::Candid.Net.Candid Client { get; set; } = null!;

    protected RequestOptions RequestOptions { get; set; } = new();

    private void MockOAuthEndpoint()
    {
        const string requestJson = """
            {
              "client_id": "YOUR_CLIENT_ID",
              "client_secret": "YOUR_CLIENT_SECRET"
            }
            """;

        const string mockResponse = """
            {
              "access_token": "eyJz93a...k4laUWw",
              "expires_in": 86400,
              "token_type": "Bearer"
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/api/auth/v2/token").UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );
    }

    [OneTimeSetUp]
    public void GlobalSetup()
    {
        // Start the WireMock server
        Server = WireMockServer.Start(
            new WireMockServerSettings { Logger = new WireMockConsoleLogger() }
        );

        // Initialize the Client
        Client = new global::Candid.Net.Candid(
            "client_id",
            "client_secret",
            clientOptions: new ClientOptions
            {
                Environment = new CandidEnvironment
                {
                    CandidApi = Server.Urls[0],
                    PreEncounter = Server.Urls[0],
                },
                MaxRetries = 0,
            }
        );
        MockOAuthEndpoint();
    }

    [OneTimeTearDown]
    public void GlobalTeardown()
    {
        Server.Stop();
        Server.Dispose();
    }
}
