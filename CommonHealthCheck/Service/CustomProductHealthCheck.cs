using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using System.Threading;
using System.Threading.Tasks;

public class SqlServerHealthCheck : IHealthCheck
{ 
    private readonly string _connectionString;
    public SqlServerHealthCheck(string connectionString) 
    {
        _connectionString = connectionString;
    } 
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try {
            using var sqlConnection = new SqlConnection(_connectionString);
            await sqlConnection.OpenAsync(cancellationToken);
            using var command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT 1";
            await command.ExecuteScalarAsync(cancellationToken);
            return HealthCheckResult.Healthy("SQL Server is healthy");
        } 
        catch (Exception ex) 
        { 
            return HealthCheckResult.Unhealthy("SQL Server is unhealthy", ex);
        } 
    }
}
public class MySqlHealthCheck : IHealthCheck
{
    private readonly string _connectionString;
    public MySqlHealthCheck(string connectionString)
    {
        _connectionString = connectionString; 
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default) 
    { 
        try {
            using var mySqlConnection = new MySqlConnection(_connectionString); await mySqlConnection.OpenAsync(cancellationToken);
            using var command = mySqlConnection.CreateCommand(); command.CommandText = "SELECT 1"; await command.ExecuteScalarAsync(cancellationToken);
            return HealthCheckResult.Healthy("MySQL is healthy");
        } 
        catch (Exception ex) 
        {
            return HealthCheckResult.Unhealthy("MySQL is unhealthy", ex); 
        }
    }
}
public class PostgreSqlHealthCheck : IHealthCheck
{
    private readonly string _connectionString;
    public PostgreSqlHealthCheck(string connectionString) 
    {
        _connectionString = connectionString;
    }
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try {
            using var npgsqlConnection = new NpgsqlConnection(_connectionString);
            await npgsqlConnection.OpenAsync(cancellationToken); using var command = npgsqlConnection.CreateCommand();
            command.CommandText = "SELECT 1";
            await command.ExecuteScalarAsync(cancellationToken);
            return HealthCheckResult.Healthy("PostgreSQL is healthy");
        } 
        catch (Exception ex)
        { 
            return HealthCheckResult.Unhealthy("PostgreSQL is unhealthy", ex); 
        } 
    } 
}