//
//  BrowserError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using JetBrains.Annotations;
using Remora.Results;

namespace Tafs.Results.Errors
{
    /// <summary>
    /// Represents an error which occurred while interfacing with a browser.
    /// </summary>
    [PublicAPI]
    public sealed record class BrowserError(string Message) : ResultError(Message);
}
