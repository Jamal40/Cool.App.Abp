using Cool.App.Dtos;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Caching;

namespace Cool.App.Services;

public class TestService : AppAppService
{
    private readonly IDistributedCache<CoolCachItem> _cache;
    private readonly IStringLocalizer<TestService> _localizer;

    public TestService(IDistributedCache<CoolCachItem> cache, IStringLocalizer<TestService> localizer)
    {
        _cache = cache;
        _localizer = localizer;
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
        var t = _localizer["Cool.App:1100"];
        //throw new UserFriendlyException(t);
        throw new BusinessException("Cool.App:1100");
        //{
        //    Data =
        //    {
        //        { "0", "1500"}
        //    }
        //};
        var gottenItem = await _cache.GetAsync(item);
        return gottenItem;
    }
}
