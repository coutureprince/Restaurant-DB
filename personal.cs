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
    public partial class personal : Form
    {
        public personal()
        {
            InitializeComponent();
        }

        private void personal_Load(object sender, EventArgs e)
        {
            textBoxInfo.Text = File.ReadAllText(@"BD.txt");
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
