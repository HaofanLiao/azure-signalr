// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.SignalR.Diagnostic;

internal class DiagnosticProperty
{
    /// <summary>The namespace used for the SignalR diagnostic scope.</summary>
    public const string DiagnosticNamespace = "Microsoft.Azure.SignalR";
    
    /// <summary>The namespace used for the Azure Resource Manager provider namespace.</summary>
    public const string ResourceProviderNamespace = "Microsoft.SignalR";
    
    /// <summary>The value which identifies the SignalR diagnostics context.</summary>
    public const string SignalRServiceContext = "signalr";
    
}