using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simhopp
{
    public partial class addPlayerToContest : Form
    {
       

        public addPlayerToContest()
        {
            InitializeComponent();
            JumpType jt = new JumpType();
            jt.addjumpCombination();

            if (jt.jumpCombination != null)
            {
                comboJumpComboKey.DataSource = new BindingSource(jt.jumpCombination, null); // Key => null
                comboJumpComboKey.DisplayMember = "Value";
                comboJumpComboKey.ValueMember = "Key";
               // comboJumpComboValue.DataSource = jt.jumpCombination[comboJumpComboKey.SelectedIndex];
                Console.WriteLine(comboJumpComboKey.SelectedItem);
                comboJumpComboValue.DataSource = jt.jumpCombination[int.Parse(comboJumpComboKey.Items[comboJumpComboKey.SelectedIndex].ToString())‌​];
                //    var selectedValues = jt.jumpCombination
                //            .Where(j => j.Key == Convert.ToInt32(comboJumpComboKey.SelectedIndex.Value))
                //            .Select(a => a.Value)
                //            .ToList();
                //
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
            // tävlare 1 = joel,  hopp1 = 1120db, 
            // tävlare 1 = joel, hopp2 = 1120db
            // 1.Joel
            //     1. 112bd = 33p
            //     2. 123cb = 43p
            //     3. 1345d = 21p
            //     4. 1235a = 12p
            // 2.Olle
            //     1. 112bd
            //     2. 123cb
            //     3. 1345d
            //     4. 1235a

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addPlayerToContest_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboJumpComboValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
