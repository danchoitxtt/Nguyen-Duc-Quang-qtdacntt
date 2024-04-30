using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.Views.CustomControls
{
    public partial class WorkTrackingBottomControl : UserControl
    {
        public WorkTrackingBottomControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }
    }
}
