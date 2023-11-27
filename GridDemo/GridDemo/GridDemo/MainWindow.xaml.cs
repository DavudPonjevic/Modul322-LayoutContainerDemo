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

namespace GridDemo
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

        private void buttonRight_Click(object sender, RoutedEventArgs e)
        {
            // Ändere den Inhalt des zweiten Buttons, wenn der erste Button geklickt wird
            buttonLeft.Content = "Der Rechte Btn wurde geklickt!";

            buttonRight.Content = "Rechter Btn";

        }

        private void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            // Ändere den Inhalt des ersten Buttons, wenn der zweite Button geklickt wird
            buttonRight.Content = "Der linke Btn wurde geklickt!";

            // Setze den Inhalt des zweiten Buttons zurück
            buttonLeft.Content = "Linker Btn";
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            // Setze den Inhalt beider Buttons zurück
            buttonRight.Content = "Rechter Btn";
            buttonLeft.Content = "Linker Btn";
        }

    }
}