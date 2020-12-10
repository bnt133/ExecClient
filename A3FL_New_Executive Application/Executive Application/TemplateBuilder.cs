using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Executive_Application
{
    class TemplateBuilder
    {
        private static readonly StringDictionary templates = new StringDictionary()
        {
            { "player_report", "Hello {target},\n\nThank you for the player report, the executive team will take it from here.\n\nRegards,\n\n{signature}" },
            { "report_denied", "Hello {target}, \n\nThank you for submitting a report. Sadly we did not see any rule breaks occur in this video. Feel free to submit another report with additional evidence.\n\nRegards,\n\n{signature}" },
            { "custom_message", "Hello {target},\n\n{custom_message}\n\nThanks,\n\n{signature}" },
            { "compensation_accept", "Hello {target},\n\nYour compensation request has been [B][COLOR=#07FF73]approved[/COLOR][/B] for the following items:\n\n[COLOR=#07FF73]{custom_message}[/COLOR]\n\nPlease see a member of the Executive Team in-game to receive your compensation. You have [B][COLOR=#FF0707]one week to claim your compensation[/COLOR][/B] before this request is no longer valid.\n\nRegards,\n\n{signature}" },
            { "compensation_deny", "Hello {target},\n\nYour compensation request has been [B][COLOR=#FF0707]denied[/COLOR][/B].\n\nRegards,\n\n{signature}" },
            { "qa_process", "Hello {target},\n\nThank you for your bug report.\nWe have notified our Development Team and we are investigating the issue as of {date}.\n\nThanks,\n\n{signature}" },
            { "qa_closing", "Hello {target},\n\nThank you for filing Bug # {BugID} , after investigation of the issue we have forwarded it to our Development Team to be fixed.\nWe appreciate your assistance in helping to improve our server and our community.\n\nThis is the number of bugs you have reported so far:{BugPrgm}\n\nThanks,\n\n{signature}" },
            { "qa_cantreplicate", "Hello {target},\n\nThank you for filing a bug report, after investigation of the issue, we were not able to reproduce this issue. We ask that if this becomes a consistent issue, you please post another bug report with detailed evidence.\n\nThanks,\n\n{signature}" },
            { "qa_fixed", "Hello {target},\n\nThis will be fixed in the Version #.# release.\n\nThanks,\n\n{signature}" }
        };

        /// <summary>
        /// Take in a template type and other assorted options, and return a fully built template message
        /// which can be used by the calling function (generally copied to clipboard).
        /// </summary>
        /// <param name="userSettings">The UserSettings instance from which we will pull the users information</param>
        /// <param name="template_type">The type of message template which should be generated</param>
        /// <param name="target_identifier">The name of the person being targetted in the message</param>
        /// <param name="custom_message">Any additional comments which may be placed in if necessary.</param>
        /// <returns>A fully built message created from the template.</returns>
        public static string get_template(ref UserSettings userSettings, string template_type, string target_identifier, string custom_message = "")
        {
            // If an invalid template_type was provided
            if (!templates.ContainsKey(template_type))
            {
                // Display an error to the user, 
                MessageBox.Show("An invalid template_type was provided to TemplateBuilder->get_template(...). Please contact the developer.");
                
                // Return an empty string, no message can be created here.
                return "";
            }

            // Return the appropriate template, after making all of the necessary replacements.
            return templates[template_type]
                .Replace("{target}", String.Format("[COLOR=#ff8000]{0}[/COLOR]", target_identifier))
                .Replace("{custom_message}", custom_message)
                .Replace("{date}", DateTime.Now.ToString("MM/dd/yyyy"))
                .Replace("{signature}", (!template_type.StartsWith("qa")) ? userSettings.get_signature() : userSettings.get_signature("[COLOR=rgb(194, 123, 160)][B]Quality Assurance Team[/B][/COLOR]"));
        }
    }
}
