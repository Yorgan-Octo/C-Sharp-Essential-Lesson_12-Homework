using System;
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Task_3
{
    internal class Presenter
    {

        DispatcherTimer time;

        MainWindow view = null;
        Model model = null;

        public Presenter(MainWindow mainWindow)
        {
            view = mainWindow;
            model = new Model();
            time = new DispatcherTimer();
            

            time.Tick += Timer_Tick;
            time.Interval = TimeSpan.FromSeconds(1);

            view.StartTime += Strt;
            view.PauseTime += Pause;
            view.ResetTime += Reset;
        }

        public void Strt(object sender, System.EventArgs e)
        {
            time.Start();
        }


        public void Pause(object sender, System.EventArgs e)
        {
            time.Stop();
        }

        public void Reset(object sender, System.EventArgs e)
        {
            time.Stop();
            model.ResetTime();
            view.TimeBox.Text = model.CurrentTime();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            view.TimeBox.Text = model.CurrentTime();
            model.Sek++;

            if (model.Sek >= 60)
            {
                model.Min++;
                model.Sek = 0;
            }
        }



    }
}
