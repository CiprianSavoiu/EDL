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
using EDL.WPF.Model;

namespace EDL.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Jobs.xaml
    /// </summary>
    public partial class Jobs : UserControl
    {
        List<Job> _Jobs = new List<Job>
        {
            new Job { Id = 1, Title = "Area 1 Maintenance", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1) },
            new Job { Id = 2, Title = "Edge Park", StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(5)  },
            new Job { Id = 3, Title = "Paint Benches", StartDate = DateTime.Now.AddDays(4), EndDate = DateTime.Now.AddDays(10)  },
            new Job { Id = 4, Title = "Build New Wall", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(15)  }
        };


        public Jobs()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            JobsComboBox.ItemsSource = _Jobs;
        }

        private void JobsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
