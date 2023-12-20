// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

#nullable enable

namespace Azure.Core
{
    /// <summary>
    /// Helper for interacting with AppConfig settings and their related Environment variable settings.
    /// Copied from https://github.com/Azure/azure-sdk-for-net/blob/fd271cdcb9fc8a888d917f7e0d43fd6d6f19fcb1/sdk/core/Azure.Core/src/Shared/AppContextSwitchHelper.cs
    /// </summary>
    internal static class AppContextSwitchHelper
    {
        /// <summary>
        /// Determines if either an AppContext switch or its corresponding Environment Variable is set
        /// </summary>
        /// <param name="appContexSwitchName">Name of the AppContext switch.</param>
        /// <param name="environmentVariableName">Name of the Environment variable.</param>
        /// <returns>If the AppContext switch has been set, returns the value of the switch.
        /// If the AppContext switch has not been set, returns the value of the environment variable.
        /// False if neither is set.
        /// </returns>
        public static bool GetConfigValue(string appContexSwitchName, string environmentVariableName)
        {
            // First check for the AppContext switch, giving it priority over the environment variable.
            if (AppContext.TryGetSwitch(appContexSwitchName, out bool value))
            {
                return value;
            }
            // AppContext switch wasn't used. Check the environment variable.
            string? envVar = Environment.GetEnvironmentVariable(environmentVariableName);
            if (envVar != null && (envVar.Equals("true", StringComparison.OrdinalIgnoreCase) || envVar.Equals("1")))
            {
                return true;
            }

            // Default to false.
            return false;
        }
    }
}
