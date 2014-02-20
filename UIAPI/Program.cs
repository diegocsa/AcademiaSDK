using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcademiaSAPSDK.UIAPI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var conn = new Connection();
            conn.Login();
            conn.SetupEventHandlers();
            conn.AddMenu();
            //conn.Form001();

            //conn.TransformToXml("392");
            //conn.LoadFromXml();
            // conn.LoadTestForm();
            Connection.SAPApplication.StatusBar.SetText("EXEC FIM", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Success);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
            
            
        }

    }
}
