using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.SenoCosTang;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller(textBox1.Text);
            controller.Executar();

            label1.Text = controller.seno.ToString("F");
            label2.Text = controller.cons.ToString("F");
            label3.Text = controller.tang.ToString("F");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
