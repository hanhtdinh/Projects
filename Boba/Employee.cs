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
    public partial class Employee : Form
    {
        //displays a message to the user if they put invalid credentials
        const string incorrectLogin = "Invalid Username or Password. Please Try again.";
        public Employee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifies the user and sees if it is a customer or an employee
            //create instance of "order" form if it is a normal user 
            //if employee, show employee portal where they can manipulate orders
           

            string username = txtUser.Text;
            string password = txtPass.Text;

            if((this.txtUser.Text=="user") && (this.txtPass.Text=="password"))
            {
                //takes us to the new form for ordering
                this.Hide();
                Order f = new Order();
                f.Show();
            }
            else if ((this.txtUser.Text=="employee") && (this.txtPass.Text=="bobarocks"))
            {
                //redirectors to Employee Portal
                this.Hide();
                EmployeeView empportal = new EmployeeView();
                empportal.Show();
            }
            //populate error message
            else { MessageBox.Show(incorrectLogin); }
            

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            //when user creates a password, it will appear as asterisks
            txtPass.PasswordChar = '*';
        }
    }
}
