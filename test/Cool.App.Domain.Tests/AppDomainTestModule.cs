using Cool.App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cool.App;

[DependsOn(
    typeof(AppEntityFrameworkCoreTestModule)
    )]
public class AppDomainTestModule : AbpModule
{

}
