using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerPro_2._0
{
    public partial class uxUserInterface : Form
    {
        public uxUserInterface()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// IGNORE!!!!!!!!!!!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // IGNORE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void uxOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ReadFile(uxOpenFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ReadFile(string filename)
        {
            StreamReader sb = new StreamReader(filename);
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
                        uxMondayText.Text = uxMondayText.Text + name + Environment.NewLine;
                    }
                    else if (day == "Tuesday" || day == "tuesday")
                    {
                        uxTuesdayText.Text = uxTuesdayText.Text + name + Environment.NewLine;
                    }
                    else if (day == "Wednesday" || day == "wednesday")
                    {
                        uxWednesdayText.Text = uxWednesdayText.Text + name + Environment.NewLine;
                    }
                    else if (day == "Thursday" || day == "thursday")
                    {
                        uxThursdayText.Text = uxThursdayText.Text + name + Environment.NewLine;
                    }
                    else if (day == "Friday" || day == "friday")
                    {
                        uxFridayText.Text = uxFridayText.Text + name + Environment.NewLine;
                    }
                    else
                    {
                        MessageBox.Show("Error in info. for employee: " + name);
                    }
                }
            }
        }
    }
}
