using System;

namespace DataBaseStuff
{
    class DbCommand
    {
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || string.IsNullOrEmpty(instruction))
            {
                throw new NullReferenceException();
            }
        }

        public void Execute(string instruction)
            : base()
        {
            if ()
            {

            }
            Console.WriteLine(instruction);
        }
    }
}
