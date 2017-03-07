using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        void init()
        {
            timer1.Enabled = true;
        }

        public Form5()
        {
            InitializeComponent();
            init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start1.Visible == true)
            {
                start2.Visible = true;
                start1.Visible = false;
            }
            else if (start1.Visible == false)
            {
                start1.Visible = true;
                start2.Visible = false;
            }
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (ciuperca.Top == 97)
                {
                    ciuperca.Top = 154;
                    ciuperca.Left = 273;
                }
                else
                {
                    ciuperca.Left = 255;
                    ciuperca.Top = 97;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (ciuperca.Top == 97)
                {
                    ciuperca.Top = 154;
                    ciuperca.Left = 273;
                }
                else
                {
                    ciuperca.Left = 255;
                    ciuperca.Top = 97;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (ciuperca.Top == 97)
                {
                    Form1 f1 = new Form1();
                    this.Hide();
                    timer1.Enabled = false;
                    f1.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
