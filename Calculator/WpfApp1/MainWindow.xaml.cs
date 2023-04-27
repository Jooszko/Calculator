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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float temp = 0;
        private char znak;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "7";
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "8";
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "9";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "4";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "5";
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "6";
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "1";
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "2";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "3";
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            text1.Content = text1.Content + "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            temp = 0;
            text1.Content = "";
        }

        private void dzielenie_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '/';
            text1.Content = "";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '+';
            text1.Content = "";
        }
        private void mnozenie_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '*';
            text1.Content = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '-';
            text1.Content = "";
        }
        private void kropka_Click(object sender, RoutedEventArgs e)
        {
            //text1.Content = text1.Content + ".";
        }

        private void potenga_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '^';
            text1.Content = "";
            licz_Click(null, null);
        }
        private void potenga2_Click(object sender, RoutedEventArgs e)
        {
            float napis;
            napis = System.Convert.ToInt32(text1.Content);
            temp = napis;
            znak = '`';
            text1.Content = "";
        }


        private void licz_Click(object sender, RoutedEventArgs e)
        {
            float wynik;
            if (znak == '+')
            {
                wynik = temp + System.Convert.ToInt32(text1.Content);
                text1.Content = wynik;
            }else if (znak == '-')
            {
                wynik = temp - System.Convert.ToInt32(text1.Content);
                text1.Content = wynik;
            }
            else if (znak == '*')
            {
                wynik = temp * System.Convert.ToInt32(text1.Content);
                text1.Content = wynik;
            }
            else if (znak == '/')
            {
                wynik = temp / System.Convert.ToInt32(text1.Content);
                text1.Content = wynik;
            }
            else if (znak == '^')
            {
                wynik = temp * temp;
                text1.Content = wynik;
            }
            else if (znak == '`')
            {
                int ile;
                ile = System.Convert.ToInt32(text1.Content)-1;
                wynik = temp;
                for (int i=0; i<ile; i++)
                {
                    wynik = wynik * temp;
                }
                text1.Content = wynik;
            }
            else
            {
                text1.Content = "CO ty robisz?";
            }

        }

       
    }
}
