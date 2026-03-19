using System.Globalization;
using global::Candid.Net.Core;
using global::Candid.Net.Exports.V3;
using global::Candid.Net.Test.Utils;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetExportsResponseTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "name": "John Doe",
              "created_at": "2021-10-07T00:00:00Z",
              "authenticated_download_url": "https://example.com",
              "authenticated_download_url_expiration": "2021-10-07T00:02:00Z"
            }
            """;
        var expectedObject = new GetExportsResponse
        {
            Name = "John Doe",
            CreatedAt = DateTime.Parse(
                "2021-10-07T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            AuthenticatedDownloadUrl = "https://example.com",
            AuthenticatedDownloadUrlExpiration = DateTime.Parse(
                "2021-10-07T00:02:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
        };
        var deserializedObject = JsonUtils.Deserialize<GetExportsResponse>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var inputJson = """
            {
              "name": "John Doe",
              "created_at": "2021-10-07T00:00:00Z",
              "authenticated_download_url": "https://example.com",
              "authenticated_download_url_expiration": "2021-10-07T00:02:00Z"
            }
            """;
        JsonAssert.Roundtrips<GetExportsResponse>(inputJson);
    }
}
