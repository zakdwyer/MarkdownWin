using System;
using System.Linq;
using System.Windows.Forms;

namespace MarkdownWin
{
    static class Program
    {
        public static string[] Arguments;   // Will be null if the program didn't get started with "Open With".

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Arguments = args;               // Assign to public class-level variable so that MainForm can access it.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
