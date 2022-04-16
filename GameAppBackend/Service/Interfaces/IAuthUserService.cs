namespace GameAppBackend.Service.Interfaces
{
    public interface IAuthUserService
    {
        bool Login();
        bool Register();
        bool doesPasswordMatchExisting();
    }
}
