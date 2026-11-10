namespace Bancs.Classes;

public class Account
{
    public int id;
    private int user_id;
    private double balance;

    public Account(int id, int user_id, double balance)
    {
        this.id = id;
        this.user_id = user_id;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
            return;
        balance += amount;
        Console.WriteLine($"Saldo: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
            return;
        if (amount > balance)
            return;
        balance -= amount;
        Console.WriteLine($"Saldo: {balance}");
    }

    public double CheckBalance()
    {
        return balance;
    }

    public bool CheckUser(int u_id)
    {
        return u_id == user_id;
    }
}
