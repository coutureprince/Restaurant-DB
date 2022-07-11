using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrshovayaa
{
    public partial class zakaz : Form
    {
        public zakaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 forma= new Form1();
            forma.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personal pers = new personal();
            pers.Show();
            this.Hide();
        }

        private void zakaz_Load(object sender, EventArgs e)
        {

        }
    }
}
