using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAD_CHECK
{
    public partial class TEST : UserControl
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void HILO1_Click(object sender, EventArgs e)
        {
            if (READ1.Text == "READ")
            {
                if (HILO1.Text == "HIGH")
                    HILO1.Text = "LOW";
                else
                    HILO1.Text = "HIGH";
            }
        }

        private void HILO2_Click(object sender, EventArgs e)
        {
            if (READ2.Text == "READ")
            {
                if (HILO2.Text == "HIGH")
                    HILO2.Text = "LOW";
                else
                    HILO2.Text = "HIGH";
            }
        }

        private void HILO3_Click(object sender, EventArgs e)
        {
            if (READ3.Text == "READ")
            {
                if (HILO3.Text == "HIGH")
                    HILO3.Text = "LOW";
                else
                    HILO3.Text = "HIGH";
            }
        }

        private void HILO4_Click(object sender, EventArgs e)
        {
            if (READ4.Text == "READ")
            {
                if (HILO4.Text == "HIGH")
                    HILO4.Text = "LOW";
                else
                    HILO4.Text = "HIGH";
            }
        }

        //Maybe After You Write/ Recieve it toggles off
        private void button1_Click(object sender, EventArgs e)
        {
            if (READ1.Text == "READ")
            {
                READ1.Text = "WRITE";
                HILO1.Text = "HIGH";
            }
            else
                READ1.Text = "READ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (READ2.Text == "READ")
            {
                READ2.Text = "WRITE";
                HILO2.Text = "HIGH";
            }
            else
                READ2.Text = "READ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (READ3.Text == "READ")
            {
                READ3.Text = "WRITE";
                HILO3.Text = "HIGH";
            }
            else
                READ3.Text = "READ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (READ4.Text == "READ")
            {
                READ4.Text = "WRITE";
                HILO4.Text = "HIGH";
            }
            else
                READ4.Text = "READ";
        }

        private void WRITE1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
