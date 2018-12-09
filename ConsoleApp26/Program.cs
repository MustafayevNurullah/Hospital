using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Pediatriya
    {

        public string Name;
        public string Surname;
        public string Experience;
        public string Time1;
        public string Time2;
        public string Time3;

        public Pediatriya(string name, string surname, string experience, string time1, string time2, string time3)
        {
            Name = name;
            Surname = surname;
            Experience = experience;
            Time1 = time1;
            Time2 = time2;
            Time3 = time3;

        }
    }
    class Travmatologiya
    {
        public string Name;
        public string Surname;
        public string Experience;
        public string Time1;
        public string Time2;
        public string Time3;

        public Travmatologiya(string name, string surname, string experience, string time1, string time2, string time3)
        {
            Name = name;
            Surname = surname;
            Experience = experience;
            Time1 = time1;
            Time2 = time2;
            Time3 = time3;

        }
    }
    class Stamotologiya
    {
        public string Name;
        public string Surname;
        public string Experience;
        public string Time1;
        public string Time2;
        public string Time3;

        public Stamotologiya(string name, string surname, string experience, string time1, string time2, string time3)
        {
            Name = name;
            Surname = surname;
            Experience = experience;
            Time1 = time1;
            Time2 = time2;
            Time3 = time3;

        }
    }
    class Program
    {
        static bool Control(string a)
        {
            if(string.IsNullOrWhiteSpace(a)==true || string.IsNullOrEmpty(a)==true)
            {
                return true;
            }
            return false;

        }
        
        static bool Control_Time(int a,int b,int c )
        {
            
            switch (a)
            {
                case 1:
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine( pediatriyas[b - 1].Time1);
                            if (pediatriyas[b - 1].Time1.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                Console.ReadLine();
                                pediatriyas[b - 1].Time1="-";
                                return true;
                            }

                            if (pediatriyas[b - 1].Time1.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }

                            break;
                            
                            case 2:
                            if (pediatriyas[b - 1].Time2.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                pediatriyas[b - 1].Time2="-";
                                Console.ReadLine();
                                return true;
                            }

                            if (pediatriyas[b - 1].Time2.First().ToString() == "-")
                            {
                               
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                        case 3:
                            if (pediatriyas[b - 1].Time3.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                pediatriyas[b - 1].Time3 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (pediatriyas[b - 1].Time3.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (c)
                    {
                        case 1:

                            if (travmatologiyas[b - 1].Time1.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                pediatriyas[b - 1].Time1 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (travmatologiyas[b - 1].Time1.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }

                            break;

                        case 2:
                            if (travmatologiyas[b - 1].Time2.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                travmatologiyas[b - 1].Time2 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (travmatologiyas[b - 1].Time2.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                        case 3:
                            if (travmatologiyas[b - 1].Time3.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                travmatologiyas[b - 1].Time3 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (travmatologiyas[b - 1].Time3.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (c)
                    {
                        case 1:

                            if (stamotologiyas[b - 1].Time1.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                stamotologiyas[b - 1].Time1 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (stamotologiyas[b - 1].Time1.First().ToString() == "-")
                            {
                               
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }

                            break;

                        case 2:
                            if (stamotologiyas[b - 1].Time2.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                stamotologiyas[b - 1].Time2 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (stamotologiyas[b - 1].Time2.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                        case 3:
                            if (stamotologiyas[b - 1].Time3.First().ToString() == "+")
                            {
                                Console.WriteLine("Successful");
                                stamotologiyas[b - 1].Time3 = "-";
                                Console.ReadLine();
                                return true;
                            }

                            if (stamotologiyas[b - 1].Time3.First().ToString() == "-")
                            {
                                
                                Console.WriteLine("Reserved");
                                Console.ReadLine();
                                return false;
                            }
                            break;
                    }
                    break;
                   
            }
            return true;
        }
           static  List<Pediatriya> pediatriyas = new List<Pediatriya>();
            static List<Travmatologiya> travmatologiyas = new List<Travmatologiya>();
            static List<Stamotologiya> stamotologiyas = new List<Stamotologiya>();
       

        static void Main(string[] args)
        {

            pediatriyas.Add(new Pediatriya("Nurulah", "Mustafayev", "1", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            pediatriyas.Add(new Pediatriya("Saleh", "Abdullabeyi", "3", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            pediatriyas.Add(new Pediatriya("Tural", "Mustafayev", "3", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            travmatologiyas.Add(new Travmatologiya("Samir", "Osmanov", "4", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            travmatologiyas.Add(new Travmatologiya("Hesen", "Quliyev", "3", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            stamotologiyas.Add(new Stamotologiya("Hesen", "Umudov", "7", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            stamotologiyas.Add(new Stamotologiya("Elvin", "Eliyev", "9", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            stamotologiyas.Add(new Stamotologiya("Nicat", "Qafarov", "5", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            stamotologiyas.Add(new Stamotologiya("Azer", "Babayev", "6", "+ 09:00-11:00", "+ 12:00-14:00", "+ 15:00-17:00"));
            string a;

               
            while (true)
            {
                int counter = 0;

                Console.Clear();
                string Name;
                string Surname;
                string Mail;
                string Phone;
                do
                {
                    Console.WriteLine("Enter Name");
                     Name = Console.ReadLine();
                } while (Control(Name)==true);
                do
                {
                    Console.WriteLine("Enter Surname");
                    Surname = Console.ReadLine();
                } while (Control(Surname)==true);
                do
                {
                    Console.WriteLine("Enter Mail");
                    Mail = Console.ReadLine();
                } while (Control(Mail)==true);
                do
                {
                    Console.WriteLine("Enter Phone");
                    Phone = Console.ReadLine();
                } while (Control(Phone)==true);
                bool success;
                    int input;
                do
                {

                    Console.WriteLine("Enter Doctors");
                    Console.WriteLine("1->Pediatriya  2->Travmatologiya  3->Stamotologiya");
                    a = Console.ReadLine();
                    success = Int32.TryParse(a, out input);
                } while (success==false|| input>3 || input<1 || Control(a)==true);

                switch (input)
                {
                    case 1:
                        foreach (var item in pediatriyas)
                        {
                            counter++;
                            Console.WriteLine($"{counter}: Name->{item.Name}");
                            Console.WriteLine($"Surname->{item.Surname}");

                        }

                        break;
                    case 2:
                        foreach (var item in travmatologiyas)
                        {
                            counter++;
                            Console.WriteLine($"{counter}: Name->{item.Name}");
                            Console.WriteLine($"Surname->{item.Surname}");

                        }
                        break;
                    case 3:
                        foreach (var item in stamotologiyas)
                        {
                            counter++;
                            Console.WriteLine($"{counter}: Name->{item.Name}");
                            Console.WriteLine($"Surname->{item.Surname}");

                        }
                        break;
                }
                int input_;
                do
                {


                    Console.WriteLine("Enter Doctors");
                     a =Console.ReadLine();
                    success = Int32.TryParse(a, out input_ );


                }while(success==false||Control(a)==true ||counter<input_ ||input_<1);
                switch (input)
                {
                    case 1:

                        int _input;
                        do
                        {
                        Console.WriteLine($"Name->{pediatriyas[input_ - 1].Name}");
                        Console.WriteLine($"Surname->{pediatriyas[input_ - 1].Surname}");
                        Console.WriteLine($"Time->{pediatriyas[input_ - 1].Time1}");
                        Console.WriteLine($"Time->{pediatriyas[input_ - 1].Time2}");
                        Console.WriteLine($"Time->{pediatriyas[input_ - 1].Time3}");
                        Console.WriteLine("+ 09:00-11:00->1     + 12:00-14:00->2  + 15:00-17:00->3");


                            Console.WriteLine("Enter Time");

                              a = Console.ReadLine();
                            success = Int32.TryParse(a, out _input);

                        } while (Control_Time(input,input_,_input)==false || success==false || Control(a)==true ||_input>3 ||_input<1);
                        
                            break;
                        
                    case 2:
                        do
                        {
                        Console.WriteLine($"Name->{travmatologiyas[input_ - 1].Name}");
                        Console.WriteLine($"Surname->{travmatologiyas[input_ - 1].Surname}");
                        Console.WriteLine($"Time->{travmatologiyas[input_ - 1].Time1}");
                        Console.WriteLine($"Time->{travmatologiyas[input_ - 1].Time2}");
                        Console.WriteLine($"Time->{travmatologiyas[input_ - 1].Time3}");
                        Console.WriteLine("+ 09:00-11:00->1     + 12:00-14:00->2  + 15:00-17:00->3");
                       


                            Console.WriteLine("Enter Time");
                           a = Console.ReadLine();
                            success = Int32.TryParse(a, out _input);

                        } while (Control_Time(input, input_, _input) == false || success == false||Control(a)==true || _input > 3 || _input < 1);
                        break;
                    case 3:
                        do
                        {

                        Console.WriteLine($"Name->{stamotologiyas[input_ - 1].Name}");
                        Console.WriteLine($"Surname->{stamotologiyas[input_ - 1].Surname}");
                        Console.WriteLine($"Time->{stamotologiyas[input_ - 1].Time1}");
                        Console.WriteLine($"Time->{stamotologiyas[input_ - 1].Time2}");
                        Console.WriteLine($"Time->{stamotologiyas[input_ - 1].Time3}");
                        Console.WriteLine("+ 09:00-11:00->1     + 12:00-14:00->2  + 15:00-17:00->3");

                            Console.WriteLine("Enter Time");
                           a = Console.ReadLine();
                            success = Int32.TryParse(a, out _input);

                        } while (Control_Time(input, input_, _input) == false || success == false ||Control(a)==true || _input > 3 || _input < 1);
                        break;
                }




            }

        }
    }
}