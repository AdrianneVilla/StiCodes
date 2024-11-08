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

namespace FrmLab1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            string[] array = {
                "Student No. : "+ studentNoTxt.Text,
                "Full Name : " + lastNametxt.Text +", "+ txtFirstName.Text +" "+ txtMiddleInitial.Text,
                "Program : " + cbProgram.Text,
                "Gender : " + cbGender.Text,
                "Age : " + ageTxt.Text,
                "Birthday :" + dateTimePicker1.Text,
                "Contact no.: "+ txtContactNo.Text,

            };

            
                FrmFileName.SetFileName = studentNoTxt.Text + ".txt";
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                foreach (string s in array)
                {
                    outputFile.WriteLine(s);
                }
                }


            
        }
    }
}
