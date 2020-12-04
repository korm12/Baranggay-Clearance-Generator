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
    public partial class print_preview : Form
    {

        public print_preview()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void print_preview_Load(object sender, EventArgs e)
        {
            nameLB.Text = Form1.NAME;
            addressLB.Text = Form1.address;
            posLB.Text = Form1.POS;
            dobLB.Text = Form1.dateOfBirth;
            pobLB.Text = Form1.placeOfBirth;
            csLB.Text = Form1.cs;
            ageLB.Text = Form1.age;
            genderLB.Text = Form1.gender;
            purposeLB.Text = Form1.purpose;
            remarksLB.Text = Form1.remarks;
            dateissuedLB.Text = Form1.dateIssued;
            pictureBox1.ImageLocation = Form1.imageFile;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            {
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"files/" + Form1.lastName +".bmp");
            }
                MessageBox.Show("File saved with filename :" + Form1.lastName + ".bmp");
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();

        }
    }
}
