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

namespace Paczki
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double cena = 0;
            if (pocztowka.IsChecked == true)
            {
                cena = 1;
                zdjecie.Source = new BitmapImage(new Uri("pocztowka.jpg", UriKind.Relative));
                cenaP.Text = "Cena: " + cena + "zł";
            }
            else if (list.IsChecked == true)
            {
                zdjecie.Source = new BitmapImage(new Uri("list.jpg", UriKind.Relative));
                cena = 1.5;
                cenaP.Text = "Cena: " + cena + "zł";
            }
            else if (paczka.IsChecked == true)
            {
                zdjecie.Source = new BitmapImage(new Uri("paczka.jpg", UriKind.Relative));
                cena = 10;
                cenaP.Text = "Cena: " + cena + "zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           

        
            int dlugosc;
            string adresDoreczeniowy = ulicaInumer.Text;
            int kodPocztowy;
            string miasto = miastoP.Text;
            if (!int.TryParse(kodPocztowyP.Text, out kodPocztowy))
            {

                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");

            }
            else
            {
               
                dlugosc = kodPocztowy.ToString().Length;


                if (dlugosc < 5 || dlugosc > 5)
                {
                    MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                }
                else if (dlugosc == 5)
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");

                }
            }
           
        }
    }
}
