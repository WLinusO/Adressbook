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

        Person person = new Person();

        Console.Write("Skriv ditt namn: ");
        person.userName = Console.ReadLine();
        profiles.Add(person);
        Console.Write("Skriv in din Ålder: ");
        person.age = int.Parse(Console.ReadLine());





    }
}

class Person
{
    public string userName;
    public int age;

}



