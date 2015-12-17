using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class SalesTransactionDemo
    {
        static void Main(string[] args)
        {
            SalesTransaction client1 = new SalesTransaction("Sam", 5000, .1);
            SalesTransaction client2 = new SalesTransaction("Henry", 3500);
            SalesTransaction client3 = new SalesTransaction("Andre");
            SalesTransaction clientMix = new SalesTransaction();
            clientMix = client1 + client3;

            WriteLine("{0, -10}{1, 21}{2, 20}", "SalesPerson", "Sales Amount", "Commission");
            WriteLine();
            DisplaySales(client1);
            DisplaySales(client2);
            DisplaySales(client3);
            DisplaySales(clientMix);
        }
        static void DisplaySales(SalesTransaction obj)
        {
            WriteLine("{0, -20}{1, 10}{2, 20}", obj.Name, obj.Amount.ToString("C"), obj.Commission.ToString("C"));
        }
    }
}
