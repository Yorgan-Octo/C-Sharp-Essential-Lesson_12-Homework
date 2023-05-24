using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void CalculatDelegat(float operand1, float operand2);
        public event CalculatDelegat CalculatEvent = null;

        Calculator calculator = null;

        public MainWindow()
        {
            calculator = new Calculator(this);
            InitializeComponent();
        }

        private void CalculationButton_Click(object sender, RoutedEventArgs e)
        {
            //не знаю наскильки це коректно для патенра MVP.
            //можливо порібнобулоб створити 4 євента дял кожної опреації
            //і тут зробити перевірку і інфокати саме конкретній івент

            calculator.Operation();


            CalculatEvent.Invoke(calculator.Operand1, calculator.Operand2);
        }
    }
}
