﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public class MenuColorTable : ProfessionalColorTable
    {
        //Fields
        private Color backColor;
        public Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;
        //Constructor
        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(37, 39, 60);
                leftColumnColor = Color.SlateGray;
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }
        // Override
        public override Color ToolStripDropDownBackground => backColor;

        public override Color MenuBorder => borderColor;

        public override Color MenuItemBorder => menuItemSelectedColor;

        public override Color MenuItemSelected => menuItemSelectedColor;

        public override Color ImageMarginGradientBegin => leftColumnColor;

        public override Color ImageMarginGradientMiddle => leftColumnColor;

        public override Color ImageMarginGradientEnd => leftColumnColor;
    }
}
