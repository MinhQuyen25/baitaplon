using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySuaChuaXeMay;

namespace BaiTapLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            Functions.Connect();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }




        private void phụTùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMPhuTung f = new frmDMPhuTung();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}

