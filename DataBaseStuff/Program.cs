namespace DataBaseStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection();
            var instruction = "This is the instruction to the DB.";
            var command = new DbCommand(sql, instruction);
            
            command.Execute(instruction);
        }
    }
}
