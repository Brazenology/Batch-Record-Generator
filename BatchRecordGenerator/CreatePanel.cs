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

        /******************Quick Links*************************/
        private void cancelRecordLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            HomePanel home = new HomePanel();
            home.Show();
        }

        private void CreatePanel_Exit(object sender, EventArgs e)
        {
            HomePanel home = new HomePanel();
            home.Show();
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

            }
            else
            {
                extraField1.Enabled = false;
                extraField2.Enabled = false;
                extraField3.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (applyDateCheckBox.Checked)
            {
                labelDatePicker.Enabled = true;
            }
            else
            {
                labelDatePicker.Enabled = false;
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

        private void prettyBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }


        /************************* Navigation buttons (cycles through tabs)*************************/
        private void nextButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void nextButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void nextButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void nextButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void nextButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void nextButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            //Disabled
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void backButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void backButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void backButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void backButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void backButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void labelPreviewButton_Click(object sender, EventArgs e)
        {
            //Sets the labels in the preview pane to be equal to their matching input fields
            if (!string.IsNullOrEmpty(docNumText.Text))
            {
                pDocNumLabel.Text = docNumText.Text;
            }
            else
            {
                pDocNumLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(custNameText.Text))
            {
                pCustNameLabel.Text = custNameText.Text;
            }
            else
            {
                pCustNameLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(partRefCombo.Text))
            {
                pPartRefLabel.Text = partRefCombo.Text;
            }
            else
            {
                pPartRefLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(partDescText.Text))
            {
                pPartDescLabel.Text = partDescText.Text;
            }
            else
            {
                pPartDescLabel.Text = "undefined";
            }
            //
            if (!string.IsNullOrEmpty(revNumText.Text))
            {
                pRevNumLabel.Text = revNumText.Text;
            }
            else
            {
                pRevNumLabel.Text = "undefined";
            }
            //
            if (applyDateCheckBox.Checked)
            {
                pDateLabel.Text = labelDatePicker.Text;
            }
            else
            {
                pDateLabel.Text = "undefined";
            }

            //Makes the information in the preview pane visible
            pDocNumLabel.Visible = true;
            pCustNameLabel.Visible = true;
            pPartRefLabel.Visible = true;
            pPartDescLabel.Visible = true;
            pRevNumLabel.Visible = true;
            pDateLabel.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Makes the information in the preview pane no longer visible 
            pDocNumLabel.Visible = false;
            pCustNameLabel.Visible = false;
            pPartRefLabel.Visible = false;
            pPartDescLabel.Visible = false;
            pRevNumLabel.Visible = false;
            pDateLabel.Visible = false;

            //Resets the fields to undefined
            pDocNumLabel.Text = "undefined";
            pCustNameLabel.Text = "undefined";
            pPartRefLabel.Text = "undefined";
            pPartRefLabel.Text = "undefined";
            pPartDescLabel.Text = "undefined";
            pDateLabel.Text = "undefined";

        }
    }
}
