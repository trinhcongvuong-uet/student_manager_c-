using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public abstract class ConvertUserAndString
    {
        public static User convertStringToUser(string itemUser)
        {
            User user = null;
            try
            {
                string[] stringUser = itemUser.Split('-');
                user = new User(stringUser[0], stringUser[1]);
                user.setStudentID(stringUser[2]);
                return user;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
                if(user != null){
                    user.setStudentID("");
                    return user;
                }else
                {
                    return null;
                }
            }
        }

        public static string convertUserToString(User user)
        {
            try
            {
                string itemUser = user.getID() + "-" + user.getPassword() + "-" + user.getStudentID();
                return itemUser;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
