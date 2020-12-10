using Executive_Application.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executive_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // The sound we will play when notifying the user of something
        public static SoundPlayer execNotification = new SoundPlayer(Properties.Resources.notification);
    }
}
