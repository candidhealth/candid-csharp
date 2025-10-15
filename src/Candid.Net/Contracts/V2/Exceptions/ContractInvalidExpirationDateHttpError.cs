using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ContractInvalidExpirationDateHttpError(ContractInvalidExpirationDateError body)
    : CandidApiException("ContractInvalidExpirationDateHttpError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ContractInvalidExpirationDateError Body => body;
}
