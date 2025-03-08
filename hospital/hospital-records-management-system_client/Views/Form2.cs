using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_records_management_system_client.Views
{
    public partial class Form2 : Form
    {

        bool checker = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void BExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void BLogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BEye_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!checker && !string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                TBPassword.UseSystemPasswordChar = false;
                checker = true;
            }
            else
            {
                TBPassword.UseSystemPasswordChar = true;
                checker = false;
            }
        }
    }
}
