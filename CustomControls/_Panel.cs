using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public class _Panel : System.Windows.Forms.Panel
    {
        private Color color1;
        private Color color2;
        private Color borderColor;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private int color3Transparent = 150;
        private int angle;
        private int borderSize;
        
        public Color StartColor
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }

        public Color EndColor
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }

        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate();}
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public _Panel()
        {
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            e.Graphics.FillRectangle(b, ClientRectangle);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, borderSize, ButtonBorderStyle.Solid, 
                                                                borderColor, borderSize, ButtonBorderStyle.Solid,
                                                                borderColor, borderSize, ButtonBorderStyle.Solid, 
                                                                borderColor, borderSize, ButtonBorderStyle.Solid);
        }
        public override Rectangle DisplayRectangle
        {
            get
            {
                Rectangle rect = base.DisplayRectangle; // Don't worry. It's a value type.
                rect.Inflate(-1, -1); // Exclude 3D border.
                return rect;
            }
        }
    }
}
