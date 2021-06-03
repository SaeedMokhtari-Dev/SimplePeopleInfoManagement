namespace SimplePeopleInfoManagement.DbContext
{
    public static class ConnectionHelper
    {
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PeopleInfoDb"]
                .ConnectionString;
        public static PeopleInfoDbContext getDbConntext()
        {
            string con = System.Configuration.ConfigurationManager.ConnectionStrings["PeopleInfoDb"]
                .ConnectionString;
            return new PeopleInfoDbContext(con);
        }
    }
}