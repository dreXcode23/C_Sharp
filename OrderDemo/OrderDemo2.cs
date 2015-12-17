using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03a
{
    class OrderDemo2
    {
        static void Main(string[] args)
        {
            Order[] item = new Order[5];
            int number, quantity;
            double totalPrice = 0;
            string userName;
            bool isItemEqual = false;

            for (int x = 0; x < item.Length; ++x)
            {
                do
                {
                    Write("What is your order #>> ");
                    number = Convert.ToInt32(ReadLine());
                    Write("What is the customer's last name>> ");
                    userName = ReadLine();
                    Write("How many items are you buying>> ");
                    quantity = Convert.ToInt32(ReadLine());

                    item[x] = new Order(number, userName, quantity);
                    if (x > 0)
                    {
                        if (item[x].Equals(item[x - 1]))
                        {
                            WriteLine("You have entered duplicate order numbers");
                            WriteLine("Please re-enter your order");
                            isItemEqual = true;
                        }
                        else
                            isItemEqual = false;
                    }
                } while (isItemEqual);

                totalPrice += item[x].Price;
                WriteLine();
            }

            for (int i = 0; i < item.Length; ++i)
            {
                WriteLine();
                WriteLine(item[i].ToString());
            }

            WriteLine("\nTotal Price: {0:c}", totalPrice);
        }
    }

    class Order
    {
        //Instance Fields
        private int orderNumber;
        private string customerName;
        private int quantityOrder;
        private double price;
        private const double ITEM_COST = 19.95;

        //Constructors
        public Order()
        {

        }
        public Order(int num, string name, int qo)
        {
            this.OrderNumber = num;
            this.CustomerName = name;
            this.QuantityOrder = qo;
        }

        //Properties
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public int QuantityOrder
        {
            get
            {
                return quantityOrder;
            }
            set
            {
                quantityOrder = value;
                price = quantityOrder * ITEM_COST;
            }
        }
        public double Price
        {
            get { return price; }
        }
        //Equals() method
        public override bool Equals(object obj)
        {
            bool isEqual = true;
            if (this.GetType() != obj.GetType())    //Compare if the two objects have the same class
                isEqual = false;
            else
            {
                Order item = (Order)obj;    //Creating a second obj to compare
                if (OrderNumber == item.OrderNumber)
                    isEqual = true;
                else
                    isEqual = false;
            }
            return isEqual;
        }

        //GetHashCode() method
        public override int GetHashCode()
        {
            return orderNumber;
        }

        //ToString() method
        public override string ToString()
        {
            return string.Format("Order Number: #" + OrderNumber + "\nCustomer: " + CustomerName + "\nQuantity: " +
                                 QuantityOrder + "\nPrice: " + Price.ToString("C"));
            // return ($"Order Number: {OrderNumber} \nCustomer: {CustomerName} \nQuantity Order: {QuantityOrder} \nPrice: {Price}");
        }
    }
}
