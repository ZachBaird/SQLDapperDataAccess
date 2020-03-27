using System.Configuration;

namespace FormUI.Helpers
{
    public static class ConnectionHelper
    {
        public static string CnnVal(string name) =>        
            ConfigurationManager.ConnectionStrings[name].ConnectionString;        
    }
}
