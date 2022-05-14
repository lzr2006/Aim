using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class TaskDetails : UserControl
    {

        public TaskDetails()
        {
            InitializeComponent();
        }
 
        private void TaskDetails_Load(object sender, EventArgs e)
        {
 
        }
        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(
            new Point[] {
                new Point(0, sender.Height / p_1),
                new Point(sender.Width / p_1, 0),
                new Point(sender.Width - sender.Width / p_1, 0),
                new Point(sender.Width, sender.Height / p_1),
                new Point(sender.Width, sender.Height - sender.Height / p_1),
                new Point(sender.Width - sender.Width / p_1, sender.Height),
                new Point(sender.Width / p_1, sender.Height),
                new Point(0, sender.Height - sender.Height / p_1) },
            (float)p_2);
            sender.Region = new Region(oPath);
        }

        private void TaskDetails_Paint(object sender, PaintEventArgs e)
        {
            Type(this, 15, 0.2);
           //ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Ivory, ButtonBorderStyle.Solid);
        }

        
        
    }
}
