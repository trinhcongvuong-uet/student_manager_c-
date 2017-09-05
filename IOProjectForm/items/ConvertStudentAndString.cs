using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public abstract class ConvertStudentAndString
    {
        public static Student convertStringToStudent(string itemStudent)
        {
            try
            {
                string[] stringStudent = itemStudent.Split('-');

                string name = stringStudent[0];
                string id = stringStudent[1];
                string group = stringStudent[2];
                string itemSubjects = stringStudent[3];

                List<Subject> listSubject = new List<Subject>();
                if (!itemSubjects.Equals("0"))
                {
                    string[] subjects = itemSubjects.Split('/');
                    for (int i = 0; i < subjects.Length; i++)
                    {
                        string itemSubject = subjects[i];
                        string[] stringSubject = itemSubject.Split('-');
                        string groupID = stringSubject[0];
                        string subjectName = stringSubject[1];
                        double point = double.Parse(stringSubject[2]);
                        double point_four = double.Parse(stringSubject[3]);
                        int credits = int.Parse(stringSubject[4]);
                        Subject subject = new Subject(groupID, subjectName, point, point_four, credits);
                        listSubject.Add(subject);
                    }
                }
                
                

                Student student = new Student(name,id,group,listSubject);
                return student;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static string convertStudentToString(Student student)
        {
            try
            {
                string stringStudent = student.getName()
                                + "-" + student.getID()
                                + "-" + student.getGroup();
                int count = student.getSubjects().Count;
                if(count == 0)
                {
                    return stringStudent + "-" +'0';
                }

                if(count > 1)
                {
                    stringStudent += "-";
                    for (int i = 0; i < count - 1; i++)
                    {
                        stringStudent += student.getSubjects()[i].convertToString() + "/";
                    }
                    stringStudent += student.getSubjects()[count - 1].convertToString();
                }
                else{
                    stringStudent += "-";
                    stringStudent += student.getSubjects()[0].convertToString();
                }
                
                return stringStudent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

    
}
