using Cool.App.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cool.App.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AppController : AbpControllerBase
{
    protected AppController()
    {
        LocalizationResource = typeof(AppResource);
    }
}
