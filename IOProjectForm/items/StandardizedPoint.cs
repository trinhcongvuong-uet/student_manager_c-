using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProjectForm
{
    public abstract class StandardizedPoint
    {
        //chuyển điểm cơ số 10 sang điểm ABCD
        public static string standardizedPoint(double point)
        {
            //kiểm tra tham số đầu vào double có thỏa macn là điểm của một môn học 
            if (point < 0 || point > 10)
            {
                return "";
            }
            else
            {
                if (point < 4)
                {
                    return "F";
                }
                else
                {
                    if (point < 5)
                    {
                        return "D";
                    }
                    else
                    {
                        if (point < 5.5)
                        {
                            return "D+";
                        }
                        else
                        {
                            if (point < 6.5)
                            {
                                return "C";
                            }
                            else
                            {
                                if (point < 7)
                                {
                                    return "C+";
                                }
                                else
                                {
                                    if (point < 8)
                                    {
                                        return "B";
                                    }
                                    else
                                    {
                                        if (point < 8.5)
                                        {
                                            return "B+";
                                        }
                                        else
                                        {
                                            if (point < 9)
                                            {
                                                return "A";
                                            }
                                            else
                                            {
                                                return "A+";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //tính xem có passed môn học đó không
        public static string isPassedPoint(double point)
        {
            if (point > 10 || point < 0)
            {
                return null;
            }
            else
            {
                if (point < 4)
                {
                    return "fail";
                }
                else
                {
                    return "passed";
                }
            }
        }

        //chuyển điểm cơ số 10 sang điểm cơ số 4
        public static double pointFour(double pointTen)
        {
            try
            {
                String point = standardizedPoint(pointTen);
                switch (point)
                {
                    case "A+":
                        {
                            return 4;
                        }
                    case "A":
                        {
                            return 3.7;
                        }
                    case "B+":
                        {
                            return 3.5;
                        }
                    case "B":
                        {
                            return 3;
                        }
                    case "C+":
                        {
                            return 2.5;
                        }
                    case "C":
                        {
                            return 2;
                        }
                    case "D+":
                        {
                            return 1.5;
                        }
                    case "D":
                        {
                            return 1;
                        }
                    case "F":
                        {
                            return 0;
                        }
                    default:
                        break;
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            return 0;
        }
    }
}
