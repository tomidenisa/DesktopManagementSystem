using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Licensing;
using Google.Apis.Gmail;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;

namespace CRUDOP2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ0MzEyMEAzMjMxMmUzMDJlMzBQVmIzQWtRUXJWR25kaWRFSU9lREtOdnR6YnVaQk0vbnF1Y2ptS3hJbGJNPQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registration());
        }
    }
}
