using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDL.WPF.Model;

namespace EDL.WPF
{
    public class JobChangedEventArgs : EventArgs
    {
        public Job Job { get; set; }
    }
}
