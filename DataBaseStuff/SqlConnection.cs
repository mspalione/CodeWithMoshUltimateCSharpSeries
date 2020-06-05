using System;

namespace DataBaseStuff
{
    class SqlConnection : DbConnection
    {
        public override void Close()
        {
            Console.WriteLine("sql close");
        }

        public override void Open()
        {
            Console.WriteLine("sql open");
        }
    }
}
