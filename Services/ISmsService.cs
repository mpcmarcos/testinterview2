namespace Interview.Services
{
    public interface ISmsService
    {
        void Send(string phone, string message);
    }
}