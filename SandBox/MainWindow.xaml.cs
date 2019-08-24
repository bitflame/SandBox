using System;
using Microsoft.Win32;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DialogBox;

namespace SandBox
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
        bool needsToBeSaved;

        private void formatMarginsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MarginsDialogBox dlg = new MarginsDialogBox();
            dlg.Owner = this;
            dlg.DocumentMargin = this.documentTextBox.Margin;
            dlg.ShowDialog();
        }

        private void fileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fileSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filePrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fileExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editFindMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FindDialogBox dlg = new FindDialogBox(this.documentTextBox);
            dlg.Owner = this;
            dlg.TextFound += new TextFoundEventHandler(dlg_TextFound);
            dlg.Show();
        }
        private void dlg_TextFound(object sender, EventArgs e)
        {
            // Get the find dialog box that raised the event
            var dlg = (FindDialogBox)sender;

            // Get find results and select found text
            documentTextBox.Select(dlg.Index, dlg.Length);
            documentTextBox.Focus();
        }

        private void formatFontMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void documentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
