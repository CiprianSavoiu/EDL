﻿using System;
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
    /// Interaction logic for JobDetails.xaml
    /// </summary>
    public partial class JobDetails : UserControl
    {

       

        public JobDetails()
        {
            InitializeComponent();
            Mediator.GetInstance().JobChanged += (s, e) =>
            {
                this.DataContext = e.Job;
            };
        }

        
    }
}
