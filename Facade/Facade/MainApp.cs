using System;

namespace Facade
    {
        /// <summary>
        /// Facade Design Pattern.
        /// </summary>

        class MainApp

        {

            static void Main()
            {
                // Facade

                Mortgage mortgage = new Mortgage();

                // Evaluate mortgage eligibility for customer

                Customer customer = new Customer("Ann McKinsey");
                bool eligible = mortgage.IsEligible(customer, 125000);

                Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

                // Wait for user

                Console.ReadKey();
            }
        }
    }
