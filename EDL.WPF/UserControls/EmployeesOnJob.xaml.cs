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
    /// Interaction logic for EmployeesOnJob.xaml
    /// </summary>
    public partial class EmployeesOnJob : UserControl
    {
        List<Employee> _Employees = new List<Employee> {
            new Employee { Id = 1, Name = "John Doe", Jobs = new List<Job>
                {
                    new Job { Id = 1, Title = "Area 1 Maintenance" },
                    new Job { Id = 2, Title = "Edge Park" },
                    new Job { Id = 3, Title = "Paint Benches" },
                    new Job { Id = 4, Title = "Build New Wall" }
                }
            },
            new Employee { Id = 2, Name = "Jane Doe", Jobs = new List<Job>
                {
                    new Job { Id = 3, Title = "Paint Benches" },
                    new Job { Id = 4, Title = "Build New Wall" }
                }
            },
            new Employee { Id = 3, Name = "Michelle Davis", Jobs = new List<Job>
                {
                    new Job { Id = 1, Title = "Area 1 Maintenance" },
                    new Job { Id = 3, Title = "Paint Benches" }
                }
            },
        };

        public EmployeesOnJob()
        {
            InitializeComponent();
            Mediator.GetInstance().JobChanged += (s, e) =>
            {
                BindData(e.Job);
            };
        }

        private void BindData(Job job)
        {
            this.DataContext = job;
            var emps = _Employees.Where(e => e.Jobs.Any(j => j.Id == job.Id));
            EmployeeListView.ItemsSource = emps;
        }
    }
}
