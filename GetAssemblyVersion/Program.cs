using System;
using System.Reflection;

namespace GetAssemblyVersion
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException("One Assembly File Path is needed.");
                }

                string path = args[0];
                Console.WriteLine(Assembly.LoadFrom(path).GetName().Version);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
