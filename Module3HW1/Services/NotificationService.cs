using System;
using Module3HW1.Interfaces;

namespace Module3HW1.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string message)
        {
            Console.Write(message);
        }
    }
}
