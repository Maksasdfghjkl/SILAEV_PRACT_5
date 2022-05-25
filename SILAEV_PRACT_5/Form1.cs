using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 17;
        }

        private readonly int[] arr = new int[17];
        private bool check = false;
        private int pos = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10,10);
                if(arr[i] == Convert.ToInt32(textBox1.Text))
                {
                    check = true;
                    pos = i;
                    break;
                }
                progressBar1.PerformStep();
            }
            if (check)
            {
                MessageBox.Show("Элемент найден\n" + pos + " Позиция");
            }
            else
            {
                MessageBox.Show("Элемент не найден");
            }
            check = false;
        }
    }
}
