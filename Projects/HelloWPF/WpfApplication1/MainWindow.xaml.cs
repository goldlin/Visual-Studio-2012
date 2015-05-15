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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var btn = new Button() {FontWeight = FontWeights.Bold};
            var pnl = new WrapPanel();
            pnl.Children.Add(new TextBlock() {Text = "Multi", Foreground = Brushes.Blue});
            pnl.Children.Add(new TextBlock() { Text = "Color", Foreground = Brushes.Red});
            pnl.Children.Add(new TextBlock() { Text = "Button"});
            btn.Content = pnl;
            PnlMainGrid.Children.Add(btn);
        }
    }
}
