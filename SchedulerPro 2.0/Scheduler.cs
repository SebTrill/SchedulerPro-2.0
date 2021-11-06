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
                string[] start_times = data_values[2].Split(';');
                string[] end_times = data_values[3].Split(';');

                foreach (string day in days)
                {
                    if (day == "Monday" || day == "monday")
                    {
                        uxMondayText.Text = uxMondayText.Text + name + Environment.NewLine;

                        for(int i = 0; i < start_times.Length; i++)
                        {
                            uxMondayText.Text = uxMondayText.Text + start_times[i] + " - " + end_times[i] + Environment.NewLine;
                        }

                        uxMondayText.Text = uxMondayText.Text + "(Available for " + start_times.Length + " shifts)" + Environment.NewLine;
                        uxMondayText.Text = uxMondayText.Text + Environment.NewLine;

                        uxMondayText.SelectAll();
                        uxMondayText.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else if (day == "Tuesday" || day == "tuesday")
                    {
                        uxTuesdayText.Text = uxTuesdayText.Text + name + Environment.NewLine;

                        for (int i = 0; i < start_times.Length; i++)
                        {
                            uxTuesdayText.Text = uxTuesdayText.Text + start_times[i] + " - " + end_times[i] + Environment.NewLine;
                        }

                        uxTuesdayText.Text = uxTuesdayText.Text + "(Available for " + start_times.Length + " shifts)" + Environment.NewLine;
                        uxTuesdayText.Text = uxTuesdayText.Text + Environment.NewLine;

                        uxTuesdayText.SelectAll();
                        uxTuesdayText.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else if (day == "Wednesday" || day == "wednesday")
                    {
                        uxWednesdayText.Text = uxWednesdayText.Text + name + Environment.NewLine;

                        for (int i = 0; i < start_times.Length; i++)
                        {
                            uxWednesdayText.Text = uxWednesdayText.Text + start_times[i] + " - " + end_times[i] + Environment.NewLine;
                        }

                        uxWednesdayText.Text = uxWednesdayText.Text + "(Available for " + start_times.Length + " shifts)" + Environment.NewLine;
                        uxWednesdayText.Text = uxWednesdayText.Text + Environment.NewLine;

                        uxWednesdayText.SelectAll();
                        uxWednesdayText.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else if (day == "Thursday" || day == "thursday")
                    {
                        uxThursdayText.Text = uxThursdayText.Text + name + Environment.NewLine;

                        for (int i = 0; i < start_times.Length; i++)
                        {
                            uxThursdayText.Text = uxThursdayText.Text + start_times[i] + " - " + end_times[i] + Environment.NewLine;
                        }

                        uxThursdayText.Text = uxThursdayText.Text + "(Available for " + start_times.Length + " shifts)" + Environment.NewLine;
                        uxThursdayText.Text = uxThursdayText.Text + Environment.NewLine;

                        uxThursdayText.SelectAll();
                        uxThursdayText.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else if (day == "Friday" || day == "friday")
                    {
                        uxFridayText.Text = uxFridayText.Text + name + Environment.NewLine;

                        for (int i = 0; i < start_times.Length; i++)
                        {
                            uxFridayText.Text = uxFridayText.Text + start_times[i] + " - " + end_times[i] + Environment.NewLine;
                        }

                        uxFridayText.Text = uxFridayText.Text + "(Available for " + start_times.Length + " shifts)" + Environment.NewLine;
                        uxFridayText.Text = uxFridayText.Text + Environment.NewLine;

                        uxFridayText.SelectAll();
                        uxFridayText.SelectionAlignment = HorizontalAlignment.Center;
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
