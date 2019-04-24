using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        private ArrayList message = new ArrayList();

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("love");
            message.Add("programming");
            message.Add("so");
            message.Add("much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.ResetText();

            foreach (string s in message)
            {
                lblMessage.Text += s + " ";
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.ResetText();
            message.Reverse();

            foreach (string s in message)
            {
                lblMessage.Text += s + " ";
            }

            message.Reverse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            message.Insert(1, txtSecondPos.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            message.RemoveAt(1);
        }
    }
}
