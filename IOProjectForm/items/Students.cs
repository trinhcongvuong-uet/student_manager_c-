using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public class Student
    {
        private string name;
        private string id;
        private string group;
        private double point;
        private List<Subject> subjects;

        public Student(string _name, string _id, string _group)
        {
            setName(_name);
            setID(_id);
            setGroup(_group);
            point = 0;
            subjects = new List<Subject>();
        }

        public Student(string _name,string _id, string _group, List<Subject> _subjects)
        {
            setName(_name);
            setID(_id);
            setGroup(_group);
            subjects = _subjects;
            calculatePoint();
        }

        public bool insertSubject(Subject subject)
        {
            try
            {
                int indexSubject = findSubject(subject.getGroupID());
                if(indexSubject == -1)
                {
                    return false;
                }else
                {
                    updateSubject(indexSubject,subject);
                    return true;
                }
            }catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Subject> getSubjects()
        {
            return subjects;
        }

        public double calculatePoint()
        {
            try
            {
                double _point = subjects[0].getPoint();
                int _credits = subjects[0].getCredits();
                for(int i = 1; i < subjects.Count; i++)
                {
                    _point = (_point * _credits + subjects[i].getPoint() * subjects[i].getCredits())/(_credits + subjects[i].getCredits());
                    _credits += subjects[i].getCredits();
                }
                return +_point;
            }catch(Exception e)
            {
                Console.Write(e.Message);
                return 0;
            }
        }

        public int calculateCredits()
        {
            try
            {
                int credits = 0;
                for (int i = 0; i < subjects.Count; i++)
                {
                    credits += subjects[i].getCredits();
                }
                return credits;
            }
            catch
            {
                return 0;
            }
        }

        public double getPoint()
        {
            return point;
        }

        private int findSubject(string subjectID)
        {
            try
            {
                for (int i = 0; i < subjects.Count; i++)
                {
                    if (subjects[i].getGroupID().Equals(subjectID))
                    {
                        return i;
                    }
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            return -1;
        }

        private void updateSubject(int index,Subject update)
        {
            try
            {
                if (index == findSubject(update.getGroupID()) && update.getPoint() > subjects[index].getPoint())
                {
                    subjects[index] = update;
                }
            }
            catch
            {
                return;
            }
        }

        public void setName(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }

        public void setID(string _id)
        {
            id = _id;
        }

        public string getID()
        {
            return id;
        }

        public void setGroup(string _group)
        {
            group = _group;
        }

        public string getGroup()
        {
            return group;
        }

        public string toString()
        {
            string _name = "Name:\t\t" + name +"\n";
            string _id = "ID:\t\t" + id + "\n";
            string _group = "Group:\t\t" + group + "\n";
            return _name + _id + _group;
        }
    }
}
