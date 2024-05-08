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

namespace dotXO
{
    public partial class MainWindow : Window{

        private string value = "x";
        private int xWings = 0;
        private int oWings = 0;

        private static readonly Brush DEFAULTBRUSH = new SolidColorBrush(Color.FromArgb(255, 142,142,166));

        public MainWindow(){
            InitializeComponent();
        }

        private void MenuRestart_Click(object sender, RoutedEventArgs e) { 
            
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Foreground = Brushes.Black;
            bt.IsEnabled = false;

            if (IsWin(btA1, btA2, btA3)) GameOver(btA1.Content.ToString());
        }

        private void GameOver(string v) { 
            throw new NotImplementedException();
        }

        private bool IsWin(Button bt1, Button bt2, Button bt3) =>
            !bt1.IsEnabled && bt1.Content == bt2.Content && bt1.Content == bt3.Content;

        private void bt_Enter(object sender, RoutedEventArgs e)
        {

        }

        private void bt_Leave(object sender, RoutedEventArgs e)
        {

        }
    }
}