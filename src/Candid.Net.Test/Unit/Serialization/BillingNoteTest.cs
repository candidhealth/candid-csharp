using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net.BillingNotes.V2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

#nullable enable

namespace Candid.Net.Test;

[TestFixture]
public class BillingNoteTest
{
    [Test]
    public void TestSerialization()
    {
        var inputJson =
            @"
        {
  ""billing_note_id"": ""99882EEA-936F-4E71-BC4F-520E4D14E3E2"",
  ""encounter_id"": ""8BCFB6A8-2876-4111-9E3F-602B541FCF62"",
  ""created_at"": ""2023-01-01T00:00:00Z"",
  ""author_auth0_id"": ""F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8"",
  ""author_name"": ""John Doe"",
  ""text"": ""Patient was billed for an MRI.""
}
";

        var serializerOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        var deserializedObject = JsonSerializer.Deserialize<BillingNote>(
            inputJson,
            serializerOptions
        );

        var serializedJson = JsonSerializer.Serialize(deserializedObject, serializerOptions);

        Assert.That(JToken.DeepEquals(JToken.Parse(inputJson), JToken.Parse(serializedJson)));
    }
}
