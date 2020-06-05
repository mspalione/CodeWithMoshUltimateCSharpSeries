using System;

namespace DataBaseStuff
{
    class OracleConnection : DbConnection
    {
        public override void Close()
        {
            Console.WriteLine("oracle close");
        }

        public override void Open()
        {
            Console.WriteLine("oracle open");
        }
    }
}
