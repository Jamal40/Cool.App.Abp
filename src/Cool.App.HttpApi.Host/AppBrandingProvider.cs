﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cool.App;

[Dependency(ReplaceServices = true)]
public class AppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "App";
}
