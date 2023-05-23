using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;

namespace Task_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter controll;

        public MainWindow()
        {
            controll = new Presenter(this);

            InitializeComponent();
        }

        public event EventHandler StartTime = null;
        public event EventHandler PauseTime = null;
        public event EventHandler ResetTime = null;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartTime.Invoke(this, e);
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            PauseTime.Invoke(this, e);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetTime.Invoke(this, e);
        }
    }
}
