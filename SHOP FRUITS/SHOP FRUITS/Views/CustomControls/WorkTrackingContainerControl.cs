using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Views.CustomControls;
namespace CoffeeManagement.Views.CustomControls
{
    public partial class WorkTrackingContainerControl : UserControl
    {
        public WorkTrackingContainerControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; //Me
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingTopControl workTrackingDetailControl = new WorkTrackingTopControl();
            this.splitContainer1.Panel1.Controls.Add(workTrackingDetailControl);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            WorkTrackingBottomControl wordTrackingListControl = new WorkTrackingBottomControl();
            this.splitContainer1.Panel2.Controls.Add(wordTrackingListControl);
        }
    }
}
