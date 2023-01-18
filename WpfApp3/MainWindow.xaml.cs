using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.ArifmeticSign = ArifmeticOperation;
            Model.ResultText = Result;

            CBOperation.SelectedIndex = 0;
        }


        private void CalculateResult_Click(object sender, RoutedEventArgs e)
        {
            Model.SetResult(CBOperation.SelectedIndex, FirstOperand.Text, SecondOperand.Text);
        }

        private void CBOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Operation = CBOperation.SelectedIndex;
        }
    }
}