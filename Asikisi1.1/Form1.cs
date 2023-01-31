using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asikisi1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtfName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfName.Text))
            {
                txtPlaceholder.Text = "Παρακαλώ συμπληρώστε το ονομά σας !!";
            }
            else if (string.IsNullOrEmpty(txtlName.Text))
            {
                txtPlaceholder.Text = "Παρακαλώ συμπληρώστε το επίθετό σας !!";
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPlaceholder.Text = "Παρακαλώ συμπληρώστε το τηλέφωνό σας !!";
            }
            else if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                txtPlaceholder.Text = "Παρακαλώ συμπληρώστε το mail σας !!";
            }
            else if (txtPhone.Text.Length != 10) 
            {
                txtPlaceholder.Text = "Ο αριθμός του τηλεφώνου σας θα πρέπει να έχει 10 ψηφία !!";
            }
            else if (!txtMail.Text.Contains("@")) 
            {
                txtPlaceholder.Text = "Δώστε έγκυρο e-mail !!";
            }
            else
            {
                txtResult.Text = "Όνομα : " + txtfName.Text + "\r\n" + "Επώνυμο :" + txtlName.Text + "\r\n" + "Τηλέφωνο : " + txtPhone.Text + "\r\n" + "Mail :" + txtMail.Text;
            }
        } 

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
