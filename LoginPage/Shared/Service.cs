using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginPage.Shared
{
    public static class Service
    {
        public static bool LoginUser(string userName, string password)
        {
            using (var db = new Model.EmployeeContext())
            {
                var rec = db.Login.Where(a => a.UserName == userName && a.Password == password).FirstOrDefault();
                if(rec!=null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
