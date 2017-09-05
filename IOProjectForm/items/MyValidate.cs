using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public abstract class MyValidate
    {
        public static bool isStudentExists(Student student, List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].getID().Equals(student.getID()))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isUserExists(User user, List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].getID().Equals(user.getID()))
                {
                    return true;
                }
            }
            return false;
        }

        public static double validatePoint(string itemPoint)
        {
            double point;
            try
            {
                point = double.Parse(itemPoint);
                if(point < 0 ||  point > 10)
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
            return point;
        }

        public static bool validateID(string itemID)
        {
            try
            {
                if(itemID.Length != 8)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool validatePassword(string pass)
        {
            try
            {
                if (pass.Length < 8)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
