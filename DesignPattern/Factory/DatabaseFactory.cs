namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType sqlServer)
        {
            switch (sqlServer)
            {
                case DatabaseType.SqlServer: return new SqlServerDatabase();
                case DatabaseType.Oracle: return new OracleDatabase();
                default: return null;
            }
        }
    }
}
