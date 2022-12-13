using System.Net.NetworkInformation;

internal class Program
{
  private static void Main(string[] args)
  {
    NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
    Console.WriteLine("Listening for network availability changes. Press any key to exit.");
    Console.ReadLine();
  }

  private static void NetworkChange_NetworkAvailabilityChanged(object? sender, NetworkAvailabilityEventArgs e)
  {
    if (e.IsAvailable)
    {
      Console.WriteLine("Network has become available");
    }
    else
    {
      Console.WriteLine("Network has become unavailable");
    }
  }
}