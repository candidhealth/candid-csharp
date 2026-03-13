using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Tasks.V3;

public partial interface IV3Client
{
    WithRawResponseTask<TaskActions> GetActionsAsync(
        string taskId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<TaskPage> GetMultiAsync(
        GetAllTasksRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Task> GetAsync(
        string taskId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Task> CreateAsync(
        TaskCreateV3 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<Task> UpdateAsync(
        string taskId,
        TaskUpdateV3 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
