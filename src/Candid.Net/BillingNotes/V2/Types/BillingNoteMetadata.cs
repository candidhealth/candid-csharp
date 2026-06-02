// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.BillingNotes.V2;

[JsonConverter(typeof(BillingNoteMetadata.JsonConverter))]
[Serializable]
public record BillingNoteMetadata
{
    internal BillingNoteMetadata(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of BillingNoteMetadata with <see cref="BillingNoteMetadata.QueueAdded"/>.
    /// </summary>
    public BillingNoteMetadata(BillingNoteMetadata.QueueAdded value)
    {
        Type = "queue_added";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of BillingNoteMetadata with <see cref="BillingNoteMetadata.QueueMoved"/>.
    /// </summary>
    public BillingNoteMetadata(BillingNoteMetadata.QueueMoved value)
    {
        Type = "queue_moved";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of BillingNoteMetadata with <see cref="BillingNoteMetadata.TaskCreated"/>.
    /// </summary>
    public BillingNoteMetadata(BillingNoteMetadata.TaskCreated value)
    {
        Type = "task_created";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "queue_added"
    /// </summary>
    public bool IsQueueAdded => Type == "queue_added";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "queue_moved"
    /// </summary>
    public bool IsQueueMoved => Type == "queue_moved";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "task_created"
    /// </summary>
    public bool IsTaskCreated => Type == "task_created";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.BillingNotes.V2.QueueAddedMetadata"/> if <see cref="Type"/> is 'queue_added', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'queue_added'.</exception>
    public global::Candid.Net.BillingNotes.V2.QueueAddedMetadata AsQueueAdded() =>
        IsQueueAdded
            ? (global::Candid.Net.BillingNotes.V2.QueueAddedMetadata)Value!
            : throw new global::System.Exception("BillingNoteMetadata.Type is not 'queue_added'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.BillingNotes.V2.QueueMovedMetadata"/> if <see cref="Type"/> is 'queue_moved', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'queue_moved'.</exception>
    public global::Candid.Net.BillingNotes.V2.QueueMovedMetadata AsQueueMoved() =>
        IsQueueMoved
            ? (global::Candid.Net.BillingNotes.V2.QueueMovedMetadata)Value!
            : throw new global::System.Exception("BillingNoteMetadata.Type is not 'queue_moved'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata"/> if <see cref="Type"/> is 'task_created', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'task_created'.</exception>
    public global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata AsTaskCreated() =>
        IsTaskCreated
            ? (global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata)Value!
            : throw new global::System.Exception("BillingNoteMetadata.Type is not 'task_created'");

    public T Match<T>(
        Func<global::Candid.Net.BillingNotes.V2.QueueAddedMetadata, T> onQueueAdded,
        Func<global::Candid.Net.BillingNotes.V2.QueueMovedMetadata, T> onQueueMoved,
        Func<global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata, T> onTaskCreated,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "queue_added" => onQueueAdded(AsQueueAdded()),
            "queue_moved" => onQueueMoved(AsQueueMoved()),
            "task_created" => onTaskCreated(AsTaskCreated()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.BillingNotes.V2.QueueAddedMetadata> onQueueAdded,
        Action<global::Candid.Net.BillingNotes.V2.QueueMovedMetadata> onQueueMoved,
        Action<global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata> onTaskCreated,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "queue_added":
                onQueueAdded(AsQueueAdded());
                break;
            case "queue_moved":
                onQueueMoved(AsQueueMoved());
                break;
            case "task_created":
                onTaskCreated(AsTaskCreated());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.BillingNotes.V2.QueueAddedMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsQueueAdded(out global::Candid.Net.BillingNotes.V2.QueueAddedMetadata? value)
    {
        if (Type == "queue_added")
        {
            value = (global::Candid.Net.BillingNotes.V2.QueueAddedMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.BillingNotes.V2.QueueMovedMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsQueueMoved(out global::Candid.Net.BillingNotes.V2.QueueMovedMetadata? value)
    {
        if (Type == "queue_moved")
        {
            value = (global::Candid.Net.BillingNotes.V2.QueueMovedMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsTaskCreated(out global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata? value)
    {
        if (Type == "task_created")
        {
            value = (global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator BillingNoteMetadata(BillingNoteMetadata.QueueAdded value) =>
        new(value);

    public static implicit operator BillingNoteMetadata(BillingNoteMetadata.QueueMoved value) =>
        new(value);

    public static implicit operator BillingNoteMetadata(BillingNoteMetadata.TaskCreated value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<BillingNoteMetadata>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(BillingNoteMetadata).IsAssignableFrom(typeToConvert);

        public override BillingNoteMetadata Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            var value = discriminator switch
            {
                "queue_added" =>
                    json.Deserialize<global::Candid.Net.BillingNotes.V2.QueueAddedMetadata?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.BillingNotes.V2.QueueAddedMetadata"
                        ),
                "queue_moved" =>
                    json.Deserialize<global::Candid.Net.BillingNotes.V2.QueueMovedMetadata?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.BillingNotes.V2.QueueMovedMetadata"
                        ),
                "task_created" =>
                    json.Deserialize<global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new BillingNoteMetadata(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BillingNoteMetadata value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "queue_added" => JsonSerializer.SerializeToNode(value.Value, options),
                    "queue_moved" => JsonSerializer.SerializeToNode(value.Value, options),
                    "task_created" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for queue_added
    /// </summary>
    [Serializable]
    public struct QueueAdded
    {
        public QueueAdded(global::Candid.Net.BillingNotes.V2.QueueAddedMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.BillingNotes.V2.QueueAddedMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator BillingNoteMetadata.QueueAdded(
            global::Candid.Net.BillingNotes.V2.QueueAddedMetadata value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for queue_moved
    /// </summary>
    [Serializable]
    public struct QueueMoved
    {
        public QueueMoved(global::Candid.Net.BillingNotes.V2.QueueMovedMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.BillingNotes.V2.QueueMovedMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator BillingNoteMetadata.QueueMoved(
            global::Candid.Net.BillingNotes.V2.QueueMovedMetadata value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for task_created
    /// </summary>
    [Serializable]
    public struct TaskCreated
    {
        public TaskCreated(global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator BillingNoteMetadata.TaskCreated(
            global::Candid.Net.BillingNotes.V2.TaskCreatedMetadata value
        ) => new(value);
    }
}
