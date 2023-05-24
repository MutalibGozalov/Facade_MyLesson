namespace Facade_Lesson.Repositories.Facades;
public class BankAccountFacade : IBankAccountFacade
{
    private int accountNumber;
    private int securityCode;
    AccountNumberCheck acctChecker;
    SecurityCodeCheck codeChecker;
    FundsCheck fundChecker;
    WelcomeToBank bankWelcome;
    public BankAccountFacade(int newAcctNum, int newSecCode)
    {

        accountNumber = newAcctNum;
        securityCode = newSecCode;

        bankWelcome = new WelcomeToBank();
        acctChecker = new AccountNumberCheck();
        codeChecker = new SecurityCodeCheck();
        fundChecker = new FundsCheck();
    }

    public int getAccountNumber() { return accountNumber; }

    public int getSecurityCode() { return securityCode; }

    public void withdrawCash(double cashToGet)
    {
        if (acctChecker.accountActive(getAccountNumber()) && codeChecker.isCodeCorrect(getSecurityCode()) && fundChecker.haveEnoughMoney(cashToGet))
        {
            Console.WriteLine("Transaction Complete\n");
        }
        else
        {
            Console.WriteLine("Transaction Failed\n");
        }
    }
    public void depositCash(double cashToDeposit)
    {
        if (acctChecker.accountActive(getAccountNumber()) && codeChecker.isCodeCorrect(getSecurityCode()))
        {
            fundChecker.makeDeposit(cashToDeposit);
            Console.WriteLine("Transaction Complete\n");
        }
        else
        {
            Console.WriteLine("Transaction Failed\n");
        }
    }
}
