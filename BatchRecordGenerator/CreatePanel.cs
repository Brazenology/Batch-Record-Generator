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

        private void CreatePanel_Load(object sender, EventArgs e)
        {
            //Set all error indicators (asterisks) to the colour red
            asterisk1.ForeColor = System.Drawing.Color.Red;
            asterisk2.ForeColor = System.Drawing.Color.Red;
            asterisk3.ForeColor = System.Drawing.Color.Red;
            asterisk4.ForeColor = System.Drawing.Color.Red;
            asterisk5.ForeColor = System.Drawing.Color.Red;
            asterisk6.ForeColor = System.Drawing.Color.Red;
            asterisk7.ForeColor = System.Drawing.Color.Red;
            asterisk8.ForeColor = System.Drawing.Color.Red;
            asterisk9.ForeColor = System.Drawing.Color.Red;
            asterisk10.ForeColor = System.Drawing.Color.Red;
            asterisk11.ForeColor = System.Drawing.Color.Red;
            asterisk12.ForeColor = System.Drawing.Color.Red;
            asterisk13.ForeColor = System.Drawing.Color.Red;
            asterisk14.ForeColor = System.Drawing.Color.Red;
            asterisk15.ForeColor = System.Drawing.Color.Red;
            asterisk16.ForeColor = System.Drawing.Color.Red;
            asterisk17.ForeColor = System.Drawing.Color.Red;
            asterisk18.ForeColor = System.Drawing.Color.Red;
            asterisk19.ForeColor = System.Drawing.Color.Red;
            asterisk20.ForeColor = System.Drawing.Color.Red;
            asterisk21.ForeColor = System.Drawing.Color.Red;
            asterisk22.ForeColor = System.Drawing.Color.Red;
            asterisk23.ForeColor = System.Drawing.Color.Red;
            asterisk24.ForeColor = System.Drawing.Color.Red;
            asterisk25.ForeColor = System.Drawing.Color.Red;
            asterisk26.ForeColor = System.Drawing.Color.Red;
            asterisk27.ForeColor = System.Drawing.Color.Red;
            asterisk28.ForeColor = System.Drawing.Color.Red;
            asterisk29.ForeColor = System.Drawing.Color.Red;
            asterisk30.ForeColor = System.Drawing.Color.Red;
            asterisk31.ForeColor = System.Drawing.Color.Red;
            asterisk32.ForeColor = System.Drawing.Color.Red;
            asterisk33.ForeColor = System.Drawing.Color.Red;
            asterisk34.ForeColor = System.Drawing.Color.Red;
            asterisk35.ForeColor = System.Drawing.Color.Red;
            asterisk36.ForeColor = System.Drawing.Color.Red;
            asterisk37.ForeColor = System.Drawing.Color.Red;
            asterisk38.ForeColor = System.Drawing.Color.Red;
            asterisk39.ForeColor = System.Drawing.Color.Red;
            asterisk40.ForeColor = System.Drawing.Color.Red;
            asterisk41.ForeColor = System.Drawing.Color.Red;
            asterisk42.ForeColor = System.Drawing.Color.Red;
            asterisk43.ForeColor = System.Drawing.Color.Red;
            asterisk44.ForeColor = System.Drawing.Color.Red;
            asterisk45.ForeColor = System.Drawing.Color.Red;
            asterisk46.ForeColor = System.Drawing.Color.Red;
            asterisk47.ForeColor = System.Drawing.Color.Red;
            asterisk48.ForeColor = System.Drawing.Color.Red;
            asterisk49.ForeColor = System.Drawing.Color.Red;
            asterisk50.ForeColor = System.Drawing.Color.Red;
            asterisk51.ForeColor = System.Drawing.Color.Red;
            asterisk52.ForeColor = System.Drawing.Color.Red;
            asterisk53.ForeColor = System.Drawing.Color.Red;
            asterisk54.ForeColor = System.Drawing.Color.Red;
            asterisk55.ForeColor = System.Drawing.Color.Red;
            asterisk56.ForeColor = System.Drawing.Color.Red;
            asterisk57.ForeColor = System.Drawing.Color.Red;
            asterisk58.ForeColor = System.Drawing.Color.Red;
            asterisk59.ForeColor = System.Drawing.Color.Red;
            asterisk60.ForeColor = System.Drawing.Color.Red;
            asterisk61.ForeColor = System.Drawing.Color.Red;

            //Set Set all error indicators (asterisks) to be invisible on form load
            asterisk1.Visible = false;
            asterisk2.Visible = false;
            asterisk3.Visible = false;
            asterisk4.Visible = false;
            asterisk5.Visible = false;
            asterisk6.Visible = false;
            asterisk7.Visible = false;
            asterisk8.Visible = false;
            asterisk9.Visible = false;
            asterisk10.Visible = false;
            asterisk11.Visible = false;
            asterisk12.Visible = false;
            asterisk13.Visible = false;
            asterisk14.Visible = false;
            asterisk15.Visible = false;
            asterisk16.Visible = false;
            asterisk17.Visible = false;
            asterisk18.Visible = false;
            asterisk19.Visible = false;
            asterisk20.Visible = false;
            asterisk21.Visible = false;
            asterisk22.Visible = false;
            asterisk23.Visible = false;
            asterisk24.Visible = false;
            asterisk25.Visible = false;
            asterisk26.Visible = false;
            asterisk27.Visible = false;
            asterisk28.Visible = false;
            asterisk29.Visible = false;
            asterisk30.Visible = false;
            asterisk31.Visible = false;
            asterisk32.Visible = false;
            asterisk33.Visible = false;
            asterisk34.Visible = false;
            asterisk35.Visible = false;
            asterisk36.Visible = false;
            asterisk37.Visible = false;
            asterisk38.Visible = false;
            asterisk39.Visible = false;
            asterisk40.Visible = false;
            asterisk41.Visible = false;
            asterisk42.Visible = false;
            asterisk43.Visible = false;
            asterisk44.Visible = false;
            asterisk45.Visible = false;
            asterisk46.Visible = false;
            asterisk47.Visible = false;
            asterisk48.Visible = false;
            asterisk49.Visible = false;
            asterisk50.Visible = false;
            asterisk51.Visible = false;
            asterisk52.Visible = false;
            asterisk53.Visible = false;
            asterisk54.Visible = false;
            asterisk55.Visible = false;
            asterisk56.Visible = false;
            asterisk57.Visible = false;
            asterisk58.Visible = false;
            asterisk59.Visible = false;
            asterisk60.Visible = false;
            asterisk61.Visible = false;
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
            if (checkBox1.Checked)
            {
                addFieldCombo1.Enabled = true;
                addFieldCombo2.Enabled = true;
                addFieldCombo3.Enabled = true;
            }
            else
            {
                addFieldCombo1.Enabled = false;
                addFieldCombo2.Enabled = false;
                addFieldCombo3.Enabled = false;
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

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void label122_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label129_Click(object sender, EventArgs e)
        {

        }

        private void label125_Click(object sender, EventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label127_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
