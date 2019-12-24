using System;
using PeriodicTable;

namespace OxygenBalanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //application tries to write data about printed substance or print set of substances
            while(true)
            {
                try
                {
                    Console.WriteLine("Print \"ALL\" to get list of information about set of chemical substances\nor print a formula to calculate oxygen balance of given chemical substance");

                    var input = Console.ReadLine();
                    if (input == "ALL")
                    {
                        Explosives.ViewTable();
                    }
                    else 
                    {
                        Console.WriteLine(new OxygenBalance(input));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
