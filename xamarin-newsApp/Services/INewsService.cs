using System.Threading.Tasks;
using xamarinnewsApp.Models;

namespace xamarinnewsApp.Services
{
    public interface INewsService
    {
        Task<NewsResult> GetNews(NewsScope scope);
    }
}