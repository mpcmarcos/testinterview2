namespace Interview.Services
{
    public interface IMailService
    {
        void Send(string to, string from, string body);
    }
}