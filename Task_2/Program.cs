using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IModel model = new Model();
            ConsoleView view = new ConsoleView();
            Presenter presenter = new Presenter(view, model);

            // Запуск приложения
            presenter.Start();

            Console.ReadKey();

        }
    }
}
