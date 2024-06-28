using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__13._1
{
       class Group : IEnumerable
        {
            public delegate void MyEventHandler1();

            public event MyEventHandler1 EventExam;
            public event MyEventHandler1 EventProjectProtection;

            List<Student> group = new List<Student>();

            private enum Specializations { Programming, HTML, Cybersecurity };
            public string name;
            public string Name
            {
                get { return name != null ? name : "Не задано"; }
                set { name = value; }
            }
            public string specialization;
            public string Specialization
            {
                get { return specialization != null ? specialization : "Не задано"; }
                set { specialization = value; }
            }
            public int course;
            public int Course
            {
                get { return course != 0 ? course : 0; }
                set { course = value; }
            }

            public Group() : this("ПВ312", "Программирование", 2)
            {
                //Console.WriteLine ("c-tor without params");
            }

            //main c-tor
            public Group(string name, string specialization, int course)
            {
                Name = name;
                Specialization = specialization;
                Course = course;
                //Console.WriteLine("main c-tor");
            }

            /* public Group() : this("ПВ312", "Программирование", 2)
             {
                 //Console.WriteLine ("c-tor without params");
             }

             //main c-tor
            /* public Group(string name, string specialization, int course)
             {
                 SetName(name);
                 SetSpecialization(specialization);
                 SetCourse(course);
                 //Console.WriteLine("main c-tor");
             }

             /*public void SetName(string name)
             {
                 this.name = name;
             }

             public void SetSpecialization(string specialization)
             {
                 this.specialization = specialization;
             }

             public void SetCourse(int number)
             {
                 course = number;
             }
             */
            public void AddStudent(Student student)
            {
                group.Add(student);
            }

            public override string ToString()
            {
                return name + " " + specialization + " " + course + " ";
            }

            public override bool Equals(object obj)
            {
                return this.ToString() == obj.ToString();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return group.GetEnumerator();
            }


            public static bool operator ==(Group left, Group right)
            {
                if ((object)left != null) return left.Equals(right);
                if ((object)right != null) return right.Equals(left);

                return left.specialization == right.specialization;
            }

            public static bool operator !=(Group left, Group right)
            {
                return !(left.specialization == right.specialization);
            }

            private Group[] groupArr;
            public Group(int size)
            {
                groupArr = new Group[size];
            }
            public int Length
            {
                get { return groupArr.Length; }
            }
            public Group this[uint index]
            {
                get
                {
                    if (index >= 0 && index < groupArr.Length)
                    {
                        return groupArr[index];
                    }
                    throw new IndexOutOfRangeException();
                }
                set
                {
                    groupArr[index] = value;
                }
            }
            public Group this[string specialization]
            {
                get
                {
                    if (Enum.IsDefined(typeof(Specializations), specialization))
                    {
                        return groupArr[(int)Enum.Parse(typeof(Specializations), specialization)];
                    }
                    else
                    {
                        return new Group();
                    }
                }
                set
                {
                    if (Enum.IsDefined(typeof(Specializations), specialization))
                    {
                        groupArr[(int)Enum.Parse(typeof(Specializations), specialization)] = value;
                    }
                }
            }
            public int FindByCourse(int course)
            {
                for (int i = 0; i < groupArr.Length; i++)
                {
                    if (groupArr[i].course == course)
                    {
                        return i;
                    }
                }
                return -1;
            }

            public Group this[int course]
            {
                get
                {
                    if (FindByCourse(course) >= 0)
                    {
                        return this[FindByCourse(course)];
                    }
                    throw new Exception("Недопустимое значение курса.");
                }
                set
                {
                    if (FindByCourse(course) >= 0)
                    {
                        this[FindByCourse(course)] = value;
                    }
                }
            }

            public int FindByName(string name)
            {
                for (int i = 0; i < groupArr.Length; i++)
                {
                    if (groupArr[i].name == name)
                    {
                        return i;
                    }
                }
                return -1;
            }

            /*public Group this[string name]
            {
                get
                {
                    if (FindByName(name) >= 0)
                    {
                        return this[FindByName(name)];
                    }
                    throw new Exception("Недопустимое имя группы.");
                }
                set
                {
                    if (FindByName(name) >= 0)
                    {
                        this[FindByName(name)] = value;
                    }
                }
            }*/

            public void StartEventExam()
            {
                if (EventExam != null) EventExam();
            }

            public void StartEventProjectProtection()
            {
                if (EventProjectProtection != null) EventProjectProtection();
            }


        }

    }


