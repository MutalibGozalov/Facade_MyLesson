namespace Facade_Lesson.Repositories.Facades;

public interface IBankAccountFacade
{
    void depositCash(double cashToDeposit);
    void withdrawCash(double cashToGet);
}