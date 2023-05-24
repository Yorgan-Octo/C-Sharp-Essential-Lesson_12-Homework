using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Calculator
    {
        MainWindow mainWindow = null;
        MathematicalOperations mathematicalOperations = null;
        public float Operand1
        {
            get
            {

                try
                {
                    return float.Parse(mainWindow.TextBox_Operand1.Text);
                }
                catch (Exception)
                {
                    mainWindow.TextBox_Operand1.Text = "Некоректні данні";

                }

                return float.NaN;


            }
        }
        public float Operand2
        {
            get
            {
                try
                {
                    return float.Parse(mainWindow.TextBox_Operand2.Text);
                }
                catch (Exception)
                {
                    mainWindow.TextBox_Operand2.Text = "Некоректні данні";

                }
                return float.NaN;
            }
        }

        public Calculator(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            mathematicalOperations = new MathematicalOperations();
        }

        public void Operation()
        {
            if (mainWindow.AddRadioButton?.IsChecked == true)
                mainWindow.CalculatEvent += Event_Add;
            else if (mainWindow.SumRadioButton?.IsChecked == true)
                mainWindow.CalculatEvent += Event_Sum;
            else if (mainWindow.MulRadioButton?.IsChecked == true)
                mainWindow.CalculatEvent += Event_Mul;
            else if (mainWindow.DivRadioButton?.IsChecked == true)
                mainWindow.CalculatEvent += Event_Div;
        }

        public void Event_Add(float operand1, float operand2)
        {
            mainWindow.TextBoxResalt.Text = $"{mathematicalOperations.Add(operand1, operand2)}";
        }

        public void Event_Sum(float operand1, float operand2)
        {
            mainWindow.TextBoxResalt.Text = $"{mathematicalOperations.Sum(operand1, operand2)}";
        }

        public void Event_Mul(float operand1, float operand2)
        {
            mainWindow.TextBoxResalt.Text = $"{mathematicalOperations.Mul(operand1, operand2)}";
        }

        public void Event_Div(float operand1, float operand2)
        {
            string resalt;

            if (operand1 == 0 || operand2 == 0)
                resalt = "На нуль дідити не можна";
            else
                resalt = $"{mathematicalOperations.Div(operand1, operand2)}";

            mainWindow.TextBoxResalt.Text = resalt;
        }

    }
}
