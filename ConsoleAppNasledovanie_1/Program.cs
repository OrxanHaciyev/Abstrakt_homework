using System;

namespace ConsoleAppNasledovanie_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("H.Orxan",2,345);
            st1.Print();
            st1.ToString();

            Aspirant asp1 = new Aspirant("N.Elmar",3,456,"base c#");
            asp1.Print();
            Console.WriteLine(st1.GetHashCode());
            Console.WriteLine(asp1.GetHashCode());
            Console.WriteLine(st1.GetType());
            Console.WriteLine(asp1.GetType());
            Console.ReadKey();

        }
    }
    abstract class Human
    {
        public string Lastname { get; set; }
        public int Kurs { get; set; }
        public int Zacetka { get; set; }
        
        public Human(string lastname, int kurs, int zacetka)
        {
            Lastname = lastname;
            Kurs = kurs;
            Zacetka = zacetka;

        }
        public abstract void Print();
        public abstract int ValidKurs();
        public abstract int Validnum();
    }
    
    class Student : Human
    {

        public Student(string lastname, int kurs, int zacetka) : base(lastname, kurs, zacetka)
        {
            
            Console.WriteLine("введите имя студента");
            Lastname = Console.ReadLine();
            Console.WriteLine("введите курс(1-9)");
            Kurs = ValidKurs();
            Console.WriteLine("введите номер №000");
            Zacetka = Validnum();
        }
        
        public override void Print()
        {
            Console.WriteLine($"студент :{Lastname}\nна :{Kurs} курсе \nномер зачетной книжки :{Zacetka}");
        }
        public override int ValidKurs()
        {
            int num1;
            bool triger = false;
            do
            {

                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 10)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("вы ввели неверное число");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        public override int Validnum()
        {
            int num1;
            bool triger = false;
            do
            {

                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 999)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("вы ввели неверное число");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Lastname))
                return base.ToString();
            return Lastname;
        }

    }
    class Aspirant : Human
    {
        private string tema;
        
        public Aspirant(string lastname, int kurs, int zacetka, string tema) : base(lastname, kurs, zacetka)
        {
            this.Tema = tema;
            Console.WriteLine("введите имя аспиранта");
            Lastname = Validstring();
            Console.WriteLine("введите курс(1-9)");
            Kurs = ValidKurs();
            Console.WriteLine("введите номер книжки(№000)");
            Zacetka = Validnum();
            Console.WriteLine("введите тему");
            Tema = Validstring();
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public override void Print()
        {

          
       Console.WriteLine($"аспирант :{Lastname}\nна :{Kurs} курсе \nномер зачетной книжки :{Zacetka}\nтема десертации :{Tema} ");
        }
        
        public override int ValidKurs()
        {
            int num1;
            bool triger = false;
            do
            {
               
                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1<10)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("вы ввели неверное число");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        public override int Validnum()
        {
            int num1;
            bool triger = false;
            do
            {

                if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 999)
                {
                    triger = true;
                }
                else
                {
                    Console.WriteLine("вы ввели неверное число");
                    continue;
                }
            }
            while (triger == false);
            return num1;
        }
        public static string Validstring()
        {
            bool check = true;
            string name;
            do
            {
                name = Console.ReadLine();
                foreach (char a in name)
                {
                    if (a >= '0' && a <= '9')
                    {
                        Console.WriteLine("введите снова");
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
            } while (check == false);
            return name;
        }

    }
}
