using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        static string name = "integrative";
        static StringBuilder toGuess = new StringBuilder("??te?r?t?ve");
        static string guess;
        public frmGuessWord()
        {
            InitializeComponent();
           

            label1.Text = toGuess.ToString();
            

           
        }
       
        
        private void label1_Click(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == name.ToString())
            {
                label1.Text = name.ToString();
            } else
            {
                
                    guess = textBox1.Text;
                listBox1.Items.Add(guess);
                textBox1.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
