using System.Data.SqlClient;
using System.Linq;

namespace Model
{
    public class AccountModel
    {
        private ShoeshopdbContext context = null;
        public AccountModel()
        {
            context = new ShoeshopdbContext();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams = new SqlParameter[]{
                new SqlParameter("@username", userName),
                new SqlParameter("@password", password)
            };
            var res = context.Database.SqlQuery<bool>("exec Sp_Account_login @username, @password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
