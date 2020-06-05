namespace DataBaseStuff
{
    public abstract class DbConnection
    {
        //public string ConnectionString { get; set; }
        //public TimeSpan Timeout { get; set; }

        //public DbConnection(string connectionString)
        //{
        //    if (string.IsNullOrEmpty(connectionString))
        //    {
        //        throw new NullReferenceException();
        //    }
        //}

        public abstract void Open();
        public abstract void Close();
    }
}
