using DoAnPBL3.BLL;
using DoAnPBL3.Models;
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
    public partial class FormNoteInfo : Form
    {
        private readonly int ID_Note;
        public FormNoteInfo(string theme, int ID_Note)
        {
            this.ID_Note = ID_Note;
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(34, 33, 74);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblTitle.ForeColor = Color.Black;
                    tbTitle.DisabledState.ForeColor = Color.Black;
                    tbTitle.DisabledState.BorderColor = Color.Black;
                    tbTitle.DisabledState.PlaceholderForeColor = Color.Black;
                    tbTitle.DisabledState.FillColor = Color.Silver;
                    lblContent.ForeColor = Color.Black;
                    tbContent.DisabledState.ForeColor = Color.Black;
                    tbContent.DisabledState.BorderColor = Color.Black;
                    tbContent.DisabledState.FillColor = Color.Silver;
                    tbContent.DisabledState.PlaceholderForeColor = Color.Black;
                    break;
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNoteInfo_Load(object sender, EventArgs e)
        {
            ShowInfo(BLL_QLGC.Instance.GetNoteByID(ID_Note));
        }

        private void ShowInfo(Note note)
        {
            tbTitle.Text = note.Title;
            tbContent.Text = note.Content;
        }
    }
}
