using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Notes.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Gets a note by NoteId.
    /// </summary>
    WithRawResponseTask<Note> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Adds a new note.
    /// </summary>
    WithRawResponseTask<Note> CreateAsync(
        MutableNote request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates a note. The path must contain the most recent version to prevent races.
    /// </summary>
    WithRawResponseTask<Note> UpdateAsync(
        string id,
        string version,
        MutableNote request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Sets a note as deactivated.  The path must contain the most recent version to prevent races.
    /// </summary>
    global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
