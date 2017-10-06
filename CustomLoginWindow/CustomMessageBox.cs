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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();

            //label1.BackColor = Color.FromArgb(0, 0, 114, 168);
            textBox1.GotFocus += TextBox1GotFocus;
        }

        private void TextBox1GotFocus(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
