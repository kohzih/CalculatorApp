using log4net.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorApp.ViewModels;

namespace CalculatorApp
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            LogManager.GetRepository().Threshold = log4net.Core.Level.Debug;
            var logger = LogManager.GetLogger(typeof(Program));
            logger.Info("Application started");

            Application.ThreadException += (sender, e) =>
            {
                logger.Error("Unhandled exception", e.Exception);
                MessageBox.Show("エラーが発生しました。アプリケーションを終了します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
