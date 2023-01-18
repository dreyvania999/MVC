using System;
using System.Windows.Controls;

namespace WpfApp3
{
    internal class Model
    {
        private static readonly string[] Sign = new string[] { "+", "-", "/", "x" };

        public static TextBlock ArifmeticSign;
        public static TextBox ResultText;

        public static int Operation
        {
            set => ArifmeticSign.Text = Sign[value];
        }

        public static void SetResult(int index, string FirstOperand, string SecondOperand)
        {
            try
            {
                double one = Convert.ToDouble(FirstOperand);
                double two = Convert.ToDouble(SecondOperand);

                ResultText.Text = index == 2 && two == 0 ? "На ноль разделить нельзя" : index switch
                {
                    0 => (one + two).ToString(),
                    1 => (one - two).ToString(),
                    2 => (one / two).ToString(),
                    3 => (one * two).ToString(),
                    _ => "Ошибка",
                }; 
            }
            catch
            {
                ResultText.Text = "Проверьте введенные данные";
                return;
            }
        }

       
    }
}