using CsvHelper;
using System.Collections;
using System.Globalization;
namespace DreamRoseLenders.BL
{
    public class Program
    {
        public static void Main()

        {
            List<Lender> lender = new List<Lender>();
            string userInput = "";

            lender = GetLendersFromCsv();

            do
            {
                GatherStateInformation();


                Console.WriteLine("Lenders who loan in this state are: ");
                lender.Where(l => l.States.ToLower().Contains(userInput)).ToList().ForEach((lender) =>
                {
                    Console.WriteLine(lender.CompanyName);


                    if (lender.FullName == null || lender.FullName == " ")

                    {
                       NoContactFound();
                    }
                    else
                    {
                        Console.WriteLine("The Contact Name is: " + lender.FullName);
                    }
                    Console.WriteLine("The Company Phone Number is: " + lender.CompanyPhoneNumber);

                });
                Console.WriteLine("To exit, type \"exit\" or enter to pick another state");
                userInput = Console.ReadLine();
            } while (userInput != "exit");
        }
        public static List<Lender> GetLendersFromCsv()
            {
            using (var reader = new StreamReader(@"Lender.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var lenders = csv.GetRecords<Lender>().ToList();

                return lenders;
        }
        }

        public static string GatherStateInformation()
        {
            Console.WriteLine("Please enter state you need loan in?");
            return Console.ReadLine().ToLower();
        }
        public static void NoContactFound()
        {
            Console.WriteLine("Contact Name: No Name found");
        }
           
    }
}
                    
                
      















       

       
            


