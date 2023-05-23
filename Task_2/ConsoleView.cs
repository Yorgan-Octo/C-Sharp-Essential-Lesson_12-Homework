using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class ConsoleView : IView
    {
        public event Action<string> DataRequested;

        public void ShowData(string data)
        {
            Console.WriteLine(data);
        }

        public void RequestData()
        {
            DataRequested?.Invoke("Запрос данных");
        }
    }
}