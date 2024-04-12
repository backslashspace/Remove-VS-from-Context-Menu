using System;

namespace RegRemover
{
    internal static partial class Program
    {
        private static void Main()
        {
            TestKeys();

            if (TodoInfo.RM_Shell && TodoInfo.RM_Background)
            {
                Console.WriteLine("No Visual Studio keys found, nothing to do, exiting..");
                return;
            }

            if (TodoInfo.RM_Shell)
            {
                try
                {
                    TodoInfo.RelativeTopLevelKey.DeleteSubKeyTree("shell\\AnyCode");

                    Console.WriteLine("Successfully removed [shell\\AnyCode]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to removed [shell\\AnyCode]!\nError was {ex.Message}\nExiting..");
                    Environment.Exit(-1);

                }
            }

            if (TodoInfo.RM_Background)
            {
                try
                {
                    TodoInfo.RelativeTopLevelKey.DeleteSubKeyTree("background\\shell\\AnyCode");

                    Console.WriteLine("Successfully removed [background\\shell\\AnyCode]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to removed [background\\shell\\AnyCode]!\nError was {ex.Message}\nExiting..");
                    Environment.Exit(-1);

                }
            }

            Console.WriteLine("Done, exiting");
        }
    }
}