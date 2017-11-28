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

namespace EDL.UI
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"Current index {CountriesCmbx.SelectionBoxItem}");
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked me");
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(e.XButton1.ToString());
        }
    }
}
