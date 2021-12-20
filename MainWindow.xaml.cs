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

namespace OSKruh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void hodnota_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void volba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void click_Click(object sender, RoutedEventArgs e)
        {
            double hodnotaText = Convert.ToDouble(hodnota.Text);
            if (hodnotaText <= 0)
            {
                Error.Text = "Zadat číslo větší jak 0";
            }
                    
            else if (volba.Text == "r")
            {
                double x = (hodnotaText * 2 * Math.PI);
                double y = (hodnotaText * hodnotaText * Math.PI); ;
                obvod.Text = Math.Round(x,2).ToString();
                obsah.Text = Math.Round(y,2).ToString();
            }
            else if (volba.Text == "d")
            {
                double x = (hodnotaText  * Math.PI);
                double y = ((Math.PI * hodnotaText * hodnotaText) / 4);
                obvod.Text = Math.Round(x, 2).ToString();
                obsah.Text = Math.Round(y, 2).ToString();
            }
            
        }

        
    }
}
