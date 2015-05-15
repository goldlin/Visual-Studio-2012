using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string lastDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = lastDir,
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() != true) return;
            txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            lastDir = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
        }

        private void BtnSaveFile_OnClick(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                InitialDirectory = lastDir,
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() != true) return;
            File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            lastDir = System.IO.Path.GetDirectoryName(saveFileDialog.FileName);
        }

        private void BtnInput_OnClick(object sender, RoutedEventArgs e)
        {
            var inputDialog = new InputDialog("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true)
                lblName.Content = inputDialog.Answer;
        }
    }
}
