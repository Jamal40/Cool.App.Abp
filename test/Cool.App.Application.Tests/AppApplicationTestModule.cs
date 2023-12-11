using Volo.Abp.Modularity;

namespace Cool.App;

[DependsOn(
    typeof(AppApplicationModule),
    typeof(AppDomainTestModule)
    )]
public class AppApplicationTestModule : AbpModule
{

}
