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
    
    public partial class Order : Form
    {
        //create an instance of Order Form vs. Form 2 when you need to show the view

        
        
        
        
        List<string> Payment= new List<string>() { "Cash", "Credit Card", "Gift Card"};
        public Order()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMIlk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            Global.OrderList = new List<Orders>(); //global list
            //Global.OrderList.Add(new Orders); --> will come from form 
            List<string> MilkTeas = new List<string>() { "Almond Milk Tea", "Brown Sugar Milk Tea", "Classic Milk Tea", "Honeydew Milk Tea", "Taro Milk Tea", "Thai Tea", "Jasmine Green Tea", "Lychee Black Tea", "Mango Tea", "Peach Green Tea", "Strawberry Green Tea" };
            comboMIlk.DataSource = MilkTeas;
            List<string> Sizes = new List<string>() { "Regular", "Large" };
            comboMilkSize.DataSource = Sizes;
            
            List<string> Ice = new List<string>() { "Default", "Less Ice", "No Ice" };
            comboIce.DataSource = Ice;
           
            List<string> Sweetness = new List<string>() { "Extra Sweet", "Regular", "Semi Sweet", "Less" };
            comboSweetness.DataSource = Sweetness;
            
            //List<string> Payment = new List<string>() { "Cash", "Credit Card", "Gift Card" };

            Global.InitializeOrders();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //addtocart functionality to create a new order obj (will be added to order list)
            //ex. first drink, second drink from customer
            //clear functionality and adding all the drinks of one person
            //place order --> create new order add to cart)
            Orders drinkorders = new Orders();
            drinkorders.Type = Convert.ToString(comboMIlk.SelectedValue);
            drinkorders.Size = Convert.ToString(comboMilkSize.SelectedValue);
            drinkorders.SweetnessLevel = Convert.ToString(comboSweetness.SelectedValue);
            drinkorders.IceLevel = Convert.ToString(comboIce.SelectedValue);
            drinkorders.FirstName = txtFname.Text;
            drinkorders.LastName = txtLastname.Text;
            drinkorders.Phone = Convert.ToInt64(txtPhone.Text);
            //drinkorders.Toppings = Convert.ToString(checkedListBox1.CheckedItems()
            //Determine if there are any items checked
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                drinkorders.Toppings = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)

                    foreach (var toppingchoice in checkedListBox1.CheckedIndices)
                    {
                        drinkorders.Toppings = drinkorders.Toppings + checkedListBox1.CheckedItems[i].ToString();
                        //checkListBox1.GetItemCheckState(indexChecked).ToString()+ ".");
                        break;

                    }

            }
            Global.OrderList.Add(drinkorders); //add created drink to OrdersList
            //migrate back to checkout screen
            //perhaps create "order is added"
            this.Hide();
            CheckOut ordercompl = new CheckOut();
            ordercompl.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboFruit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMilkSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboIce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSweetness2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSweetness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboIce2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
