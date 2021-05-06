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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            
            datagridEmp.DataSource = null;
            datagridEmp.DataSource = Global.OrderList;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            groupBox1.Show();
            //phone row = phone number 
            //get particular obj from list by the phone number
            textBox1.Text = Convert.ToString(datagridEmp.CurrentRow.Cells[5].Value);
            textBox2.Text = Convert.ToString(datagridEmp.CurrentRow.Cells[6].Value);
            textBox3.Text = Convert.ToString(datagridEmp.CurrentRow.Cells[7].Value);

            comboDrink.SelectedText = Convert.ToString(datagridEmp.CurrentRow.Cells[0].Value);

            comboSize.SelectedText = Convert.ToString(datagridEmp.CurrentRow.Cells[1].Value);
            comboIce.SelectedText = Convert.ToString(datagridEmp.CurrentRow.Cells[4].Value);
            comboSweetness.SelectedText = Convert.ToString(datagridEmp.CurrentRow.Cells[3].Value);
            checkedListBox1.SelectedValue = Convert.ToString(datagridEmp.CurrentRow.Cells[2].Value);


            //if (checkedListBox1.CheckedItems.Count != 0)
            //{
            //    // If so, loop through all checked items and print results.  
            //    string s = "";
            //    for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            //    {
            //        s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
            //    }
            //    MessageBox.Show(s);
            //}
            //updating checklist box need to find out way to show several boxes (add to cart functuality)

            //datagridEmp.DataSource = null;
            //datagridEmp.DataSource = Global.OrderList;

            //textBox3.Text = Convert.ToString(datagridEmp.CurrentRow.Cells[2].Value);
            //var PhoneNumber = Convert.ToInt64(txtPhone.Text);


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Global.OrderList.RemoveAt(datagridEmp.CurrentRow.Index);
            datagridEmp.DataSource = null;
            datagridEmp.DataSource = Global.OrderList;

        }

        private void datagridEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            datagridEmp.DataSource = null;
            datagridEmp.DataSource = Global.OrderList;
            //Global.InitializeOrders();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            //creating a new drink order
            groupBox1.Show();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Orders neworder = new Orders();
                neworder.FirstName = textBox1.Text;
                neworder.LastName = textBox2.Text;
                neworder.Phone = Convert.ToInt64(textBox3.Text);
                neworder.Type = Convert.ToString(comboDrink.SelectedItem);
                neworder.Size = Convert.ToString(comboSize.SelectedItem);
                neworder.IceLevel = Convert.ToString(comboIce.SelectedItem);
                neworder.SweetnessLevel = Convert.ToString(comboSweetness.SelectedItem);
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    neworder.Toppings = "";
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)

                        foreach (var toppingchoice in checkedListBox1.CheckedIndices)
                        {
                            neworder.Toppings = neworder.Toppings + " " + checkedListBox1.CheckedItems[i].ToString();
                            //checkListBox1.GetItemCheckState(indexChecked).ToString()+ ".");
                        }

                }
                Global.OrderList.Add(neworder);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            //clear the selected item from combo box
            comboDrink.Items.Clear();
            comboIce.Items.Clear();
            comboSize.Items.Clear();
            comboSweetness.Items.Clear();
            checkedListBox1.CheckedItems.OfType<string>().ToList().ForEach(checkedListBox1.Items.Remove);
            //display list of options again
             //global list
            //Global.OrderList.Add(new Orders); --> will come from form 
            List<string> MilkTeas = new List<string>() { "Almond Milk Tea", "Brown Sugar Milk Tea", "Classic Milk Tea", "Honeydew Milk Tea", "Taro Milk Tea", "Thai Tea" };
            comboDrink.DataSource = MilkTeas;
            //List<string> FruitTeas = new List<string>() { "Jasmine Green Tea", "Lychee Black Tea", "Mango Tea", "Peach Green Tea", "Strawberry Green Tea" };
            //comboFruit.DataSource = FruitTeas;
            List<string> Sizes = new List<string>() { "Regular", "Large" };
            comboSize.DataSource = Sizes;
            
            List<string> Ice = new List<string>() { "Default", "Less Ice", "No Ice" };
            comboIce.DataSource = Ice;
            
            List<string> Sweetness = new List<string>() { "Extra Sweet", "Regular", "Semi Sweet", "Less" };
            comboSweetness.DataSource = Sweetness;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //place order --> create new order add to cart)
            //edit an order based on identification

            long phone = Convert.ToInt64(datagridEmp.CurrentRow.Cells[7].Value); //phone num from grid where we want to search
            //get obj ref from order list
            var obj = Global.OrderList.First(p => p.Phone == phone);
            //what you want to update ex. ice level, (what you want to change)
            obj.IceLevel = Convert.ToString(comboIce.SelectedValue);
            obj.SweetnessLevel = Convert.ToString(comboSweetness.SelectedValue);
            obj.Size = Convert.ToString(comboSize.SelectedValue);
            obj.Type = Convert.ToString(comboDrink.SelectedValue);
            //obj.Toppings = Convert.ToString(checkedListBox1.CheckedItems);
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                obj.Toppings = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)

                    foreach(var toppingchoice in checkedListBox1.CheckedIndices)
                    {
                        obj.Toppings =  obj.Toppings + " " + checkedListBox1.CheckedItems[i].ToString() ;
                        break;
                        //checkListBox1.GetItemCheckState(indexChecked).ToString()+ ".");
                        
                    }

            }
            datagridEmp.DataSource = null;
            datagridEmp.DataSource = Global.OrderList;

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee login = new Employee();
            login.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
