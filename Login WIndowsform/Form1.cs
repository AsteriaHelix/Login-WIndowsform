using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_WIndowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Vorname = textBox2.Text;
            string Passwort = textBox3.Text;

            try
            {
                int count = 1;
               



                //if (checkBox1.Checked == true)
                //{
                //    button1.Enabled = true;

                //}
                //else
                //{
                //    button1.Enabled = false;
                //}



                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Bitte geben Sie Vorname, Nachname und Passwort ein.");
                }
                else if((Name == "Batman" && Passwort == "1234" && Vorname == "Bruce")|| (Name == "Tony" && Passwort == "1234" && Vorname == "Stark"))

                {
                    label4.Text = $" Hallo Herr {Vorname} {Name} \n Korrekte Eingabe!!!";
                    count = 0;
                }

                else 
                {
                    if(count == 1) 
                    {
                        label4.Text = "Falsches login!";
                    }
                    else if(count == 2)
                    {
                        label4.Text = "Falsches login \n Sie haben noch 1 Versuch!!!";
                    }
                    else if (count == 3)
                    {
                        label4.Text = "Falsches login \n Sie müssen in 30 Min wieder probieren!!!";
                        count = 0;

                    }
                    count++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler!!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
