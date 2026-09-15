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
            Console.WriteLine("3: Avsluta");
            Console.WriteLine("-------------");
            string answer = Console.ReadLine();

            if (answer == "1")
            {

                Person person = new Person();

                Console.Write("Skriv ditt namn: ");
                person.userName = Console.ReadLine();
                profiles.Add(person);
                Console.Write("Skriv in din Ålder: ");
                person.age = int.Parse(Console.ReadLine()!);


            }

            else if (answer == "2")
            {
                foreach (Person p in profiles)
                {
                    Console.WriteLine($"Namn: {p.userName} Ålder: {p.age} ");
                }
            }
            else
            {
                break;
            }



        }







    }
}

class Person
{
    public string userName;
    public int age;

}



