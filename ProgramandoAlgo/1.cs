using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProgramandoAlgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int entero;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*entero = Convert.ToInt32(textBox1.Text);
            if (entero == 1)
            {
                SoundPlayer sonid = new SoundPlayer();
                sonid.SoundLocation = "C:/Users/ULISES/Downloads/y.wav";
                sonid.Play();
            }
            else
            {
                SoundPlayer sonid = new SoundPlayer();
                sonid.SoundLocation = "C:/Users/ULISES/Downloads/meta.wav";
                sonid.Play();
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = string.Empty;

            }
        }
    }
}
