using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class Manageress
    {
        public delegate void RegistrationEventHandler();
        public event RegistrationEventHandler Registration;

        public void Queue()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Заведующая: Мест нет! Предлагаю встать в очередь.");
            Registration();
        }
    }
}
