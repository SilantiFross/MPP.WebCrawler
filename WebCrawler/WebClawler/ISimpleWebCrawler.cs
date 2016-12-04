using System.Threading.Tasks;

namespace WebClawler
{
    internal interface ISimpleWebCrawler
    {
        Task<CrawResult> PerformCrawlingAsync(string[] rootUrls);
    }
}
