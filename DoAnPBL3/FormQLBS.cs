﻿using System;
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
    public partial class FormQLBS : Form
    {
        public FormQLBS(string theme)
        {
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnTKS.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblSSTA.ForeColor = Color.White;
                    lblSSTV.ForeColor = Color.White;
                    lblTSSDB.ForeColor = Color.White;
                    xuiSegmentBS.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentBS.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentBS.SegmentColor = Color.DarkMagenta;
                    xuiSegmentBS.SegmentInactiveTextColor = Color.White;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKS.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKS.ForeColor = Color.Silver;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    break;
                case "Dark":
                    btnTKS.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblSSTA.ForeColor = Color.White;
                    lblSSTV.ForeColor = Color.White;
                    lblTSSDB.ForeColor = Color.White;
                    xuiSegmentBS.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentBS.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentBS.SegmentColor = Color.DarkMagenta;
                    xuiSegmentBS.SegmentInactiveTextColor = Color.White;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKS.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKS.ForeColor = Color.Silver;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    break;
                case "Light":
                    btnTKS.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label2.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    lblSSTA.ForeColor = Color.Black;
                    lblSSTV.ForeColor = Color.Black;
                    lblTSSDB.ForeColor = Color.Black;
                    xuiSegmentBS.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentBS.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentBS.SegmentColor = Color.DarkMagenta;
                    xuiSegmentBS.SegmentInactiveTextColor = Color.White;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKS.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKS.ForeColor = Color.DimGray;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
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

        private void btnTKS_MouseEnter(object sender, EventArgs e)
        {
            btnTKS.BackColor = RGBColors.color4;
        }

        private void btnSXS_MouseEnter(object sender, EventArgs e)
        {
            btnSXS.BackColor = RGBColors.color4;
        }

        private void btnHDTN_MouseEnter(object sender, EventArgs e)
        {
            btnHDTN.BackColor = RGBColors.color4;
        }

        private void btnTKS_MouseLeave(object sender, EventArgs e)
        {
            btnTKS.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnSXS_MouseLeave(object sender, EventArgs e)
        {
            btnSXS.BackColor = Color.RoyalBlue;
        }

        private void btnHDTN_MouseLeave(object sender, EventArgs e)
        {
            btnHDTN.BackColor = Color.RoyalBlue;
        }

        private void btnSXS_Click(object sender, EventArgs e)
        {
            rjDropDownMenuSXS.Show(btnSXS, new Point(0, btnSXS.Height));
        }

        private void FormQLBS_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books.Join(
                    context.Languages,
                    book => book.ID_Language,
                    lang => lang.ID_Language,
                    (book, lang) => new
                    {
                        book.ID_Book,
                        book.NameBook,
                        lang.NameLanguage,
                        book.Quantity,
                        book.Price
                    })
                    .ToList();
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                dgvQLBS.DataSource = listBooks;
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
            }
            rjDropDownMenuSXS.IsMainMenu = false;
        }

        private void xuiSegmentBS_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                // Tất cả
                if (xuiSegmentBS.SelectedIndex == 0)
                {
                    FormQLBS_Load(sender, e);
                }
                // Sách tiếng việt
                else if (xuiSegmentBS.SelectedIndex == 1)
                {
                    dgvQLBS.DataSource = context.Books.Join(
                        context.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new
                        {
                            book.ID_Book,
                            book.NameBook,
                            lang.NameLanguage,
                            book.Quantity,
                            book.Price
                        })
                        .Where(lang => lang.NameLanguage == "Tiếng Việt")
                        .ToList();
                }
                // Sách tiếng anh
                else
                {
                    dgvQLBS.DataSource = context.Books.Join(
                        context.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new
                        {
                            book.ID_Book,
                            book.NameBook,
                            lang.NameLanguage,
                            book.Quantity,
                            book.Price
                        })
                        .Where(lang => lang.NameLanguage == "Tiếng Anh")
                        .ToList();
                }
            }
        }
    }
}