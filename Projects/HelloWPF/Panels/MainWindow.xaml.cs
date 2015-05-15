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

namespace Panels
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

        private void WrapPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            var wrapPanelWnd = new WrapPanel();
            wrapPanelWnd.Show();
        }

        private void StackPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            var stackPanelWnd = new StackPanel();
            stackPanelWnd.Show();
        }

        private void DockPanelButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dockPanelWnd = new DockPanel();
            dockPanelWnd.Show();
        }

        private void GridSimpleButton_OnClick(object sender, RoutedEventArgs e)
        {
            var gridWnd = new Grid();
            gridWnd.Show();
        }

        private void GridSplitterButton_OnClick(object sender, RoutedEventArgs e)
        {
            var gridSplitterWnd = new GridSplitter();
            gridSplitterWnd.Show();
        }

        private void GridContactFormButton_OnClick(object sender, RoutedEventArgs e)
        {
            var gridContactFormWnd = new GridContactForm();
            gridContactFormWnd.Show();
        }
    }
}
