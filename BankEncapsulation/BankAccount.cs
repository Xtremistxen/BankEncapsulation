namespace BankEncapsulation;

public class BankAccount
{
// Private field to store the balance
    private double balance = 0;

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}");
            Console.WriteLine($"New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    
    //Method to withdraw money from account
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}");
                Console.WriteLine($"New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }


    // Method to get the current balance
    public double GetBalance()
    {
        return balance;
    }
}