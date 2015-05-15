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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PnlMainGrid.MouseDown += new MouseButtonEventHandler(pnlMainGrid_OnMouseDown);
        }

        private void PnlMainGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this));
        }

        private void pnlMainGrid_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You tapped me at " + e.GetPosition(this));
        }
    }
}
