using Cool.App.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Volo.Abp.Domain.Repositories;

namespace Cool.App.Localization;

public class SqlLozalizer
    : IStringLocalizer
{
    private readonly IRepository<TranslationInfo> _localizationItemRepo;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SqlLozalizer(IRepository<TranslationInfo> localizationItemRepo,
        IHttpContextAccessor httpContextAccessor)
    {
        _localizationItemRepo = localizationItemRepo;
        _httpContextAccessor = httpContextAccessor;
    }
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
        var localizationItems = _localizationItemRepo.GetListAsync().Result;
        return localizationItems.Select(i => new LocalizedString(i.Code, i.Message));
    }

    private LocalizedString GetLocalizedString(string name, params object[] arguments)
    {
        _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("language", out var currentLanguage);
        var localizationItem = _localizationItemRepo.FindAsync(i => i.Code == name && i.Language == currentLanguage!.ToString())
            .Result;
        var value = localizationItem?.Message ?? name;

        value = FormatValue(arguments, value);

        return new LocalizedString(name, value);
    }

    private static string FormatValue(object[] arguments, string value)
    {
        if (arguments is null)
            return value;

        var regex = new Regex("[&]");
        foreach (var arg in arguments)
        {
            value = regex.Replace(value, arg.ToString()!, 1);
        }

        return value;
    }
}


public class SqlLozalizer<T> : IStringLocalizer<T>
{
    private readonly IRepository<TranslationInfo> _localizationItemRepo;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SqlLozalizer(IRepository<TranslationInfo> localizationItemRepo,
        IHttpContextAccessor httpContextAccessor)
    {
        _localizationItemRepo = localizationItemRepo;
        _httpContextAccessor = httpContextAccessor;
    }
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
        var localizationItems = _localizationItemRepo.GetListAsync().Result;
        return localizationItems.Select(i => new LocalizedString(i.Code, i.Message));
    }

    private LocalizedString GetLocalizedString(string name, params object[] arguments)
    {
        _httpContextAccessor.HttpContext.Items.TryGetValue("language", out var currentLanguage);
        var localizationItem = _localizationItemRepo.FindAsync(i => i.Code == name && i.Language == currentLanguage!.ToString())
            .Result;
        var message = localizationItem?.Message ?? name;

        var formattedMessage = FormatMessage(arguments, message);

        return new LocalizedString(name, formattedMessage);
    }

    private static string FormatMessage(object[] arguments, string message)
    {
        if (arguments is null)
            return message;

        var regex = new Regex("[&]");
        foreach (var arg in arguments)
        {
            message = regex.Replace(message, arg.ToString()!, 1);
        }

        return message;
    }
}
