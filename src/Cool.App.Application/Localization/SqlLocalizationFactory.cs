using Cool.App.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using System;
using Volo.Abp.Domain.Repositories;

namespace Cool.App.Localization;

public class SqlLocalizationFactory : IStringLocalizerFactory
{
    private readonly IRepository<TranslationInfo> _localizationItemRepo;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SqlLocalizationFactory(IRepository<TranslationInfo> localizationItemRepo,
        IHttpContextAccessor httpContextAccessor)
    {
        _localizationItemRepo = localizationItemRepo;
        _httpContextAccessor = httpContextAccessor;
    }

    public IStringLocalizer Create(Type resourceSource)
    {
        return new SqlLozalizer(_localizationItemRepo, _httpContextAccessor);
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return new SqlLozalizer(_localizationItemRepo, _httpContextAccessor);
    }
}
