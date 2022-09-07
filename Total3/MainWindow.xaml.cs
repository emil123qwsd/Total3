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

namespace Total3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = (string)((Button)e.OriginalSource).Content;

                if (str == "AC")
                    textLabel.Text = "";
                else if (str == "=")
                {
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                }
                else
                    textLabel.Text += str;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = MainRoot * MainRoot;
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = MainRoot * MainRoot * MainRoot;
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = Math.Log(MainRoot, Math.E); ;
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = Math.Sqrt(MainRoot);
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = Math.Sin(MainRoot * Math.PI / 180);
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = Math.Cos(MainRoot * Math.PI / 180);
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble = Math.Tan(MainRoot * Math.PI / 180);
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double MainRoot = Convert.ToDouble(textLabel.Text);
            double resDouble =1/Math.Tan(MainRoot * Math.PI / 180);
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            double resDouble =  Math.PI;
            textLabel.Text = resDouble.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            double resDouble = 2.718;
            textLabel.Text = resDouble.ToString();
        }
    }
}
