// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.DotNet.AzureDevOpsTimeline;

public class KustoTimelineTelemetryOptions
{
    public string IngestConnectionString { get; set; }
    public string QueryConnectionString { get; set; }
    public string Database { get; set; }
}
