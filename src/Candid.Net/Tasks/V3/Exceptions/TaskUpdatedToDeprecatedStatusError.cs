using Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class TaskUpdatedToDeprecatedStatusError(TaskUpdatedToDeprecatedStatusErrorType body)
    : CandidApiException("TaskUpdatedToDeprecatedStatusError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new TaskUpdatedToDeprecatedStatusErrorType Body => body;
}
