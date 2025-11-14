using AvalonDock;
using AvalonDock.Layout;
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

namespace avalondocktest
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

        int counter = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            var content = new UserControl();
            content.Name = $"content_{counter}";
            // Regular anchorable for other positions
            var layoutAnchorable = new LayoutAnchorable
            {
                Title = "New Anchorable " + counter.ToString(),
                Content = content,
                CanClose = true,
                CanHide = false,
            };
            var sideGroup = new LayoutAnchorGroup();
            dockManager.Layout.LeftSide.Children.Add(sideGroup);
            sideGroup.Children.Add(layoutAnchorable);
        }
    }
}