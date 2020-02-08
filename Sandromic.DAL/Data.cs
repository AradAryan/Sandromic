using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandromic.DAL
{
    static public class Data
    {
        public static SandromicDBEntities sandromic = new SandromicDBEntities();
        public static List<User> GetData()
        {
            var test = sandromic.Users.ToList();
            List<User> users = new List<User>();
            foreach (var item in test)
            {
                users.Add(new User
                { 
                    FirstName = item.FirstName,
                    LastName=item.LastName,
                    NationalCode
                });
            }
            var a = sandromic.Users.Count();
            return null;
        }
    }
}
