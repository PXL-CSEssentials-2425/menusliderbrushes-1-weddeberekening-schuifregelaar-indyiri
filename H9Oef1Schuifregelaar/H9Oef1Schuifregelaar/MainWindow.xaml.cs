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

namespace H9Oef1Schuifregelaar
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

        private void salarySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double taxes;
            string formattedTaxes;

            if (salarySlider.Value >= 0 && salarySlider.Value < 10000)
            {
                taxes = 0;
                taxesLabel.Content = $"€ {taxes}";
            }
            else if (salarySlider.Value >= 10000 && salarySlider.Value < 50000)
            {
                taxes = Math.Round(salarySlider.Value * 0.2, 2);
                formattedTaxes = taxes.ToString("N2");                          // dit zet het in de notatie met een punt tussen elke 3 nullen, en gaat tot twee cijfers na de komma
                taxesLabel.Content = $"€ {formattedTaxes}";
            }
            else if (salarySlider.Value >= 50000 && salarySlider.Value <= 100000)
            {
                taxes = Math.Round(salarySlider.Value * 0.9,2);
                formattedTaxes = taxes.ToString("N2");
                taxesLabel.Content = $"€ {formattedTaxes}";
            }
        }
    }
}