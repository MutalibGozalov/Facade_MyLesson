namespace Facade_Lesson.Repositories;

public class FundsCheck 
{
    private double cashInAccount = 1000.00;
    public double getCashInAccount() { return cashInAccount; }
    public void decreaseCashInAccount(double cashWithdrawn) { cashInAccount -= cashWithdrawn; }
    public void increaseCashInAccount(double cashDeposited) { cashInAccount += cashDeposited; }
    
    public bool haveEnoughMoney(double cashToWithdrawal) {
        if(cashToWithdrawal > getCashInAccount()) {
            Console.WriteLine("Error: You don't have enough money");
            Console.WriteLine("Current Balance: " + getCashInAccount());
            return false;
        } 
        else {
            decreaseCashInAccount(cashToWithdrawal);
            Console.WriteLine("Withdrawal Complete: Current Balance is " + getCashInAccount());
            return true;
        }
    }
   
    public void makeDeposit(double cashToDeposit) {
        increaseCashInAccount(cashToDeposit);
        Console.WriteLine("Deposit Complete: Current Balance is " + getCashInAccount());
    }
}
