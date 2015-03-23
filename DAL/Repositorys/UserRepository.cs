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


        public static Users Login(string username, string password){
            Users result = null;
            try{
                using (var context = new SUPENEntities()){
                    result = context.Users.FirstOrDefault(e => (e.Username == username) && (e.uPassword == password));
                    return result;
                }
            }
            catch (Exception ex){
               Console.WriteLine(ex.Message);
               return result;
            }
        }

        public static string GetHashedPassword(string username){
            var password = "";
            try{
                using (var context = new SUPENEntities()){
                    password = context.Users.First(e => e.Username == username).uPassword;
                }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
                
            }
            return password;
        }

    }
}
