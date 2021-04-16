using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tests newForm = new tests();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            spravka newForm = new spravka();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themes newForm = new themes();
            newForm.Show();
        }
    }
}
