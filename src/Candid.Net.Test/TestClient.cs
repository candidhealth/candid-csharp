using Candid.Net.Auth.Default;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;
using Candid.Net.Exports.V3;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class TestClient
{
    
    [Test]
    public async Task TestSerialization()
    {
        var client = new CandidClient(
            "<CLIENT_ID>",
            "<CLIENT_SECRET>",
            new ClientOptions
            {
                Environment = CandidEnvironment.STAGING
            });
        await client.Encounters.V4.GetAllAsync(new GetAllEncountersRequest() { });
    }
}
