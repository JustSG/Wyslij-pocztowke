using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pocztowka
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            List<string> list = new List<string>();
            list.Add("koperta.png");
            list.Add("koperta1.png");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pocztowka_radio.IsChecked == true)
            {
                cena_textblock.Text = "Cena: 1zł";
                image.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
            }
            else if (list_radio.IsChecked == true)
            {
                cena_textblock.Text = "Cena: 1,5zł";
                image.Source = new BitmapImage(new Uri("koperta.png", UriKind.Relative));
            }
            else if (paczka_radio.IsChecked == true)
            {
                cena_textblock.Text = "Cena: 10zł";
                image.Source = new BitmapImage(new Uri("paczka.jpg", UriKind.Relative));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int kodPocztowy;
            string kodPocztowyString;
            if (int.TryParse(kodP_textbox.Text, out kodPocztowy))
            {
                kodPocztowyString = kodP_textbox.Text;
                if (kodPocztowyString.Length == 5)
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone", "Sukces.", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym", "Błąd. James Błąd.", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr", "Błąd. James Błąd.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}