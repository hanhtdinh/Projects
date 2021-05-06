using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boba
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //redirects user back to Login screen
            this.Hide();
            Employee login2 = new Employee();
            login2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
