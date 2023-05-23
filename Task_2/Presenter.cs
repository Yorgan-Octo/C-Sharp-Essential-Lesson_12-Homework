using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class Presenter
    {
        private readonly ConsoleView view;
        private readonly IModel model;

        public Presenter(ConsoleView view, IModel model)
        {
            this.view = view;
            this.model = model;

            // Привязка обработчиков событий представления к методам презентера
            view.DataRequested += HandleDataRequested;
        }

        public void Start()
        {
            // Инициализация и настройка представления и модели
            view.RequestData();
        }

        private void HandleDataRequested(string request)
        {
            // Обработка запроса данных
            string data = model.GetData();
            view.ShowData(data);

        }
    }
}