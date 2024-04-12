using Microsoft.Win32;
using System;

namespace RegRemover
{
    internal static partial class Program
    {
        private static void TestKeys()
        {
            try
            {
                TodoInfo.RelativeTopLevelKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Classes\\Directory", true);
            }
            catch
            {
                Console.WriteLine("Unable to open key: HKLM:SOFTWARE\\Classes\\Directory");

                Console.Write("Press return to exit: ");
                Console.ReadLine();

                Environment.Exit(-1);
                throw;
            }

            try
            {
                RegistryKey tempKey = TodoInfo.RelativeTopLevelKey.OpenSubKey("background\\shell\\AnyCode", false);

                if (tempKey == null)
                {
                    TodoInfo.RM_Background = false;
                }
                else
                {
                    TodoInfo.RM_Background = true;
                }

                tempKey.Close();
            }
            catch
            {
                TodoInfo.RM_Background = false;
            }

            try
            {
                RegistryKey tempKey = TodoInfo.RelativeTopLevelKey.OpenSubKey("shell\\AnyCode", false);

                if (tempKey == null)
                {
                    TodoInfo.RM_Shell = false;
                }
                else
                {
                    TodoInfo.RM_Shell = true;
                }

                tempKey.Close();
            }
            catch
            {
                TodoInfo.RM_Shell = false;
            }
        }
    }
}