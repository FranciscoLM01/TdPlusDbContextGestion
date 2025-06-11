using TdPlusDbContextGestion.Infrastructure.DbContext;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;


namespace TdPlusDbContextGestion.Infrastructure.DbContext;

public class LegacyConnection
{
    private readonly ApplicationSettings _applicationSettings;

    public LegacyConnection(IOptions<ApplicationSettings> Application)
    {
        _applicationSettings = Application.Value;
    }

    public MySqlConnection CreateConnection()
        => new MySqlConnection(_applicationSettings.MySQL);

}



