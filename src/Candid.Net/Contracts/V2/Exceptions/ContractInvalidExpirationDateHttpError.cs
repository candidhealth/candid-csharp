using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts.V2;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class ContractInvalidExpirationDateHttpError(ContractInvalidExpirationDateError body)
    : CandidApiException("ContractInvalidExpirationDateHttpError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new ContractInvalidExpirationDateError Body => body;
}
