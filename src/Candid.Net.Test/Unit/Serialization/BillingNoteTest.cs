using System.Globalization;
using System.Text.Json;
using Candid.Net.BillingNotes.V2;
using Candid.Net.Core;
using NUnit.Framework;

namespace Candid.Net.Test;

[TestFixture]
public class BillingNoteTest
{
    [global::NUnit.Framework.Test]
    public void TestDeserialization()
    {
        var json = """
            {
              "billing_note_id": "99882EEA-936F-4E71-BC4F-520E4D14E3E2",
              "encounter_id": "8BCFB6A8-2876-4111-9E3F-602B541FCF62",
              "created_at": "2023-01-01T00:00:00Z",
              "author_auth0_id": "F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8",
              "author_name": "John Doe",
              "text": "Patient was billed for an MRI."
            }
            """;
        var expectedObject = new BillingNote
        {
            BillingNoteId = "99882EEA-936F-4E71-BC4F-520E4D14E3E2",
            EncounterId = "8BCFB6A8-2876-4111-9E3F-602B541FCF62",
            CreatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            AuthorAuth0Id = "F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8",
            AuthorName = "John Doe",
            Text = "Patient was billed for an MRI.",
        };
        var deserializedObject = JsonUtils.Deserialize<BillingNote>(json);
        Assert.That(deserializedObject, Is.EqualTo(expectedObject).UsingDefaults());
    }

    [global::NUnit.Framework.Test]
    public void TestSerialization()
    {
        var expectedJson = """
            {
              "billing_note_id": "99882EEA-936F-4E71-BC4F-520E4D14E3E2",
              "encounter_id": "8BCFB6A8-2876-4111-9E3F-602B541FCF62",
              "created_at": "2023-01-01T00:00:00Z",
              "author_auth0_id": "F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8",
              "author_name": "John Doe",
              "text": "Patient was billed for an MRI."
            }
            """;
        var actualObj = new BillingNote
        {
            BillingNoteId = "99882EEA-936F-4E71-BC4F-520E4D14E3E2",
            EncounterId = "8BCFB6A8-2876-4111-9E3F-602B541FCF62",
            CreatedAt = DateTime.Parse(
                "2023-01-01T00:00:00.000Z",
                null,
                DateTimeStyles.AdjustToUniversal
            ),
            AuthorAuth0Id = "F0DE3BF9-F9A1-4FA7-BF6B-28C0B46BADD8",
            AuthorName = "John Doe",
            Text = "Patient was billed for an MRI.",
        };
        var actualElement = JsonUtils.SerializeToElement(actualObj);
        var expectedElement = JsonUtils.Deserialize<JsonElement>(expectedJson);
        Assert.That(actualElement, Is.EqualTo(expectedElement).UsingJsonElementComparer());
    }
}
