using Microsoft.Win32;
using System;

namespace RegRemover
{
    internal static partial class Program
    {
        private struct TodoInfo
        {
            internal static RegistryKey RelativeTopLevelKey;

            internal static Boolean RM_Background;
            internal static Boolean RM_Shell;
        }
    }
}