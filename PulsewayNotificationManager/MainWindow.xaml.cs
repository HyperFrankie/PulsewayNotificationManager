using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PulsewayNotificationManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private TextBox _txtBox;
        
        
        public MainWindow()
        {
            InitializeComponent();
            DoStuff();
        }

        private void DoStuff()
        {
            Background = new SolidColorBrush(Colors.Gray);
            _txtBox = new TextBox();
            _txtBox.Text = "txtBoxTest";
            _txtBox.HorizontalAlignment = HorizontalAlignment.Center;
            _txtBox.VerticalAlignment = VerticalAlignment.Center;
            _txtBox.Visibility = Visibility.Visible;
            AddVisualChild(_txtBox);
        }
    }
}