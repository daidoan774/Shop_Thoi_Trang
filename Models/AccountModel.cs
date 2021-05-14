using Models.Connect_to_SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Models
{

    

    public class AccountModel
    {
        private ShopThoiTrang context = null;
        
        public AccountModel() 
        {
            context = new ShopThoiTrang();
        }
        public bool Login(string userName,  string password)
        {
            object[] sqlParams = 
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@Password", password)
            };

            var res = context.Database.SqlQuery<bool>("sp_Account @UserName, @Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
        
    
}
