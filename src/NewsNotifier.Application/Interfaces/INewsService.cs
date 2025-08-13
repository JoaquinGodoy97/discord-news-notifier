namespace NewsServiceApp.Services
{
    public interface INewsService
    {
        Task<string> GetNewsAsync();
    }
}