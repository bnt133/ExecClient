using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executive_Application
{
    public class UserSettings
    {
        // Basic user settings which we will store
        public string staff_name = "Your Name";
        public string staff_title = "Executive Team";

        /// <summary>
        /// Update the users current settings
        /// </summary>
        /// <param name="new_staff_name">The new name which will be set</param>
        /// <param name="new_staff_title">The new title which will be set</param>
        public void update_settings(string new_staff_name = "Your Name", string new_staff_title = "Executive Team")
        {
            // Update the class data
            this.staff_name = new_staff_name;
            this.staff_title = new_staff_title;

            // Update the stored settings to their new values
            Properties.Settings.Default.staff_name = new_staff_name;
            Properties.Settings.Default.staff_title = new_staff_title;

            // Save the new values
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Generate the users signature to go at the bottom of their message.
        /// </summary>
        /// <param name="custom_title">For messages requiring a custom signature title, supply it here</param>
        /// <returns>The generated signature string</returns>
        public string get_signature(string custom_title = "")
        {
            string name_colour = "";
            string title_colour = "";

            switch (this.staff_title)
            {
                case "Executive Team":
                    name_colour = "#c66ae6";
                    title_colour = "#a950c7";
                    break;

                case "Executive Team Supervisor":
                    name_colour = "#47dff7";
                    title_colour = "#1E90FF";
                    break;

                case "Chief's Commission":
                    name_colour = "#47c2f7";
                    title_colour = "#1E90FF";
                    break;

                case "Sub-Director":
                    name_colour = "#fba026";
                    title_colour = "#fba026";
                    break;

                case "Community Director":
                    name_colour = "#ffffff";
                    title_colour = "#fac51c";
                    break;

                default:
                    name_colour = "#47c2f7";
                    title_colour = "#1E90FF";
                    break;
            }

            string signature_name = String.Format("[COLOR={0}]{1}[/COLOR]", name_colour, this.staff_name);
            string signature_title = (String.IsNullOrEmpty(custom_title)) ? String.Format("[COLOR={0}]{1}[/COLOR]", title_colour, this.staff_title) : custom_title;

            return String.Format("{0}\n{1}", signature_name, signature_title);

        }
    }
}
