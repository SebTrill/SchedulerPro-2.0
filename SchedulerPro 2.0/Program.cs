using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerPro_2._0
{
    static class Program
    {
        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);
            Application.Run(new uxUserInterface());
        }

        /*
        public static void ReadFile(string filename)
        {
            StreamReader sb = new StreamReader(filename);
            string[][] return_values;
            string[] data_values;

            while (!sb.EndOfStream)
            {
                data_values = sb.ReadLine().Split(',');
                string name = data_values[0];
                string[] days = data_values[1].Split(';');

                foreach (string day in days)
                {
                    if (day == "Monday" || day == "monday")
                    {
                        
                    }
                    else if (day == "Tuesday" || day == "tuesday")
                    {
                        // writes the name into the text box for the given day.
                    }
                    else if (day == "Wednesday" || day == "wednesday")
                    {
                        // writes the name into the text box for the given day.
                    }
                    else if (day == "Thursday" || day == "thursday")
                    {
                        // writes the name into the text box for the given day.
                    }
                    else if (day == "Friday" || day == "friday")
                    {
                        // writes the name into the text box for the given day.
                    }
                    else
                    {
                        MessageBox.Show("Error in info. for employee: " + name);
                    }
                }
            }
        }
        */
    }
}