using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public class Subject
    {
        private string groupID;
        private string subject;
        private double point;
        private double point_four;
        private int credits;

        public Subject(string ID, string SJ,double P,double PF,int CR)
        {
            setGroupID(ID);
            setSubject(SJ);
            setPoint(P);
            setPointFour(PF);
            setCredits(CR);
        }

        public void setGroupID(string _groupID)
        {
            groupID = _groupID;
        }

        public string getGroupID()
        {
            return groupID;
        }

        public void setSubject(string _subject)
        {
            subject = _subject;
        }

        public string getSubject()
        {
            return subject;
        }

        public void setPoint(double _point)
        {
            point = _point;
        }

        public double getPoint()
        {
            return point;
        }

        public void setPointFour(double _point_four)
        {
            point_four = _point_four;
        }

        public double getPointFour()
        {
            return point_four;
        }

        public void setCredits(int _credits)
        {
            credits = _credits;
        }

        public int getCredits()
        {
            return credits;
        }

        public string convertToString()
        {
            string result = groupID + "-" + subject + "-" + point + "-" + point_four + "-" + credits;
            return result;
        }
    }
}
