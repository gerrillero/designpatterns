namespace Factory
{
    public class ConnectionFactory
    {
        public IConnection GetConnection(Engine engine)
        {
            switch (engine)
            {
                case Engine.MSSQL:
                    return new MSSQLConnection();
                case Engine.MySQL:
                    return new MySQLConnection();
                case Engine.Oracle:
                    return new OracleConnection();
                case Engine.MongoDB:
                    return new MongoDBConnection();
                default:
                    return new MySQLConnection();
            }
        }
    }
}
