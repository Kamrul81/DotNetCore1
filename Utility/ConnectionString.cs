namespace DotNetCore1.Utility
{
    public static class ConnectionString
    {
        private static string cName = "Server=LAP-0524-0115\\SQLEXPRESS;Database=DbCURDDotNet1;User Id=sa;Password=abc123;Trusted_Connection=True;";
        public static string CName { get => cName; }
    }
}
