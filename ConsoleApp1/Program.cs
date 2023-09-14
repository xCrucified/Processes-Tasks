using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Process> a = Process.GetProcesses().ToList();
            foreach (var p in Process.GetProcesses().Select(x => x.ProcessName)) 
            {
                Console.WriteLine(p);
            }
        }
    }
}