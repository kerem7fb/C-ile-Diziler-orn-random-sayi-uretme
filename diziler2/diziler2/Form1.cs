using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rast.Next(0, 100);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }
    }
}
