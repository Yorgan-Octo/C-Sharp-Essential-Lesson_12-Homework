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

namespace Task_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        EventHandler myEvent = null;

        public event EventHandler MyEvent
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);
        }
    }
}
