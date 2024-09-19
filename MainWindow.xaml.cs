using System;
using System.Data;
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

namespace WpfFirstProgram
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainCont.Children) {
                if (el is Button) {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            switch (str)
            {
                case "AC":
                    TextLabel.Text = "";
                    break;
                case "=":
                    string value = new DataTable().Compute(TextLabel.Text, null).ToString();
                    TextLabel.Text = value;
                    break;
                default:
                    TextLabel.Text += str;
                    break;

            }
            /*if (str == "AC")
            {
                TextLabel.Text = "";
            }
            else
            {
                TextLabel.Text += str;
            }*/
        }
        }
}
