using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManagement.Utilities;
namespace CoffeeManagement.Views.CustomControls
{
    public partial class WorkTrackingTopControl : UserControl
    {
        public WorkTrackingTopControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageHelper.CreateYesNoQuestion("Chắc chắn lưu thông tin?")==DialogResult.Yes)
            {
                MessageHelper.CreateMessage("Chức năng đang thiết kế");
            }
        }
    }
}
