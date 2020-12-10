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
    class ReportData
    {
        // Closing File Information i.e. Report # and amount of reports
        public string BugID = "Report ID Number";
        public string BIP = "Bug Incentive Program";
        public string RelVer = "Fix Release Version";

        /// <summary>
        /// Uodate Report Records
        /// </summary>
        /// <param name="new_BugID">Report Number to be attached to the response</param>
        /// <param name="BIP_Update">Updated Reporting Party Report Stats</param>
        /// <param name="new_Rel">Provides the version in which the fix will be released</param>
        public void update_settings(string new_BugID = "ID #", string BIP_Update = "PTS", string new_Rel = "3.x.x")
        {
            this.BugID = new_BugID;
            this.BIP = BIP_Update;
            this.RelVer = new_Rel;

            Properties.Settings.Default.BugID = new_BugID;
            Properties.Settings.Default.BIP = BIP_Update;
            Properties.Settings.Default.RelVer = new_Rel;

            Properties.Settings.Default.Save();
        }
    }
};
