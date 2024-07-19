namespace BankEncapsulation
{
    public class Program
    {
        public static void Main()
        {

            // Create a new instance of the BankAccount class
            BankAccount account = new BankAccount();

            bool running = true;


            while (running)

            {
                // Display menu options
                Console.WriteLine("\nBank Account Menu:");
                Console.WriteLine("1. Deposit money");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Check balance");
                Console.WriteLine("4. Exit");

                // Read user choice
                Console.Write("Enter your choice (1/2/3/4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Deposit money
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered.");
                        }

                        break;
                    
                    case "2":
                        //Withdraw money
                    Console.WriteLine("Enter amount to withdraw:");
                        var withdrawInput = Console.ReadLine();
                      
                        if (double.TryParse(withdrawInput, out double withDrawAmount))
                        {
                            if (withDrawAmount > 0)
                            {
                                account.Withdraw(withDrawAmount);
                            }
                            else
                            {
                                Console.WriteLine("Withdrawal amount must be positive.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered. Please enter a numeric value.");
                        }

                        break;

                    case "3":
                        // Check balance
                        Console.WriteLine($"Current balance: {account.GetBalance():C}");
                        break;

                    case "4":
                        // Exit the application
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
