using global::Candid.Net.FeeSchedules.V3;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class RateEntryTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""start_date"": ""2024-04-11"",
  ""rate_cents"": 33000,
  ""is_deactivated"": false
}
";

        JsonAssert.Roundtrips<RateEntry>(inputJson);
    }
}
