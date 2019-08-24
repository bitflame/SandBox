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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            String caption = "Word Process";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show("Do you want to save changes? ", caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.None:
                    break;
                case MessageBoxResult.OK:
                    break;
                case MessageBoxResult.Cancel:
                    break;
                case MessageBoxResult.Yes:
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }

        private void okButtonClick(object sender, RoutedEventArgs e)
        {

        }


    }
}
