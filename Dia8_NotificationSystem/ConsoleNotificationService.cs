using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8_NotificationSystem;

public class ConsoleNotificationService : INotificationService
{
    public void Send(string message)
    {
      Console.WriteLine("============");
      Console.WriteLine("NOTIFICATION");
      Console.WriteLine(message);
      Console.WriteLine();
      Console.WriteLine("============");  
    }
}
