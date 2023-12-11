using System.Threading.Tasks;

namespace Cool.App.Data;

public interface IAppDbSchemaMigrator
{
    Task MigrateAsync();
}
