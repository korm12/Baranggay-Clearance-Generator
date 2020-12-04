using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baranggay_Clearance_Generator
{
   
    public partial class Form1 : Form
    {
      public static String NAME = "", firstName = "", middleName = "", lastName="", POS = "", cs="", age="", address="", gender="", purpose="",remarks="", placeOfBirth="", dateOfBirth = "", dateIssued="", imageFile="";

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
                imageFile = ofd.FileName;
                MessageBox.Show(ofd.FileName);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = fnTB.Text;
            middleName = mnTB.Text;
            lastName = lnTB.Text;
            NAME = firstName + " " + middleName + " " + lastName;
            POS = posTB.Text;
            age = ageTB.Text;
            cs = csCMB.Text;
            address = addrTB.Text;
            gender = genderCMB.Text;
            purpose = purposeTB.Text;
            remarks = remarksTB.Text;
            placeOfBirth = placeofbirthTB.Text;
            dateOfBirth = dobDTP.Text;
            dateIssued = dateissuedDTP.Text;

            MessageBox.Show("Name : " + firstName + " " + middleName + " " + lastName + "\n" +
                            "age : " + age + "\n" +
                            "address : " + address + "\n" +
                            "POS : " + POS + "\n" +
                            "gender : " + gender + "\n" +
                            "purpose : " + purpose + "\n" +
                            "remarks : " + remarks + "\n" +
                            "pob : " + placeOfBirth + "\n" +
                            "dob : " + dateOfBirth + "\n" +
                            "dateissued : " + dateIssued + "\n" 
                            );
            print_preview f2 = new print_preview();
            f2.Show();
            this.Hide();

        }
    }
}
