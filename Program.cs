using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace UserRoleEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext Db = new MyDbContext())
            {
                var user = Db.User.FirstOrDefault();
                long userId = user.Id;
                var relations = Db.UserRole.Include("Role").Where(x => x.UserId == userId);
                foreach (var relation in relations)
                {
                    Console.WriteLine(user.Name + "-->" + relation.Role.Name);
                }
            }            
        }
    }
}
