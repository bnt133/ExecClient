using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Executive_Application
{
    public partial class Form1 : Form
    {

        UserSettings userSettings;
        ReportData dataSettings;

        public Form1()
        {
            InitializeComponent();

            // Instantiate the UserSettings object
            userSettings = new UserSettings
            {
                // Set the UserSettings variables to the saved data
                staff_name = Properties.Settings.Default.staff_name,
                staff_title = Properties.Settings.Default.staff_title
            };

            userSettings = new ReportData;
            {
                BugID  = 
            }

            // Update the footer label
            lblNameAndTitle.Text = String.Format("{0}\n{1}", userSettings.staff_name, userSettings.staff_title);
        }



        public Form1()
        {
            
        }




        /// <summary>
        /// Invoked when the settings button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings(this.userSettings);
            frmSettings.Show();
            this.Hide();
        }

        /// <summary>
        /// Invoked when the textbox is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.SelectAll();
        }

        /// <summary>
        /// Invoked when the textbox is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        /// <summary>
        /// Invoked when the battlemetrics search button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBattlemetricsSearch_Click(object sender, EventArgs e)
        {
            // Launch battlemetrics and perform a search using the text within the name textbox.
            System.Diagnostics.Process.Start(String.Format("https://www.battlemetrics.com/rcon/players?filter%5Bsearch%5D={0}&filter%5Bservers%5D=false&filter%5BplayerFlags%5D=&sort=score&showServers=true", txtName.Text.Replace(" ", "%20")));
        }

        /// <summary>
        /// Invoked when the player ID lookup button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayerLookupID_Click(object sender, EventArgs e)
        {
            // If the textbox contains only numbers (quantity of one to seven)
            if (Regex.IsMatch(txtName.Text, "^[0-9]{1,7}$"))
            {
                // Open the panel to the desired page
                System.Diagnostics.Process.Start(String.Format("http://158.69.22.152/panel.php?view=player&id={0}", txtName.Text));
            }
            else
            {
                MessageBox.Show("Please enter a valid user ID!", this.Text);
            }
        }

        /// <summary>
        /// Invoked when the forum name lookup button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForumLookup_Click(object sender, EventArgs e)
        {
            // Launch the forums admin control panel with a search for the desired username
            System.Diagnostics.Process.Start(String.Format("https://forums.arma3fisherslife.net/admin.php?users/list&_xfFilter%5Btext%5D={0}", txtName.Text.Replace(" ", "%20")));
        }

        /// <summary>
        /// Invoked when the player report button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayerReport_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "player_report", txtName.Text));
            Program.execNotification.Play();
        }

        /// <summary>
        /// Invoked when the custom message button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomMessage_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "custom_message", txtName.Text, txtDisplay.Text));
            Program.execNotification.Play();
        }

        /// <summary>
        /// Invoked when the compensation accept button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompAccept_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "compensation_accept", txtName.Text, txtDisplay.Text));
            Program.execNotification.Play();
        }

        /// <summary>
        /// Invoked when the compensation deny button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <summary>
        /// Invoked when the QA Process button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQAProcess_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "qa_process", txtName.Text));
            Program.execNotification.Play();
        }

        /// <summary>
        /// Invoked when the QA Closing button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQAClosing_Click(object sender, EventArgs e)
        {
            Program.execNotification.Play();
            string qa_Close1 = Interaction.InputBox("Please enter the Bug Reports Identification Number", "Bug Report Data Entry");
            string qa_Close2 = Interaction.InputBox("Reporting parties total number of reports", "Bug Incentive Program Data");
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "qa_closing", txtName.Text));
        }

        /// <summary>
        /// Invoked when the QA Cannot Replicate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQACannotReplicate_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "qa_cantreplicate", txtName.Text));
            Program.execNotification.Play();
        }

        /// <summary>
        /// Invoked when the QA Fixed button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQAFixed_Click(object sender, EventArgs e)
        {
            Program.execNotification.Play();
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "qa_fixed", txtName.Text));

        }

        private void btnPlayerReportDenied_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TemplateBuilder.get_template(ref this.userSettings, "report_denied", txtName.Text));
            Program.execNotification.Play();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btnForums_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.arma3fisherslife.net/");
            Program.execNotification.Play();
        }

        private void btnWebPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://158.69.22.152/index.php");
            Program.execNotification.Play();
        }

        private void btnExecHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/a3fl-executive-team/");
            Program.execNotification.Play();
        }

        private void btnRulReg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.arma3fisherslife.net/threads/565/");
            Program.execNotification.Play();
        }

        private void btnOperMan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1wgqOF406DNkWcawxq-ETtqZtK1mkdah2gEMKDuY0iDg/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnTrackerStats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1w2BhItmMMFdL7lFkwn3fJHyGsVzkwx0JajYUDRLh-xY/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnStaffRoster_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1_iT1-2ALbSDec5ztZdeTiNz8BCmgCuQsfPhtxnRrSDM/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnRulesTest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1JfB2kZ_tSRCgNoxbgxLuCJTLDSDpwNg4UEbbkNa0Nrc/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnPunish_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1lSa0e7AJN3gjYiWE0OwwHcqN_4UvE_JwEHe8Zg_iTLc/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1904QIG4NdLxQVi-nsvIWhL3QtQB3Jo3MygPwZWbiA-4/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnQAHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1904QIG4NdLxQVi-nsvIWhL3QtQB3Jo3MygPwZWbiA-4/edit?usp=sharing");
            Program.execNotification.Play();
        }

        private void btnTrello_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://trello.com/b/Nzvv5OXq/a3fl-development-wwwa3flife-f");
            Program.execNotification.Play();
        }

        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            Settings frmSettings = new Settings(this.userSettings);
            frmSettings.Show();
            this.Hide();
        }
    }
 }   
