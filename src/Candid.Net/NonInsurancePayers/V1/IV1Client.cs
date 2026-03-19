using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

public partial interface IV1Client
{
    WithRawResponseTask<NonInsurancePayer> CreateAsync(
        CreateNonInsurancePayerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayer> ToggleEnablementAsync(
        string nonInsurancePayerId,
        ToggleNonInsurancePayerEnablementRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayerPage> GetMultiAsync(
        GetMultiNonInsurancePayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns a paginated list of all non-insurance payer categories.
    ///
    /// Non-insurance payer categories are simply strings and are not stored as a
    /// separate object in Candid. They are created when added to at least one
    /// non-insurance payer's `category` field and are deleted when there are no
    /// longer any non-insurance payers that contain them.
    /// </summary>
    WithRawResponseTask<NonInsurancePayerCategoriesPage> GetCategoriesAsync(
        GetNonInsurancePayersCategoriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayer> GetAsync(
        string nonInsurancePayerId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<NonInsurancePayer> UpdateAsync(
        string nonInsurancePayerId,
        NonInsurancePayerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
