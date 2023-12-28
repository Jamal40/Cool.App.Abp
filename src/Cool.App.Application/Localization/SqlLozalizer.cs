using Cool.App.Entities;
using Cool.App.Extensions;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.Domain.Repositories;

namespace Cool.App.Localization;

public class SqlLozalizer(IRepository<LocalizationItem> localizationItemRepo) : IStringLocalizer
{
    public LocalizedString this[string name]
    {
        get
        {
            return GetLocalizedString(name);
        }
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            return GetLocalizedString(name, arguments);
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        var localizationItems = localizationItemRepo.GetListAsync().Result;
        return localizationItems.Select(i => new LocalizedString(i.Code, i.Value));
    }

    private LocalizedString GetLocalizedString(string name, params object[] arguments)
    {
        var localizationItem = localizationItemRepo.FindAsync(i => i.Code == name).Result;
        var value = localizationItem?.Value ?? name;
        var formattedValue = value.TryFormat(arguments);
        return new LocalizedString(name, formattedValue);
    }
}


public class SqlLozalizer<T>(IRepository<LocalizationItem> localizationItemRepo) : IStringLocalizer<T>
{
    public LocalizedString this[string name]
    {
        get
        {
            return GetLocalizedString(name);
        }
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            return GetLocalizedString(name, arguments);
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        var localizationItems = localizationItemRepo.GetListAsync().Result;
        return localizationItems.Select(i => new LocalizedString(i.Code, i.Value));
    }

    private LocalizedString GetLocalizedString(string name, params object[] arguments)
    {
        var localizationItem = localizationItemRepo.FindAsync(i => i.Code == name).Result;
        var value = localizationItem?.Value ?? name;
        var formattedValue = string.Format(value, arguments);
        return new LocalizedString(name, formattedValue);
    }
}
