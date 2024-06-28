namespace C__13._1
{
    class Program
    {
        static void Main()
        {
            /*
            var g = new Group();
            Student s = new Student();
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
            s.AddStudent(s);
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());

            Student s1 = new Student("Аркадий", "Борисович", "Максименко", "20.10.2001", "г.Николаев", "09765225445", 10, 9, 12);
            s1.AddStudent(s1);
            Console.WriteLine(g.ToString());

            Console.WriteLine(s == s1);//==
            Console.WriteLine(s != s1);//!=
            Console.WriteLine(s > s1);//>
            Console.WriteLine(s < s1);//<
            
            if (s)//true/false
            {
                Console.WriteLine("Студент есть!");
            }
            else { Console.WriteLine("Студент отсутствует!"); }
            
            Group g1 = new Group("ПВ313", "HTML", 1);
            Group g2 = new Group("ПВ314", "R ", 1);
            Console.WriteLine(g == g1);//==
            Console.WriteLine(g != g1);//!=

            //g.FindByName("Программирование");
            //g.FindByCourse(2);*/

            /*  var g = new Group();
              g.Name = "Test";
              g.Specialization = "Test";
              g.Course = 2;
              Student s = new Student();
              Console.WriteLine(g.ToString());
              Console.WriteLine(s.ToString());
              Console.WriteLine();
              s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
              s.AddStudent(s);
              Console.WriteLine(g.ToString());
              Console.WriteLine(s.ToString());

              g.FindByCourse(2);
              var g1 = new Group();
              g1.Name = "Test";
              g1.Specialization = "Test";
              g1.Course = 2;*/

            var g = new Group();
            Student s = new Student();
            s = new Student("Федор", "Иванович", "Аврамов", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
            g.AddStudent(s);
            Student s1 = new Student("Аркадий", "Борисович", "Максименко", "20.10.2001", "г.Николаев", "09765225445", 10, 9, 12);
            g.AddStudent(s1);

            foreach (Student student in g)
            {
                Console.WriteLine(student.ToString());
            }


            //s.GetGun += s.StartEventGetGun;
            //s1.Oversleep += s1.StartEventOversleep;
            //s.GetAGun();
            //s1.OversleepLesson();

            foreach (Student student in g)
            {
               g.EventExam += G_EventExam;
            }

            g.StartEventExam();

            foreach (Student student in g)
            {
                g.EventProjectProtection += G_EventProjectProtection;
            }

            g.StartEventProjectProtection();
        }



        private static void G_EventExam()
        {
            Console.WriteLine("Cтудент группы сдаёт экзамен!");
        }

        private static void G_EventProjectProtection()
        {
            Console.WriteLine("Cтудент группы проходит защиту проекта!");
        }
    }
}
