using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simhopp
{
    public partial class newCompForm : Form
    {
        public newCompForm()
        {
            InitializeComponent();
        }

        private void newCompForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            addPlayerToContest f3 = new addPlayerToContest();
            f3.ShowDialog(); //open form2
        }
    }
}
