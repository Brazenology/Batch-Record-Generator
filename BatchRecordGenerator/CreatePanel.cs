using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRecordGenerator
{
    public partial class CreatePanel : Form
    {
        public CreatePanel()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


        /******************Quick Links*************************/
        private void cancelRecordLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            HomePanel home = new HomePanel();
            home.Show();
        }

        private void CreatePanel_Exit(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (addOptionsCheckBox.Checked)
            {
                extraField1.Enabled = true;
                extraField2.Enabled = true;
                extraField3.Enabled = true;
            }
            else
            {
                extraField1.Enabled = false;
                extraField2.Enabled = false;
                extraField3.Enabled = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Draw a red border around the inside of the Panel.
            Rectangle rect = panel3.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Gray, rect);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (addOptionsCheckBox.Checked)
            {
                extraField1.Enabled = true;
                extraField2.Enabled = true;
                extraField3.Enabled = true;
                addOptionsCheckBox2.Checked = true;

            }
            else
            {
                extraField1.Enabled = false;
                extraField2.Enabled = false;
                extraField3.Enabled = false;
                addOptionsCheckBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void addOptionsCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (addOptionsCheckBox2.Checked)
            {
                extraField4.Enabled = true;
                extraField5.Enabled = true;
                extraField6.Enabled = true;
            }
            else
            {
                extraField4.Enabled = false;
                extraField5.Enabled = false;
                extraField6.Enabled = false;
            }
        }

        private void prettyBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (prettyBoxCheckBox.Checked)
            {
                prettyBoxTextBox.Enabled = true;
            }
            else
            {
                prettyBoxTextBox.Enabled = false;
            }
        }

        /************************* Navigation buttons (cycles through tabs)*************************/
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Disabled button
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void label80_Click(object sender, EventArgs e)
        {

        }
    }
}
