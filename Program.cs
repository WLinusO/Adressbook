// namespace Lektion_7;

// class Program
// {
//     static void Main()
//     {











//     }









// }

class Program
{

    static List<Person> profiles = new List<Person>();




    static void Main()
    {


        while (true)
        {


            Console.WriteLine("-------------");
            Console.WriteLine("Välj ett av följande val: ");
            Console.WriteLine("1: Skapa en Profil ");
            Console.WriteLine("2: Se alla profiler: ");
            Console.WriteLine("3: Redigera Profil: ");
            Console.WriteLine("4: Avsluta");
            Console.WriteLine("-------------");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                Person person = new Person();

                Console.Write("Skriv ditt namn: ");
                person.userName = Console.ReadLine();
                profiles.Add(person);
                Console.Write("Skriv in din Ålder: ");
                person.age = int.Parse(Console.ReadLine()!);


            }

            else if (answer == "2")
            {
                callPerson();
            }

            else if (answer == "3")
            {
                Console.Write("Vilken profil vill du redigera?: ");

                callPerson();

                int choice = int.Parse(Console.ReadLine());

                Console.Write($"Vem vill du ersätta {profiles[choice].userName} med?: ");

                profiles[choice].userName = Console.ReadLine();

                Console.Write($"Hur gammal är {profiles[choice].userName}: ");

                profiles[choice].age = int.Parse(Console.ReadLine());








            }

            /// Jag behöver komma in i min lista för att välja ut ett objekt som har skapats och ska redigera det.


            else
            {
                break;
            }



        }


        static void callPerson()
        {
            foreach (Person p in profiles)
            {
                Console.WriteLine($"Namn: {p.userName} Ålder: {p.age} ");
            }
        }




    }
}

class Person
{
    public string userName;
    public int age;

}



