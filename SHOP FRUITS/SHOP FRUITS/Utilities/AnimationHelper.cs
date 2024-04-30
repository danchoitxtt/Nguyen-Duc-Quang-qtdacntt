using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Drawing;


namespace CoffeeManagement.Utilities
{
    public static class AnimationHelper
    {
        private static Timer _timer;
        private static Action _action;
        private static int _slideOffset = 10;
        public enum SlideDirection {
            LeftToRight,
            RightToLeft,
            TopToBottom,
            BottomToTop
        }

        static AnimationHelper()
        {
            _timer = new Timer();
            _timer.Tick += DoAnimate;
        }
        
        private static void DoAnimate(object sender, EventArgs e)
        {
            _action();
        }

        public static void Slide(Control control, int duration, SlideDirection direction)
        {
            if (!control.Visible)
            {
                return;
            }
            _timer.Interval = duration / (control.Width / _slideOffset);
            var originLeft = control.Location.X;
            var temptLocation = control.Location;
            temptLocation.X -= control.Width;

            _action = new Action(delegate
            {
                temptLocation.X += _slideOffset;
                control.Location = temptLocation;
              
                if (temptLocation.X >= originLeft)
                {
                    _timer.Enabled = false;
                    control.Location = new Point(originLeft, control.Location.Y);
                } 

            });

            _timer.Enabled = true;
        }
    }   
}