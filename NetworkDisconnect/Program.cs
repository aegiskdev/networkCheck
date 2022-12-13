using System.Diagnostics;

internal class Program
{
  private static void Main(string[] args)
  {
    while (true)
    {
      Enable("Wi-Fi");
      Console.WriteLine("Local connection ENABLED. Press key to DISABLE.");
      Console.ReadLine();
      Disable("Wi-Fi");
      Console.WriteLine("Local connection DISABLED. Press key to ENABLE.");
      Console.ReadLine();
    }
  }

  private static void Enable(string interfaceName)
  {
    var psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
    var p = new Process { StartInfo = psi };
    p.Start();
  }

  private static void Disable(string interfaceName)
  {
    var psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");
    var p = new Process { StartInfo = psi };
    p.Start();
  }
}
