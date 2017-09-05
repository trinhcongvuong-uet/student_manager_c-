using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public class User
    {
        private string id;
        private string password;
        private string studentID;

        public User(string id,string password)
        {
            setID(id);
            setPassword(password);
            setStudentID("");
        }

        public void setID(string id)
        {
            this.id = id;
        }

        public string getID()
        {
            return id;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }

        public void setStudentID(string id)
        {
            studentID = id;
        }

        public string getStudentID()
        {
            return studentID;
        }
    }
}
