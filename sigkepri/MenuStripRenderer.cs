using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigkepri
{
    public class MenuStripRenderer : ToolStripProfessionalRenderer
    {

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBorder(e);
            e.Graphics.FillRectangle(Brushes.Crimson, e.ConnectedArea);
            e.Graphics.DrawRectangle(Pens.Crimson, new Rectangle(0, 1, e.AffectedBounds.Width - 2, e.AffectedBounds.Height - 3));
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if(e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, new Rectangle(Point.Empty, e.Item.Size));
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Crimson, new Rectangle(Point.Empty, e.Item.Size));
            }
        }
    }
}
