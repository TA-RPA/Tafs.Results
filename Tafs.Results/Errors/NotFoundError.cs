//
//  NotFoundError.cs
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
    /// An error that is returned when a resource that was searched for could not be found.
    /// </summary>
    /// <param name="Name">The name of the resource.</param>
    /// <param name="Location">The name of the location that was searched.</param>
    [PublicAPI]
    public sealed record class NotFoundError
    (
        string Name,
        string Location
    )
        : ResultError($"Could not locate '{Name}' in '{Location}'");
}
