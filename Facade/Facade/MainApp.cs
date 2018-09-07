using System;

//Facade - https://www.youtube.com/watch?v=B1Y8fcYrz5o
//by Derek Banas https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw

namespace Facade
{
    class MainApp
    {
        static void Main()
        {
            // Facade
            MortgageEligibility mortgageEligibility = new MortgageEligibility();

            // Evaluate mortgageEligibility eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgageEligibility.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}
