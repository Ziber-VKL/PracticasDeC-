using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8_NotificationSystem;

public interface INotificationService
{
    void Send(string message);
}
