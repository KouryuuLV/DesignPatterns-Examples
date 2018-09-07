using System;

//Facade - https://www.youtube.com/watch?v=B1Y8fcYrz5o
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace FacadeNotImplemented
{
    /// Facade Design Pattern is not Implemented.

    class MainApp
    {
        static void Main()
        {
            Bank _bank = new Bank();
            Loan _loan = new Loan();
            Credit _credit = new Credit();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            var amount = 125000;
            Console.WriteLine("{0} applies for {1:C} loan\n",
                customer.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            Console.WriteLine("\n" + customer.Name +" has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
