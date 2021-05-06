using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boba
{
    class Global
    {
        //create list 
        public static List<Orders> OrderList;
        //all the orders being placed by the customers, can be shown to Employee Portal
        //global function on login form where all the data is created (saved orders)

        public static void InitializeOrders() //be called when you are on place order screen
        {
            OrderList = new List<Orders>();
            OrderList.Add(new Orders() { Type="Almond Milk Tea", Size="Regular", Toppings = "Brown Sugar Boba", IceLevel = "Less Ice", SweetnessLevel = "Regular", FirstName = "Bob", LastName = "Ross", Phone = 1234567890 });
            OrderList.Add(new Orders() { Type = "Peach Green Tea", Size = "Regular", Toppings = "Rainbow Jelly", IceLevel = "Less Ice", SweetnessLevel = "Regular", FirstName = "Olivia", LastName = "Le", Phone = 9876543210 });
            OrderList.Add(new Orders() { Type = "Taro Milk Tea", Size = "Large", Toppings = "Egg Pudding", IceLevel = "Default", SweetnessLevel = "Semi Sweet", FirstName = "Ash", LastName = "Ketchum", Phone = 7142345678 });
            OrderList.Add(new Orders() { Type = "Strawberry Green Tea", Size = "Regular", Toppings = "Crystal Boba", IceLevel = "No Ice", SweetnessLevel = "Less", FirstName = "Hanh", LastName = "Dinh", Phone = 7140000000 });
        }
    }
}
