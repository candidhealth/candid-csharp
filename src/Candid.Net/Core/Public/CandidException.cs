using System;

#nullable enable

namespace Candid.Net.Core;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class CandidException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
