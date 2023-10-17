using HM17._6.Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM17._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resalt = new RenderedСlass();

            resalt.DistributionMethod(new SalaryBankAccount());

            Console.WriteLine();

            resalt.DistributionMethod(new SimpleBankAccount());
        }
    }
}