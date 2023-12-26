using Cool.App.Dtos;
using System.Threading.Tasks;
using Volo.Abp.Caching;

namespace Cool.App.Services;

public class TestService : AppAppService
{
    private readonly IDistributedCache<CoolCachItem> _cache;

    public TestService(IDistributedCache<CoolCachItem> cache)
    {
        _cache = cache;
    }

    public async Task<bool> SetCahceItem(string item, string name, decimal price)
    {
        await _cache.SetAsync(item, new CoolCachItem
        {
            Name = name,
            Price = price,
        });
        return true;
    }

    public async Task<CoolCachItem?> GetCahceItem(string item)
    {
        var gottenItem = await _cache.GetAsync(item);
        return gottenItem;
    }
}
