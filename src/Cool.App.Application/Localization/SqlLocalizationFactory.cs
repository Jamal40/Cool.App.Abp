using Cool.App.Entities;
using Microsoft.Extensions.Localization;
using System;
using Volo.Abp.Domain.Repositories;

namespace Cool.App.Localization;

public class SqlLocalizationFactory : IStringLocalizerFactory
{
    private readonly IRepository<LocalizationItem> _localizationItemRepo;

    public SqlLocalizationFactory(IRepository<LocalizationItem> localizationItemRepo)
    {
        _localizationItemRepo = localizationItemRepo;
    }

    public IStringLocalizer Create(Type resourceSource)
    {
        return new SqlLozalizer(_localizationItemRepo);
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return new SqlLozalizer(_localizationItemRepo);
    }
}
