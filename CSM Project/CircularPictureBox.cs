using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSM_Project
{
    class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(gp);
            base.OnPaint(pevent);
        }
    }
}
