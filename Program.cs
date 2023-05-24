using  Facade_Lesson.Repositories;
using  Facade_Lesson.Repositories.Facades;
namespace Facade_Lesson;
internal class Program
{
    private static void Main(string[] args)
    {
        IBankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
        accessingBank.withdrawCash(50.00);
        accessingBank.withdrawCash(990.00);
        accessingBank.depositCash(100.00);
        accessingBank.withdrawCash(990.00);
    }
}