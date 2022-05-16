using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormQLKH : Form
    {
        public FormQLKH(string theme)
        {
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnTKKH.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblKHN.ForeColor = Color.White;
                    lblKHNu.ForeColor = Color.White;
                    lblTSKH.ForeColor = Color.White;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKKH.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKKH.ForeColor = Color.Silver;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);

                    break;

                case "Dark":
                    btnTKKH.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblKHN.ForeColor = Color.White;
                    lblKHNu.ForeColor = Color.White;
                    lblTSKH.ForeColor = Color.White;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKKH.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKKH.ForeColor = Color.Silver;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    break;

                case "Light":
                    btnTKKH.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblKHN.ForeColor = Color.Black;
                    lblKHNu.ForeColor = Color.Black;
                    lblTSKH.ForeColor = Color.Black;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKKH.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKKH.ForeColor = Color.DimGray;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);

                    break;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void btnTTKH_MouseEnter(object sender, EventArgs e)
        {
            btnTTKH.BackColor = RGBColors.color4;

        }

        private void btnTKKH_MouseEnter(object sender, EventArgs e)
        {
            btnTKKH.BackColor = RGBColors.color4;
        }

        private void btnHDKH_MouseEnter(object sender, EventArgs e)
        {
            btnHDKH.BackColor = RGBColors.color4;
        }

        private void btnTTKH_MouseLeave(object sender, EventArgs e)
        {
            btnTTKH.BackColor = Color.RoyalBlue;
        }

        private void btnTKKH_MouseLeave(object sender, EventArgs e)
        {
            btnTKKH.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnHDKH_MouseLeave(object sender, EventArgs e)
        {
            btnHDKH.BackColor = Color.RoyalBlue;
        }
    }
}