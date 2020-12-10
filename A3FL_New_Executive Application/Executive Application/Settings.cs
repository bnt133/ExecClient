using Executive_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executive_Application
{
    public partial class Settings : Form
    {

        UserSettings userSettings;

        public Settings(UserSettings userSettings)
        {
            InitializeComponent();

            this.userSettings = userSettings;

            // Load the saved staff name
            txtName.Text = userSettings.staff_name;

            // Load the saved staff title
            switch (userSettings.staff_title)
            {
                case "Executive Team":
                    radExecutive.Checked = true;
                    break;

                case "Executive Team Supervisor":
                    radExecutiveTS.Checked = true;
                    break;

                case "Chiefs Commission":
                    radChief.Checked = true;
                    break;

                case "Sub-Director":
                    radSubDirector.Checked = true;
                    break;

                case "Community Director":
                    radDirector.Checked = true;
                    break;

                default:
                    radCustom.Checked = true;
                    txtTitle.Text = userSettings.staff_title;
                    break;
            }
        }

        /// <summary>
        /// Event handler for when the text in the textbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure only letters, spaces or backspaces are entered
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event handler for when the text in the textbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Make sure only letters, spaces or backspaces are entered
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsSeparator(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event handler for when the save button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string new_staff_title = "";

            if (radExecutive.Checked)
            {
                new_staff_title = "Executive Team";
            }
            else if (radExecutiveTS.Checked)
            {
                new_staff_title = "Executive Team Supervisor";
            }
            else if (radChief.Checked)
            {
                new_staff_title = "Chiefs Commission";
            }
            else if (radSubDirector.Checked)
            {
                new_staff_title = "Sub-Director";
            }
            else if (radDirector.Checked)
            {
                new_staff_title = "Community Director";
            }
            else
            {
                new_staff_title = txtTitle.Text;
            }

            userSettings.update_settings(txtName.Text, new_staff_title);
            Program.execNotification.Play();
            MessageBox.Show("Settings saved!", this.Text);

            // Create a new instance of the main form
            Form1 form1 = new Form1();

            // Display the main form
            form1.Show();

            // Close this form
            this.Hide();
        }

        /// <summary>
        /// Event handler for when the reset button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Update the UI back to the default values
            txtName.Text = "Your Name";
            radExecutive.Checked = true;

            userSettings.update_settings(txtName.Text, "Executive Team");
            Program.execNotification.Play();
            MessageBox.Show("Settings reset!", this.Text);
        }

        /// <summary>
        /// Event handler for when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create a new instance of the main form
            Form1 form1 = new Form1();

            // Display the main form
            form1.Show();
        }
    }
}


