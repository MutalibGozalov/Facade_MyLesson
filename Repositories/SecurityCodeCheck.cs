namespace Facade_Lesson.Repositories;
public class SecurityCodeCheck 
{
    private int securityCode = 1234;
    public int getSecurityCode() { return securityCode; }
    public bool isCodeCorrect(int secCodeToCheck){
        if(secCodeToCheck == getSecurityCode()) {
            return true;
        } 
        else {
            return false;
        }
    }
}
