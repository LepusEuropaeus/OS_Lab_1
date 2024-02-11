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

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            ChooseFunction.ItemsSource = Functions.FunctionsList;
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (double.TryParse(CalculationTextbox.Text, out double num))
                {
                    AnswerTextbox.Text = Convert.ToString(Functions.Choosing(ChooseFunction.SelectedIndex, num));
                }
                else
                {
                    MessageBox.Show("Необходимо ввести число");
                    CalculationTextbox.Clear();
                }
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("Выберите функцию");
            }
        }

        private void Task2Left_MouseEnter(object sender, MouseEventArgs e)
        {
            Task2Left.Text = "Пришел";
            Task2Right.Text = "Ушел";
        }

        private void Task2Right_MouseEnter(object sender, MouseEventArgs e)
        {
            Task2Left.Text = "Ушел";
            Task2Right.Text = "Пришел";
        }

        private void Task2Left_MouseLeave(object sender, MouseEventArgs e)
        {
            Task2Left.Text = "";
            Task2Right.Text = "";
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Colorful.Background = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(255), (byte)rnd.Next(255), (byte)rnd.Next(255)));
        }
    }
}
