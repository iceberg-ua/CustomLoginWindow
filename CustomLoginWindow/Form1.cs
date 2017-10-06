using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLoginWindow
{
    public partial class Form1 : Form
    {
        CustomMessageBox loginWin = new CustomMessageBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!loginWin.Visible)
                loginWin.Show();
        }
    }
}
