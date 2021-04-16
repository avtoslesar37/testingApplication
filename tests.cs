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
    public partial class tests : Form
    {
        public tests()
        {
            InitializeComponent();
        }

        private void tests_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            add_test newForm = new add_test();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main newForm = new main();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
        }
    }
}
