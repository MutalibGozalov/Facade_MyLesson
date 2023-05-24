namespace Facade_Lesson.Repositories;
public class AccountNumberCheck
{
    private int accountNumber = 12345678;
    public int getAccountNumber() { return accountNumber; }
    public bool accountActive(int acctNumToCheck){
        if(acctNumToCheck == getAccountNumber()) {
            return true;
        } 
        else {
            return false;
        }
    }
}
