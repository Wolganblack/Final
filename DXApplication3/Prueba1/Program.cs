using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using Prueba1.prueba;

namespace Prueba1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //XpoDefault.DataLayer = XpoDefault.GetDataLayer(
            //   ConnectionHelper.ConnectionString,
            //   DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists, true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new MainView());
        }
    }
}
