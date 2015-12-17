using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class SalesTransaction
    {
        //Instance Fields
        private string name;
        private int amount;
        private double commission;
        private readonly double commissionRate;
        //Constructors
        public SalesTransaction()   //Parameter-less or default constructor
        {
        }
        public SalesTransaction(string name, int amount, double rate)
        {
            Name = name;
            Amount = amount;
            commissionRate = rate;
            Commission = amount * commissionRate;
        }
        public SalesTransaction(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
        public SalesTransaction(string name)
        {
            Name = name;
        }
        //Properties
        public string Name { get; } //Don't need the setters because the fields have been mutated in
        public int Amount { get; }  //the constructors.
        public double Commission { get; }
        //Instance Method
        public static SalesTransaction operator+(SalesTransaction sales1, SalesTransaction sales2)
        {
            string client = sales1.Name + " and " + sales2.Name;
            int newAmount = sales1.Amount + sales2.Amount;
            return (new SalesTransaction(client, newAmount));
        }
    }
}
