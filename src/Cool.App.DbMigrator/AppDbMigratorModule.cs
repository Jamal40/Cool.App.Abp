using Cool.App.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Cool.App.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppEntityFrameworkCoreModule),
    typeof(AppApplicationContractsModule)
    )]
public class AppDbMigratorModule : AbpModule
{
}
