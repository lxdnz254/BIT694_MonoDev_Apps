using System;
namespace Assignment1
{
	public static class Menu
	{
		// Displays the main menu and returns an int, selected by user
        internal static int DisplayMenu()
        {
            DisplayTitle("Banking System");
            String[] options = {    "Exit",
                                    "Deposit",
                                    "Withdraw",
                                    "Check Max Balance",
                                    "Check Most Active Account",
                                    "Check Youngest Customer",
                                    "Show Customers Born on Leap year"
            };

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(i + ". " + options[i]);
            }

            Console.Write("\nEnter Option (0-6) >> ");
            String key = Console.ReadLine();
            int result;
            if (int.TryParse(key, out result))
            {
                if (result >= 0 && result <= 6)
                {

                }
                else
                {
                    Console.WriteLine("\nIncorrect number");
                    waitForKey();
                    result = DisplayMenu();
                }
            }
            else
            {
                Console.WriteLine("\nIncorrect input format");
                waitForKey();
                result = DisplayMenu();
            }
            return result;
        }

        // Formats the title display for each option
		internal static void DisplayTitle(String title)
        {
            Console.Clear();
			Console.WriteLine(MainClass.titleLines);
            Console.WriteLine("      " + title);
			Console.WriteLine(MainClass.titleLines + "\n");
        }

        // method for waiting for a key press.
        internal static void waitForKey()
        {
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }

        // Method to make a deposit for a Customer
        internal static void MakeDeposit(Customer[] array)
        {
            DisplayTitle("Deposit");

            Console.Write("Enter account ID: ");
            String id = Console.ReadLine();
            int result;
            if (int.TryParse(id, out result))
            {
                int customerPos = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].AccessID == result)
                    {
                        customerPos = i;
                    }
                }
                if (customerPos >= 0)
                {
                    Console.Write("Depositing into account of " + array[customerPos].AccessFullName + ". ");
                    Console.WriteLine("Current balance: " + String.Format("{0:C}", array[customerPos].AccessBalance));
                    Console.Write("\nEnter the amount to deposit: $");
                    String deposit = Console.ReadLine();
                    double dep;
                    if (double.TryParse(deposit, out dep))
                    {
                        array[customerPos].Deposit(dep);
                        Console.WriteLine("\nSuccesfully deposited {0:C}. Current Balance is {1:C}", dep, array[customerPos].AccessBalance);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input for deposit");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo ID match in customer array");
                }
            }
            else
            {
                Console.WriteLine("\nNot a valid ID format");
            }
            waitForKey();
        }

        // Method to make a withdrawl for a Customer
        internal static void MakeWithdrawl(Customer[] array)
        {
            DisplayTitle("Withdrawl");

            Console.Write("Enter account ID: ");
            String id = Console.ReadLine();
            int result;
            if (int.TryParse(id, out result))
            {
                int customerPos = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].AccessID == result)
                    {
                        customerPos = i;
                    }
                }
                if (customerPos >= 0)
                {
                    Console.Write("Withdrawing from account of " + array[customerPos].AccessFullName + ". ");
                    Console.WriteLine("Current balance: " + String.Format("{0:C}", array[customerPos].AccessBalance));
                    Console.Write("\nEnter the amount to withdraw: $");
                    String withdraw = Console.ReadLine();
                    double wdraw;
                    if (double.TryParse(withdraw, out wdraw))
                    {
                        array[customerPos].Withdraw(wdraw);
                        Console.WriteLine("\nSuccesfully withdrew {0:C}. Current Balance is {1:C}", wdraw, array[customerPos].AccessBalance);
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input for withdraw");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo ID match in customer array");
                }
            }
            else
            {
                Console.WriteLine("\nNot a valid ID format");
            }

            waitForKey();
        }

        // Method to display the Customer with largest balance and display
        internal static void GetMaximumBalance(Customer[] array)
        {
            DisplayTitle("Max Balance Customer");
            // set initial customer position
            int pos = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].AccessBalance > array[pos].AccessBalance)
                {
                    pos = i;
                }
            }
            // display the customer with max balance
            array[pos].DisplayInfo();
            // is it their birthday?
            if (DateUtilities.IsBirthday(array[pos].AccessDob))
            {
                Console.WriteLine("\nHappy Birthday!");
            }
            waitForKey();
        }

        // Method to display the most active Customer
        internal static void GetMostActive(Customer[] array)
        {
            DisplayTitle("Most Active Customer");
            // set initial customer position
            int pos = 0;
            // iterate over array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].AccessActivityCounter > array[pos].AccessActivityCounter)
                {
                    pos = i;
                }
            }
            // display the max Active customer
            array[pos].DisplayInfo();
            waitForKey();
        }
        
        // Method to display the Youngest customer
        internal static void GetYoungest(Customer[] array)
        {
            DisplayTitle("Youngest Customer");
            array[DateUtilities.GetYoungest(array)].DisplayInfo();
            waitForKey();
        }
        
        // Method to display all customers born in a leap year and their zodiac signs
        internal static void GetLeapYearCustomers(Customer[] array)
        {
            DisplayTitle("Leap Years and Zodiac Signs");
            foreach (Customer customer in array)
            {
                if (DateUtilities.IsLeapYear(customer.AccessDob))
                {
                    customer.DisplayInfo();
                    Console.WriteLine(String.Format("{0,-15} {1}", "Zodiac:", DateUtilities.GetZodiac(customer.AccessDob)) + "\n");
                }
            }
            waitForKey();
        }
        
	}
}
