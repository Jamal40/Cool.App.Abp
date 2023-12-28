using Volo.Abp.Domain.Entities;

namespace Cool.App.Entities;

public class LocalizationItem : Entity<int>
{
    public string Language { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}
