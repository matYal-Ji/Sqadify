using SquadsMaster.Models;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Squadify.CustomControls
{
    public partial class ScheduleCard : UserControl
    {
        public ScheduleCard()
        {
            InitializeComponent();

            //Tranlucent BG
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
        }

        public ScheduleCard(Team team1, Team team2) : this()
        {
            //team names
            _team1FlowLayoutPanel.Controls.Add(new Label() { Text = team1.Name, Margin = new Padding(0, 5, 0, 0) });
            _team2FlowLayoutPanel.Controls.Add(new Label() { Text = team2.Name, Margin = new Padding(0, 5, 0, 0) });
        }

        #region "Rounded Corners"
        private int _radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RecreateRegion();
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, _radius, _radius));
            this.Invalidate();
        }

        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            bounds = new Rectangle(bounds.X, bounds.Y, bounds.Width - 1, bounds.Height - 1);
            int diameter = radius;
            GraphicsPath path = new GraphicsPath();
            if (radius == 0)
            {
                path.AddRectangle(bounds);
            }
            else
            {
                // Top left arc
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                // Top right arc
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                // Bottom right arc
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                // Bottom left arc
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
            }
            return path;
        }
        #endregion

        #region "Tranlucent BG"
        public bool drag = false;
        private int m_opacity = 5;
        private int alpha;

        public int Opacity
        {
            get
            {
                if (m_opacity > 100)
                {
                    m_opacity = 100;
                }
                else if (m_opacity < 1)
                {
                    m_opacity = 1;
                }
                return this.m_opacity;
            }
            set
            {
                this.m_opacity = value;
                if (this.Parent != null)
                {
                    Parent.Invalidate(this.Bounds, true);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                // Remove WS_BORDER (0x00800000) and WS_EX_CLIENTEDGE (0x200)
                cp.Style &= ~0x00800000;
                cp.ExStyle &= ~0x200;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new(0, 0, this.Width - 1, this.Height - 1);

            Color frmColor = this.Parent?.BackColor ?? SystemColors.Control;
            Brush bckColor = default!;

            alpha = (m_opacity * 255) / 100;

            if (drag)
            {
                Color dragBckColor = default(Color);

                if (BackColor != Color.Transparent)
                {
                    int Rb = BackColor.R * alpha / 255 + frmColor.R * (255 - alpha) / 255;
                    int Gb = BackColor.G * alpha / 255 + frmColor.G * (255 - alpha) / 255;
                    int Bb = BackColor.B * alpha / 255 + frmColor.B * (255 - alpha) / 255;
                    dragBckColor = Color.FromArgb(Rb, Gb, Bb);
                }
                else
                {
                    dragBckColor = frmColor;
                }

                alpha = 255;
                bckColor = new SolidBrush(Color.FromArgb(alpha, dragBckColor));
            }
            else
            {
                bckColor = new SolidBrush(Color.FromArgb(alpha, this.BackColor));
            }

            if (this.BackColor != Color.Transparent | drag)
            {
                g.FillRectangle(bckColor, bounds);
            }

            var regionPath = GetRoundedRectPath(bounds, _radius);
            if (regionPath != null)
                g.DrawPath(Pens.Black, regionPath);

            bckColor.Dispose();
            g.Dispose();
            base.OnPaint(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                Parent.Invalidate(this.Bounds, true);
            }
            base.OnBackColorChanged(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            this.Invalidate();
            base.OnParentBackColorChanged(e);
        }
        #endregion
    }
}
