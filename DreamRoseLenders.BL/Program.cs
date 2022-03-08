using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DreamRoseLenders.BL
{
    class Program : ProgramBase
    {
        public static void Main(string[] args, Lender fullName)
        {
            var lender = new Lender();
            String FullName;
            String CompanyName;
            String Us_State;
            {
                Console.WriteLine("Please enter state you need loan in");
                bool Name = string.IsNullOrWhiteSpace(args[0]);
                bool US_State = Name;
                Console.WriteLine("Lenders who loan in this state are:{CompanyName()}");
                Console.WriteLine("The company contact is:{FullName()}");

                Console.ReadLine();


            }
        }


    }
}
