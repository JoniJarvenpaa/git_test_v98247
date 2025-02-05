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

namespace GitWPFTeswti
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
            LabelHalp.Background = Brushes.Blue;
            LabelHalp.FontSize = LabelHalp.FontSize * 1.2;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
			LabelHalp.Background = Brushes.Red;
			LabelHalp.FontSize = LabelHalp.FontSize*1.3;
        }
    }
}