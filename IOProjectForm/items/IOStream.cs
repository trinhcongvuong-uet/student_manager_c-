using System;
using System.Collections.Generic;
using System.IO;

namespace IOProjectForm
{
    public abstract class IOStream
    {
        public static bool writeLineStudent(String pathFile,List<Student> content, bool flag)
        {
            System.IO.FileStream fs;
            if (!File.Exists(pathFile))
            {
                var directory = Directory.CreateDirectory(Path.GetDirectoryName(pathFile));
                fs = new System.IO.FileStream(pathFile, System.IO.FileMode.CreateNew);
            }
            else
            {
                if(flag)
                    fs = new System.IO.FileStream(pathFile, System.IO.FileMode.Append);
                else
                    fs = new System.IO.FileStream(pathFile, System.IO.FileMode.Create);
            }

            using (StreamWriter streamWriter = new StreamWriter(fs))
            {
                try
                {
                    for (int i = 0; i < content.Count; i++)
                    {
                        streamWriter.WriteLine(ConvertStudentAndString.convertStudentToString(content[i]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static List<Student> readLineStudent(String pathFile)
        {
            System.IO.FileStream fs;
            if (!File.Exists(pathFile))
            {
                var directory = Directory.CreateDirectory(Path.GetDirectoryName(pathFile));
                fs = new System.IO.FileStream(pathFile, System.IO.FileMode.CreateNew);
                return new List<Student>();
            }
            else
            {
                List<Student> content = new List<Student>();
                try
                {
                    using (var streamReader = File.OpenText(pathFile))
                    {
                        string item = "";
                        Student student;
                        while ((item = streamReader.ReadLine()) != null)
                        {
                            student = ConvertStudentAndString.convertStringToStudent(item);
                            content.Add(student);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new List<Student>();
                }
                return content;
            }
            
        }

        public static bool writeLineUser(String pathFile, List<User> content, bool flag)
        {
            System.IO.FileStream fs;
            if (!File.Exists(pathFile))
            {
                var directory =  Directory.CreateDirectory(Path.GetDirectoryName(pathFile));
                fs = new System.IO.FileStream(pathFile, System.IO.FileMode.CreateNew);
            }else
            {
                fs = new System.IO.FileStream(pathFile, System.IO.FileMode.Append);
            }

            using (StreamWriter streamWriter = new StreamWriter(fs))
            {
                try
                {
                    for (int i = 0; i < content.Count; i++)
                    {
                        streamWriter.WriteLine(ConvertUserAndString.convertUserToString(content[i]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        public static List<User> readLineUser(String pathFile)
        {
            if (!File.Exists(pathFile))
            {
                return null;
            }

            List<User> content = new List<User>();
            try
            {
                using (StreamReader streamReader = File.OpenText(pathFile))
                {
                    string item = "";
                    User user;
                    while ((item = streamReader.ReadLine()) != null)
                    {
                        user = ConvertUserAndString.convertStringToUser(item);
                        content.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<User>();
            }
            
            return content;
        }
    }
}
