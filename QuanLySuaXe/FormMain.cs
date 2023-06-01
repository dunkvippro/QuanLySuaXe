using QuanLySuaXe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuaXe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private Form curForm;
        private void OpenChildForm(Form child)
        {
            if (this.curForm != null) {
                this.curForm.Close();
            }

            curForm = child;
            child.TopLevel = false;
            child.FormBorderStyle  = FormBorderStyle.None;
            child.Dock  =DockStyle.Fill;
            panel_body.Controls.Add(child);
            panel_body.Tag  = child;
            child.BringToFront();
            child.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUserLogin());

        }
    }
}
