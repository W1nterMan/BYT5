namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType sqlServer)
        {
            if (sqlServer == DatabaseType.SqlServer)
            {
                return new SqlServerDatabase();
            } else if (sqlServer == DatabaseType.Oracle)
            {
                return new OracleDatabase();
            }

            return null;
        }
    }
}
