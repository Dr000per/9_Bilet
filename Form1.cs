using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateFunction_9_Bilet;

namespace _9_Bilet
{
    public partial class Form1 : Form
    {
        DateFunctions dateFunctions = new DateFunctions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_raznitsa.Text = Math.Abs(Convert.ToInt32(dateFunctions.RaznitsaDays(monthCalendar_StartDate.SelectionRange.Start, monthCalendar_EndDate.SelectionRange.Start))).ToString() + " дней";
            var vremya = textBox_vremya.Text;
            label_vis_date1.Text = dateFunctions.VisokosnostGoda(monthCalendar_StartDate.SelectionRange.Start);
            label_vis_date2.Text = dateFunctions.VisokosnostGoda(monthCalendar_EndDate.SelectionRange.Start);
            try
            {
                if (comboBox1.SelectedItem!= null )
                {
                    label_first_date.Text = dateFunctions.Formatirovanie(comboBox1.SelectedItem.ToString(), monthCalendar_StartDate.SelectionRange.Start);
                    label_second_date.Text = dateFunctions.Formatirovanie(comboBox1.SelectedItem.ToString(), monthCalendar_EndDate.SelectionRange.Start);
                } 
                try
                {
                    label_vremya_sutok.Text = dateFunctions.VremyaSutok(Convert.ToDateTime(vremya));
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
