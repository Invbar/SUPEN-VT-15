using System;
using System.Linq;

namespace DAL.Repositorys
{
    public class UserReopsitory
    {
        public static void Register(Users user){
            try{
                using (var context = new SUPENEntities() ){
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
                
            }
        }


        public static bool ValidateUser(string user){
            using (var context = new SUPENEntities()){
                var result = context.Users.FirstOrDefault(e => e.Username == user);
                if (result != null){
                    return false;
                }
                return true;
            }
        }


    }
}
