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



             using (var reader = new StreamReader(@"Lender.csv"))
             using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
             {
                lender = csv.GetRecords<Lender>().ToList();
             }
             do
            {

                Console.WriteLine("Please enter state you need loan in?");
                userInput = Console.ReadLine().ToLower();
               
                Console.WriteLine("Lenders who loan in this state are: ");
                lender.Where(l => l.States.ToLower().Contains(userInput)).ToList().ForEach((lender) =>
                {
                    Console.WriteLine(lender.CompanyName);


                    if (lender.FullName == null || lender.FullName == " ")

                    {
                        Console.WriteLine("Contact Name: No Name found");
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
    }
}
                       
                    
                
      















       

       
            


