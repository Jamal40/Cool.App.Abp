using Volo.Abp.Domain.Entities;

namespace Cool.App.Entities;

public class TranslationInfo : Entity<int>
{
    public string Language { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
