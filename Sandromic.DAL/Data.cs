using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandromic.Model;

namespace Sandromic.DAL
{
    static public class Data
    {
        public static SandromicDBEntities sandromic = new SandromicDBEntities();
        public static List<UserModel> GetData()
        {
            
            List<UserModel> users = new List<UserModel>();
            foreach (var item in sandromic.Users)
            {
                users.Add(new UserModel
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    NationalCode = item.UserName,
                    IsActive = item.IsActive,
                });
            }
            return users;
        }
    }
}
